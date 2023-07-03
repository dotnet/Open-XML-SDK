using System;

namespace DocumentFormat.OpenXml.Generator;

[AttributeUsage(AttributeTargets.Class)]
internal sealed class OpenXmlPackageAttribute : Attribute
{
    public OpenXmlPackageAttribute(string packageType)
    {
    }
}