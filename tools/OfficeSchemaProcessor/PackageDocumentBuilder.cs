// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace OfficeSchemaProcessor
{
    internal sealed class PackageDocumentBuilder : IDisposable
    {
        private readonly AdhocWorkspace _workspace;
        private readonly SyntaxGenerator _generator;
        private readonly DirectoryInfo _path;
        private readonly WellKnownTypes _types;
        private readonly WellKnownExpressions _expressions;

        public PackageDocumentBuilder(string path)
        {
            _workspace = new AdhocWorkspace();
            _generator = SyntaxGenerator.GetGenerator(_workspace, LanguageNames.CSharp);
            _path = new DirectoryInfo(path);
            _types = new WellKnownTypes(_generator);
            _expressions = new WellKnownExpressions(_generator);

            if (!_path.Exists)
            {
                _path.Create();
            }
        }

        public void Dispose()
        {
            _workspace.Dispose();
        }

        public void WriteFile(OpenXmlType type)
        {
            var path = Path.Combine(_path.FullName, $"{type.Name}.g.cs");

            using (var stream = File.OpenWrite(path))
            {
                stream.SetLength(0);

                using (var writer = new StreamWriter(stream, new UTF8Encoding(true)))
                {
                    var options = _workspace.Options;

                    var node = GetCompilationUnit(type);
                    var formatted = Formatter.Format(node, _workspace, options);

                    formatted.WriteTo(writer);
                    writer.WriteLine();
                }
            }
        }

        private CompilationUnitSyntax GetCompilationUnit(OpenXmlType type)
        {
            return CompilationUnit()
                .WithMembers(SingletonList(GetNamespace(type)))
                .WithUsings(List(GetUsings()))
                .AddLicense();
        }

        private IEnumerable<UsingDirectiveSyntax> GetUsings()
        {
            yield return UsingDirective(IdentifierName("System"));
            yield return UsingDirective(ParseName("System.Collections.Generic"));
        }

        private MemberDeclarationSyntax GetNamespace(OpenXmlType type)
        {
            var ns = (NamespaceDeclarationSyntax)_generator.NamespaceDeclaration("DocumentFormat.OpenXml.Packaging");

            return ns.WithMembers(SingletonList<MemberDeclarationSyntax>(GetClass(type)));
        }

        private IEnumerable<TypeSyntax> GetInterfacesTypes(OpenXmlType type)
        {
            if (type.HasFixedContent)
            {
                yield return ParseTypeName("IFixedContentTypePart");
            }
        }

        private ClassDeclarationSyntax GetClass(OpenXmlType type)
        {
            return (ClassDeclarationSyntax)_generator.ClassDeclaration(
                type.Name,
                baseType: ParseTypeName(type.Base),
                accessibility: Accessibility.Public,
                modifiers: DeclarationModifiers.Partial,
                interfaceTypes: GetInterfacesTypes(type),
                members: GetMembers(type))
                .AddDocumentationComment($"Defines the {type.Name}");
        }

        private IEnumerable<SyntaxNode> GetMembers(OpenXmlType type)
        {
            IEnumerable<SyntaxNode> Combine(params IEnumerable<SyntaxNode>[] items)
            {
                return items
                    .SelectMany(i => i)
                    .Where(i => i != null)
                    .OrderBy(i => i, SyntaxOrderers.ByType)
                    .ThenBy(i => i, SyntaxOrderers.ByName);
            }

            return Combine(
                GetConstants(type),
                GetContstraintFields(type),
                GetConstructors(type),
                GetConstraintMethods(type),
                GetStronglyTypedProperties(type),
                GetTypedPartProperties(type),
                GetIsInVersionMethod(type),
                new[] { GetCreatePartCoreMethod(type) },
                GetAddPartMethods(type)
                );
        }

        private IEnumerable<MethodDeclarationSyntax> GetIsInVersionMethod(OpenXmlType type)
        {
            if (type.AvailableInAllVersions)
            {
                yield break;
            }

            var method = (MethodDeclarationSyntax)_generator.MethodDeclaration(
                "IsInVersion",
                parameters: new[] { _generator.ParameterDeclaration("version", ParseTypeName("FileFormatVersions")) },
                returnType: _types.SystemBoolean,
                accessibility: Accessibility.Internal,
                modifiers: DeclarationModifiers.Override);

            yield return method
                .WithExpressionBody(ArrowExpressionClause(ParseExpression($"version.AtLeast(FileFormatVersions.{type.FileFormatVersion})")))
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                .WithBody(null)
                .InheritDocumentation();
        }

        private IEnumerable<FieldDeclarationSyntax> GetContstraintFields(OpenXmlType type)
        {
            yield return CreateConstraintField("_partConstraint", type.GetSubElements().Where(i => !i.Type.IsDataPartReference));
            yield return CreateConstraintField("_dataPartReferenceConstraint", type.GetSubElements().Where(i => i.Type.IsDataPartReference));
        }

        private MethodDeclarationSyntax GetCreatePartCoreMethod(OpenXmlType type)
        {
            const string RelationshipTypeParameter = "relationshipType";

            var switchStatements = type.GetSubElements()
                .Where(i => !i.Type.IsDataPartReference)
                .Select(p =>
                {
                    return _generator.SwitchSection(
                        ParseExpression($"{p.Type.Name}.RelationshipTypeConstant"),
                        new[] { _generator.ReturnStatement(_generator.ObjectCreationExpression(ParseTypeName(p.Type.Name))) });
                })
                .ToList();

            if (!switchStatements.Any())
            {
                return null;
            }

            var @switch = _generator.SwitchStatement(ParseName(RelationshipTypeParameter), switchStatements);

            var statements = new[]
            {
                    ParseExpression("ThrowIfObjectDisposed()"),
                    _generator.IfStatement(
                        IsPatternExpression(
                            ParseExpression(RelationshipTypeParameter),
                            ConstantPattern(LiteralExpression(SyntaxKind.NullLiteralExpression))), new[]
                            {
                                _expressions.ThrowArgumentNull(RelationshipTypeParameter),
                            }),
                    @switch,
                    _expressions.ThrowArgumentOutOfRange(RelationshipTypeParameter)
                };

            var method = (MethodDeclarationSyntax)_generator.MethodDeclaration(
                "CreatePartCore",
                parameters: new[] { _generator.ParameterDeclaration("relationshipType", _types.SystemString) },
                returnType: ParseTypeName("OpenXmlPart"),
                accessibility: Accessibility.Internal,
                modifiers: DeclarationModifiers.Sealed | DeclarationModifiers.Override,
                statements: statements);

            return method
                .InheritDocumentation();
        }

        private IEnumerable<PropertyDeclarationSyntax> GetTypedPartProperties(OpenXmlType type)
        {
            return type.GetSubElements()
                .Where(i => !i.Type.IsDataPartReference)
                .Select(p =>
                {
                    var (returnType, expression) = p.MaxOccursGreatThanOne
                        ? ($"IEnumerable<{p.Type.Name}>", $"GetPartsOfType<{p.Type.Name}>()")
                        : (p.Type.Name, $"GetSubPartOfType<{p.Type.Name}>()");

                    var property = (PropertyDeclarationSyntax)_generator.PropertyDeclaration(
                        p.ApiName,
                        type: ParseTypeName(returnType),
                        accessibility: Accessibility.Public);

                    return property
                        .WithAccessorList(null)
                        .WithExpressionBody(ArrowExpressionClause(ParseExpression(expression)))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        .AddDocumentationComment($"Gets the {p.ApiName} of the {type.Name}");
                });
        }

        private IEnumerable<ConstructorDeclarationSyntax> GetConstructors(OpenXmlType type)
        {
            var constructor = (ConstructorDeclarationSyntax)_generator.ConstructorDeclaration(accessibility: Accessibility.ProtectedOrInternal);

            yield return constructor
                .AddDocumentationComment($"Creates an instance of the {type.Name} OpenXmlType");
        }

        private IEnumerable<MethodDeclarationSyntax> GetConstraintMethods(OpenXmlType type)
        {
            MethodDeclarationSyntax CreateConstraintOverrides(string name, string dictionaryName)
            {
                var method = (MethodDeclarationSyntax)_generator.MethodDeclaration(
                    name,
                    returnType: _types.PartContstraintIDictionary,
                    accessibility: Accessibility.Internal,
                    modifiers: DeclarationModifiers.Sealed | DeclarationModifiers.Override);

                return method
                    .WithExpressionBody(ArrowExpressionClause(ParseName(dictionaryName)))
                    .WithBody(null)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .InheritDocumentation();
            }

            yield return CreateConstraintOverrides("GetPartConstraint", "_partConstraint");
            yield return CreateConstraintOverrides("GetDataPartReferenceConstraint", "_dataPartReferenceConstraint");
        }

        private FieldDeclarationSyntax CreateConstraintField(string name, IEnumerable<OpenXmlElement> constraintInfo)
        {
            var constraintList = constraintInfo
                .Select(t =>
                {
                    return InitializerExpression(
                        SyntaxKind.CollectionInitializerExpression,
                        SeparatedList<ExpressionSyntax>(new SyntaxNodeOrToken[]
                        {
                            _generator.LiteralExpression(t.Type.RelationshipType),
                            Token(SyntaxKind.CommaToken),
                            _generator.ObjectCreationExpression(
                                ParseTypeName("PartConstraintRule"),
                                _generator.NameOfExpression(ParseTypeName(t.Type.Name)),
                                t.Type.HasFixedContent ? ParseExpression($"{t.Type.Name}.ContentTypeConstant") : _generator.NullLiteralExpression(),
                                _types.GetExpression(t.MinOccursIsNonZero),
                                _types.GetExpression(t.MaxOccursGreatThanOne),
                                ParseExpression($"FileFormatVersions.{t.Type.FileFormatVersion}.AndLater()"))
                        })).WithLeadingTrivia(LineFeed);
                });

            var collectionInitializer = InitializerExpression(
                SyntaxKind.CollectionInitializerExpression,
                SeparatedList<ExpressionSyntax>(constraintList));
            var initializer = ((ObjectCreationExpressionSyntax)_generator.ObjectCreationExpression(_types.PartConstraintDictionary, ParseExpression("StringComparer.Ordinal")))
                .WithInitializer(collectionInitializer);
            return (FieldDeclarationSyntax)_generator.FieldDeclaration(
                name,
                _types.PartConstraintDictionary,
                Accessibility.Private,
                DeclarationModifiers.Static | DeclarationModifiers.ReadOnly,
                initializer);
        }

        private IEnumerable<PropertyDeclarationSyntax> GetStronglyTypedProperties(OpenXmlType type)
        {
            return type.GetFields()
                .Select(info =>
                {
                    var (name, value, isPublic, createConstant) = info;

                    var property = (PropertyDeclarationSyntax)_generator.PropertyDeclaration(
                        name,
                        _types.GetType(value),
                        isPublic ? Accessibility.Public : Accessibility.Internal,
                        DeclarationModifiers.Override | DeclarationModifiers.Sealed);

                    var expression = createConstant
                        ? ParseExpression(GetConstantName(name))
                        : (ExpressionSyntax)_generator.LiteralExpression(value);

                    return property
                        .WithAccessorList(null)
                        .WithExpressionBody(ArrowExpressionClause(expression))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        .InheritDocumentation();
                });
        }

        private IEnumerable<SyntaxNode> GetConstants(OpenXmlType type)
        {
            return type.GetFields()
                .Where(info => info.createConstant)
                .Select(info =>
                {
                    return (FieldDeclarationSyntax)_generator.FieldDeclaration(
                        GetConstantName(info.name),
                        _types.GetType(info.value),
                        Accessibility.Internal,
                        DeclarationModifiers.Const,
                        _generator.LiteralExpression(info.value));
                });
        }

        private IEnumerable<SyntaxNode> GetAddPartMethods(OpenXmlType type)
        {
            IEnumerable<SyntaxNode> CreatePartMethods(OpenXmlElement p)
            {
                if (p.Type.IsDataPartReference)
                {
                    yield return GenerateAddPartMethod(type, p, AddPartParameter.MediaDataPart, false);
                    yield return GenerateAddPartMethod(type, p, AddPartParameter.MediaDataPart, true);
                }
                else if (p.Type.IsSpecialEmbeddedPart)
                {
                    yield return GenerateAddPartMethod(type, p, AddPartParameter.ContentType, false);
                }
                else
                {
                    yield return GenerateAddPartMethod(type, p, AddPartParameter.ContentType, false);
                    yield return GenerateAddPartMethod(type, p, AddPartParameter.ContentType, true);
                    yield return GenerateAddPartMethod(type, p, AddPartParameter.PartType, true);
                    yield return GenerateAddPartMethod(type, p, AddPartParameter.PartType, false);
                }
            }

            return type.GetSubElements()
                .Where(p => !p.Type.HasFixedContent)
                .SelectMany(CreatePartMethods);
        }

        public enum AddPartParameter
        {
            ContentType,
            PartType,
            MediaDataPart
        }

        public MethodDeclarationSyntax GenerateAddPartMethod(OpenXmlType type, OpenXmlElement p, AddPartParameter partParameter, bool hasId)
        {
            const string ContentTypeParameterName = "contentType";
            const string MediaPartParameterName = "mediaDataPart";
            const string PartTypeParameterName = "partType";
            const string IdParameterName = "id";
            const string ChildPartLocalVariable = "childPart";
            const string PartExtensionLocalVariable = "partExtension";

            var initExpression = new StringBuilder();
            var parameters = new List<SyntaxNode>();
            var parameterComments = new List<(string, string)>();

            initExpression.Append($"InitPart({ChildPartLocalVariable}, ");

            if (partParameter == AddPartParameter.ContentType)
            {
                initExpression.Append(ContentTypeParameterName);
                parameters.Add(_generator.ParameterDeclaration(ContentTypeParameterName, _types.SystemString));
                parameterComments.Add((ContentTypeParameterName, $"The content type of the {p.Type.Name}"));
            }

            if (partParameter == AddPartParameter.MediaDataPart)
            {
                initExpression.Append(MediaPartParameterName);
                parameterComments.Add((MediaPartParameterName, $"The part type of the {p.Type.Name}"));
                parameters.Add(_generator.ParameterDeclaration(MediaPartParameterName, ParseTypeName("MediaDataPart")));
            }

            if (partParameter == AddPartParameter.PartType)
            {
                parameters.Add(_generator.ParameterDeclaration(PartTypeParameterName, ParseTypeName($"{p.Type.Name}Type")));
                parameterComments.Add((PartTypeParameterName, $"The part type of the {p.Type.Name}"));
            }

            if (hasId)
            {
                initExpression.Append($", {IdParameterName}");
                parameters.Add(_generator.ParameterDeclaration(IdParameterName, _types.SystemString));
                parameterComments.Add((IdParameterName, "The relationship id"));
            }

            initExpression.Append(")");

            SyntaxNode[] statements = null;

            string TryAddId(string param) => hasId ? $"{param}, {IdParameterName}" : param;

            switch (partParameter)
            {
                case AddPartParameter.ContentType:
                    statements = new[]
                    {
                        _generator.LocalDeclarationStatement(ChildPartLocalVariable, _generator.ObjectCreationExpression(ParseTypeName(p.Type.Name))),
                        ParseExpression(initExpression.ToString()),
                        ReturnStatement(ParseName(ChildPartLocalVariable))
                    };
                    break;
                case AddPartParameter.PartType:
                    statements = new[]
                    {
                        _generator.LocalDeclarationStatement(ContentTypeParameterName, ParseExpression($"{p.Type.Name}TypeInfo.GetContentType({PartTypeParameterName})")),
                        _generator.LocalDeclarationStatement(PartExtensionLocalVariable, ParseExpression($"{p.Type.Name}TypeInfo.GetTargetExtension({PartTypeParameterName})")),
                        ParseExpression($"OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist({ContentTypeParameterName}, {PartExtensionLocalVariable})"),
                        ReturnStatement(ParseExpression($"Add{p.Type.Name}({TryAddId(ContentTypeParameterName)})"))
                    };
                    break;
                case AddPartParameter.MediaDataPart:
                    statements = new[]
                    {
                        ParseExpression($"return AddDataPartReferenceRelationship<{p.Type.Name}>({TryAddId(MediaPartParameterName)})")
                    };
                    break;
            }

            return (MethodDeclarationSyntax)_generator.MethodDeclaration(
                $"Add{p.Type.Name}",
                parameters: parameters,
                returnType: ParseTypeName(p.Type.Name),
                accessibility: Accessibility.Public,
                statements: statements)
                .AddDocumentationComment(new DocumentCommentOptions
                {
                    Summary = $"Adds a {p.Type.Name} to the {type.Name}",
                    Parameters = parameterComments,
                    Return = "The newly added part"
                });
        }

        private static string GetConstantName(string name) => $"{name}Constant";
    }
}
