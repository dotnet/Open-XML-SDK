// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Holds all simple type constraints in array.
    /// </summary>
    [DataContract(Name = "root")]
    [KnownType(typeof(AnyUriRestriction))]
    [KnownType(typeof(Base64BinaryRestriction))]
    [KnownType(typeof(BooleanValueRestriction))]
    [KnownType(typeof(ByteValueRestriction))]
    [KnownType(typeof(DateTimeValueRestriction))]
    [KnownType(typeof(DateValueRestriction))]
    [KnownType(typeof(DecimalValueRestriction))]
    [KnownType(typeof(DoubleValueRestriction))]
    [KnownType(typeof(EnumValueRestriction))]
    [KnownType(typeof(IdStringRestriction))]
    [KnownType(typeof(Int16ValueRestriction))]
    [KnownType(typeof(Int32ValueRestriction))]
    [KnownType(typeof(Int64ValueRestriction))]
    [KnownType(typeof(IntegerValueRestriction))]
    [KnownType(typeof(HexBinaryRestriction))]
    [KnownType(typeof(LanguageRestriction))]
    [KnownType(typeof(ListValueRestriction))]
    [KnownType(typeof(NcNameRestriction))]
    [KnownType(typeof(NonNegativeIntegerValueRestriction))]
    [KnownType(typeof(PositiveIntegerValueRestriction))]
    [KnownType(typeof(QnameRestriction))]
    [KnownType(typeof(RedirectedRestriction))]
    [KnownType(typeof(SByteValueRestriction))]
    [KnownType(typeof(SingleValueRestriction))]
    [KnownType(typeof(StringRestriction))]
    [KnownType(typeof(SimpleTypeRestrictions))]
    [KnownType(typeof(TokenRestriction))]
    [KnownType(typeof(UInt16ValueRestriction))]
    [KnownType(typeof(UInt32ValueRestriction))]
    [KnownType(typeof(UInt64ValueRestriction))]
    [KnownType(typeof(UnionValueRestriction))]
    internal class SimpleTypeRestrictions
    {
        [DataMember(Name = "types")]
        public SimpleTypeRestriction[] SimpleTypes { get; set; }

        private static DataContractSerializer GetSerializer()
        {
#if FEATURE_DCS_SETTINGS
            var settings = new DataContractSerializerSettings
            {
                PreserveObjectReferences = true,
            };

            return new DataContractSerializer(typeof(SimpleTypeRestrictions), settings);
#else
            return new DataContractSerializer(
                typeof(SimpleTypeRestrictions),
                null,
                int.MaxValue,
                false,
                true,
                null);
#endif
        }

#if  FEATURE_SCHEMA_GENERATOR
        /// <summary>
        /// Serializes the current <see cref="SimpleTypeRestrictions"/> into an XML stream
        /// </summary>
        /// <remarks>
        /// The serialization may produce different outputs on different platforms. All platforms
        /// will deserialize with <see cref="Deserialize(Stream, FileFormatVersions)"/> into the
        /// data structure.
        /// </remarks>
        /// <param name="stream">Stream to serialize the XML</param>
        public void Serialize(Stream stream)
        {
            var settings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8,
                IndentChars = "\t",
            };

            using (var xml = XmlWriter.Create(stream, settings))
            {
                GetSerializer().WriteObject(xml, this);
            }
        }
#endif

        /// <summary>
        /// Deserialize the XML stream into <see cref="SimpleTypeRestrictions"/>
        /// </summary>
        /// <param name="stream">The XML stream</param>
        /// <param name="fileFormat">The target file format version</param>
        /// <returns></returns>
        public static SimpleTypeRestrictions Deserialize(Stream stream, FileFormatVersions fileFormat)
        {
            using (var xml = XmlReader.Create(stream))
            {
                var simpleTypeRestrictions = (SimpleTypeRestrictions)GetSerializer().ReadObject(xml);

                foreach (var simpleType in simpleTypeRestrictions.SimpleTypes)
                {
                    simpleType.FileFormat = fileFormat;
                }

                return simpleTypeRestrictions;
            }
        }

        /// <summary>
        /// Indexer to retrieve data in the SimpleTypes.
        /// </summary>
        /// <param name="index">The index of the data in the SimpleTypes array.</param>
        /// <returns>The simple type constraint data.</returns>
        public SimpleTypeRestriction this[int index] => SimpleTypes[index];
    }
}
