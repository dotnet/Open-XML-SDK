// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace DocumentFormat.OpenXml.Presentation;

/// <summary>
/// Represents an extension element in a PresentationML document.
/// </summary>
/// <typeparam name="T">
/// The type of the extension content. This allows the <c>Extension&lt;T&gt;</c> element to encapsulate any valid Open XML element as its child,
/// enabling support for custom or future extensions within the presentation schema.
/// </typeparam>
/// <remarks>
/// The <c>Extension&lt;T&gt;</c> element is used to store additional information that is not defined in the standard schema,
/// typically for custom features or forward compatibility. The required <c>Uri</c> attribute identifies the type or purpose of the extension.
/// </remarks>
public partial class Extension<T> : OpenXmlCompositeElement
{
#pragma warning disable CS0109
    internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.openxmlformats.org/presentationml/2006/main", "ext");
    internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.openxmlformats.org/presentationml/2006/main", "CT_Extension");
    internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
#pragma warning restore CS0109

    /// <summary>
    /// Initializes a new instance of the Extension class.
    /// </summary>
    public Extension()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the Extension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension(IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }

    /// <summary>
    /// Initializes a new instance of the Extension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension(params OpenXmlElement[] childElements)
        : base(childElements)
    {
    }

    /// <summary>
    /// Initializes a new instance of the Extension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Extension(string outerXml)
        : base(outerXml)
    {
    }

    /// <summary>
    /// <para>Gets or sets uRI</para>
    /// <para>Represents the following attribute in the schema: uri</para>
    /// </summary>
    public StringValue? Uri
    {
        get => GetAttribute<StringValue>();
        set => SetAttribute(value);
    }

    internal override void ConfigureMetadata(ElementMetadata.Builder builder)
    {
        //      [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(
        //System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties |
        //System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.NonPublicProperties)]
        //Type tType = typeof(T);

        List<OpenXmlSchemaType>? val = (List<OpenXmlSchemaType>?)typeof(T).GetProperty("ExtensionChildren", BindingFlags.NonPublic | BindingFlags.Static)?.GetValue(null);

        if (val is not null)
        {
            foreach (var type in val)
            {
                Console.WriteLine($"Adding child type: {type.Name}");
            }
        }

        base.ConfigureMetadata(builder);
        builder.SetSchema(ElementType);
        builder.AddElement<Extension>()
            .AddAttribute("uri", a => a.Uri, aBuilder =>
            {
                aBuilder.AddValidator(RequiredValidator.Instance);
                aBuilder.AddValidator(new StringValidator() { IsToken = true });
            });
        builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(1, 1),
            };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension>(deep);
}
