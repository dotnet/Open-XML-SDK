// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;

namespace DocumentFormat.OpenXml.Generator.Generators.Elements;

internal static class SimpleTypeExtensions
{
    private const string StringValue = "StringValue";
    private const string Int32Value = "Int32Value";
    private const string DoubleValue = "DoubleValue";
    private const string Uint32Value = "UInt32Value";
    private const string HexBinaryValue = "HexBinaryValue";
    private const string TrueFalseBlankValue = "TrueFalseBlankValue";
    private const string Base64BinaryValue = "Base64BinaryValue";
    private const string BooleanValue = "BooleanValue";
    private const string DateTimeValue = "DateTimeValue";
    private const string UInt64Value = "UInt64Value";
    private const string IntegerValue = "IntegerValue";
    private const string SByteValue = "SByteValue";
    private const string UInt16Value = "UInt16Value";
    private const string UInt32Value = "UInt32Value";
    private const string DecimalValue = "DecimalValue";
    private const string SingleValue = "SingleValue";
    private const string ByteValue = "ByteValue";
    private const string Int16Value = "Int16Value";
    private const string Int64Value = "Int64Value";

    private static readonly Dictionary<string, string> _mapping = new Dictionary<string, string>()
    {
        { "a:ST_Guid", StringValue },
        { "xsd:string", StringValue },
        { "c:ST_Xstring", StringValue },
        { "cdr:ST_MarkerCoordinate", DoubleValue },
        { "wp:ST_PositionOffset", Int32Value },
        { "xdr:ST_ColID", Int32Value },
        { "a:ST_Coordinate", Int64Value },
        { "a:ST_Percentage", Int32Value },
        { "a:ST_PositivePercentage", Int32Value },
        { "ask:ST_LineSketchSeed", Uint32Value },
        { "b:ST_String255", StringValue },
        { "cppr:ST_PublishDate", StringValue },
        { "cx:CT_Formula", StringValue },
        { "cx:CT_NumericValue", DoubleValue },
        { "cx:CT_StringValue", StringValue },
        { "cx:ST_AxisId", Uint32Value },
        { "emma:CT_Literal", StringValue },
        { "inkml:CT_Annotation", StringValue },
        { "inkml:CT_Matrix", StringValue },
        { "inkml:CT_Table", StringValue },
        { "inkml:CT_Trace", StringValue },
        { "lp:CT_LongProp", StringValue },
        { "m:CT_Text", StringValue },
        { "msink:CT_Property", HexBinaryValue },
        { "o:ST_TrueFalseBlank", TrueFalseBlankValue },
        { "oac:CT_ImgData", Base64BinaryValue },
        { "vt:CT_Cf", Base64BinaryValue },
        { "vt:CT_Vstream", Base64BinaryValue },
        { "vt:ST_Clsid", StringValue },
        { "vt:ST_Cy", StringValue },
        { "vt:ST_Error", StringValue },
        { "w:CT_Base64BinaryText", Base64BinaryValue },
        { "w:CT_Text", StringValue },
        { "x:CT_CellFormula", StringValue },
        { "x:CT_DefinedName", StringValue },
        { "x:CT_TableFormula", StringValue },
        { "x:CT_Xstring", StringValue },
        { "x:ST_Formula", StringValue },
        { "x:ST_Guid", StringValue },
        { "x:ST_Xstring", StringValue },
        { "x14:CT_DefinedNameArgumentDescription", StringValue },
        { "x14:CT_PivotEditValue", StringValue },
        { "xdr:ST_RowID", Int32Value },
        { "xlrd:CT_RichValueFallback", StringValue },
        { "xlrd:CT_Value", StringValue },
        { "xlrd2:CT_ArrayValue", StringValue },
        { "xlrd2:CT_RichStylePropertyValue", StringValue },
        { "xlrd2:CT_SupportingPropertyBagArrayValue", StringValue },
        { "xlrd2:CT_SupportingPropertyBagValue", StringValue },
        { "xne:ST_Sqref", "ListValue<StringValue>" },
        { "xsd:anyURI", StringValue },
        { "xsd:base64Binary", Base64BinaryValue },
        { "xsd:boolean", BooleanValue },
        { "xsd:byte", SByteValue },
        { "xsd:dateTime", DateTimeValue },
        { "xsd:decimal", DecimalValue },
        { "xsd:double", DoubleValue },
        { "xsd:float", SingleValue },
        { "xsd:int", Int32Value },
        { "xsd:integer", IntegerValue },
        { "xsd:long", Int64Value },
        { "xsd:nonNegativeInteger", IntegerValue },
        { "xsd:short", Int16Value },
        { "xsd:unsignedByte", ByteValue },
        { "xsd:unsignedInt", Uint32Value },
        { "xsd:unsignedLong", UInt64Value },
        { "xsd:unsignedShort", UInt16Value },
        { "xvml:ST_Macro", StringValue },
        { "a:ST_Angle", Int32Value },
        { "a:ST_DrawingElementId", UInt32Value },
        { "a:ST_PositiveFixedPercentage", Int32Value },
        { "msink:ST_Point", StringValue },
        { "w:ST_DecimalNumber", Int32Value },
        { "w:ST_HexColorRGB", HexBinaryValue },
        { "w:ST_HpsMeasure_O12", UInt32Value },
        { "w:ST_NonNegativeDecimalNumber", Int32Value },
        { "w:ST_SignedDecimalNumberMax-1", Int32Value },
        { "w:ST_SignedDecimalNumberMax-2", Int32Value },
        { "w:ST_SignedHpsMeasure_O12", Int32Value },
        { "w:ST_SignedTwipsMeasure_O12", Int32Value },
        { "w:ST_StylePaneSortMethods_O12", HexBinaryValue },
        { "w:ST_TwipsMeasure_O12", UInt32Value },
        { "w:ST_UnsignedDecimalNumber", UInt32Value },
        { "w:ST_UnsignedDecimalNumberMin1", Int32Value },
        { "xne:ST_Ref", StringValue },
    };

    public static string GetSimpleType(this OpenXmlGeneratorServices context, QName qname, bool isList)
    {
        var type = context.GetSimpleTypeInternal(qname);

        return isList ? $"ListValue<{type}>" : type;
    }

    private static string GetSimpleTypeInternal(this OpenXmlGeneratorServices services, QName qname)
    {
        if (_mapping.TryGetValue(qname, out var mapped))
        {
            return mapped;
        }

        if (services.TryGetEnum(qname, out var @enum, out var ns))
        {
            return $"EnumValue<{ns}.{@enum.Name}>";
        }

        throw new InvalidOperationException($"Could not find simple type mapping for {qname}");
    }
}
