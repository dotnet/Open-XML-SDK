// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Models;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.Generators.Elements;

internal static class ValidatorWriterExtensions
{
    public static void WriteValidator(this IndentedTextWriter writer, Validator validator)
    {
        if (!validator.Version.HasValue && !validator.Arguments.Any())
        {
            writer.Write(validator.Name);
            writer.Write(".Instance");
        }
        else
        {
            writer.Write("new ");
            writer.Write(validator.Name);
            writer.Write("(");

            var hasInitialization = false;

            foreach (var arg in validator.Arguments)
            {
                if (arg.Name is null)
                {
                    writer.WriteArgument(arg);
                }
                else
                {
                    hasInitialization = true;
                }
            }

            writer.Write(")");

            if (hasInitialization || validator.Version.HasValue)
            {
                writer.Write(" { ");

                var written = false;

                foreach (var arg in validator.Arguments)
                {
                    if (arg.Name is not null)
                    {
                        if (written)
                        {
                            writer.Write(", ");
                        }

                        writer.Write(arg.Name);
                        writer.Write(" = ");
                        writer.Write("(");
                        writer.WriteArgument(arg);
                        writer.Write(")");
                        written = true;
                    }
                }

                if (validator.Version.HasValue)
                {
                    if (written)
                    {
                        writer.Write(", ");
                    }

                    writer.Write(validator.IsInitialVersion ? "InitialVersion" : "Version");
                    writer.Write(" = (FileFormatVersions.");
                    writer.Write(validator.Version.Value);
                    writer.Write(")");
                }

                writer.Write(" }");
            }
        }
    }

    private static void WriteArgument(this IndentedTextWriter writer, Argument arg)
    {
        if (arg.Type == ArgumentType.Type)
        {
            writer.WriteItem(new TypeOf(arg.Value));
        }
        else if (arg.Type == ArgumentType.Version)
        {
            writer.Write("FileFormatVersions.");
            writer.Write(arg.Value);
        }
        else if (arg.Type == ArgumentType.Integer)
        {
            writer.Write(arg.Value);
        }
        else if (arg.Type == ArgumentType.Long)
        {
            writer.Write(arg.Value);
            writer.Write("L");
        }
        else if (arg.Type == ArgumentType.Double)
        {
            writer.Write(arg.Value);
            writer.Write("D");
        }
        else if (arg.Type == ArgumentType.Boolean)
        {
            writer.Write(arg.Value.ToLowerInvariant());
        }
        else if (arg.Type == ArgumentType.String)
        {
            writer.Write("\"");
            writer.Write(arg.Value.Replace("\\", "\\\\"));
            writer.Write("\"");
        }
        else
        {
            writer.Write(arg.Value);
        }
    }
}
