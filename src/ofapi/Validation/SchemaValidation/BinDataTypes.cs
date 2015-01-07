// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /**********************************************************
     * Define data struct for schema constraint binary database
     **********************************************************/

    using SdbIndex = UInt16;

    /// <summary>
    /// Particle type.
    /// </summary>
    internal enum ParticleType : byte
    {
        Element = 0,
        All, // xsd:any which use predefined value: ##any, ##other, ##local, ##targetNamespace.
        Any,
        Choice,
        Group,
        Sequence,
        AnyWithUri, // xsd:any which has specified namespace
        Invalid = byte.MaxValue,
    }

    /// <summary>
    /// xsd:use type.
    /// </summary>
    /// <remarks>
    /// Same as XmlSchemaUse.
    /// </remarks>
    internal enum XsdAttributeUse : byte
    {
        None = 0,
        Optional,
        Prohibited,
        Required,
    }

    internal static class XsdAnyPrefidefinedValue
    {
        /// <summary>
        /// ##any - Elements from any namespace can be present.
        /// </summary>
        public const SdbIndex Any = 0;

        /// <summary>
        /// ##other - Elements from any namespace that is not the target namespace of the parent element containing this element can be present.
        /// </summary>
        public const SdbIndex Other = 1;

        /// <summary>
        /// #local - Elements that are not qualified with a namespace can be present.
        /// </summary>
        public const SdbIndex Local = 2;

        /// <summary>
        /// ##targetNamespace - Elements from the target namespace of the parent element containing this element can be present.
        /// </summary>
        public const SdbIndex TargetNamespace = 3;

        /// <summary>
        /// Get corresponding namespace string for Any, Other, Local and TargetNamespace.
        /// </summary>
        /// <param name="value">One of the Any, Other, Local and TargetNamespace.</param>
        /// <returns>##any, ##other, ##local or ##targetNamespace.</returns>
        internal static string GetNamespaceString(SdbIndex value)
        {
            switch (value)
            {
                case XsdAnyPrefidefinedValue.Any:
                    // Elements from any namespace can be present.
                    return "##any";

                case XsdAnyPrefidefinedValue.Local:
                    // Elements that are not qualified with a namespace can be present.
                    return "##local";

                case XsdAnyPrefidefinedValue.Other:
                    // Elements from any namespace that is not the target namespace of the parent element containing this element can be present.
                    return "##other";

                case XsdAnyPrefidefinedValue.TargetNamespace:
                    return "##targetNamespace";

                default:
                    Debug.Assert(false);
                    return string.Empty;
            }
        }

    }

    /// <summary>
    /// Base class for fixed size data.
    /// </summary>
    internal abstract class SdbData
    {
        public const SdbIndex InvalidId = SdbIndex.MaxValue;
        public const int MaxSdbIndex = SdbIndex.MaxValue;

        #region abstract methods

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public abstract int DataSize { get; }
        
        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public abstract byte[] GetBytes();

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public abstract void LoadFromBytes(byte[] value, int startIndex);

        #endregion

        /// <summary>
        /// Helper function to be called by derived classes.
        /// </summary>
        /// <param name="fieldvalues"></param>
        /// <returns></returns>
        protected byte[] GetBytes(params byte[][] fieldvalues)
        {
            byte[] value = new byte[this.DataSize];
            int index = 0;

            foreach (var fieldvalue in fieldvalues)
            {
                fieldvalue.CopyTo(value, index);
                index += fieldvalue.Length;
            }

            return value;
        }

        #region Deserialize helper functions
        // deserialize helper functions

        public static int LoadInt(byte[] bytes, ref int startIndex)
        {
            int result = BitConverter.ToInt32(bytes, startIndex);
            startIndex += sizeof(int);
            return result;
        }

        public static SdbIndex LoadSdbIndex(byte[] bytes, ref int startIndex)
        {
            SdbIndex result = BitConverter.ToUInt16(bytes, startIndex);
            startIndex += sizeof(SdbIndex);
            return result;
        }

        public static ushort LoadUInt16(byte[] bytes, ref int startIndex)
        {
            ushort result = BitConverter.ToUInt16(bytes, startIndex);
            startIndex += sizeof(ushort);
            return result;
        }


        public static byte LoadByte(byte[] bytes, ref int startIndex)
        {
            startIndex++;
            return bytes[startIndex - 1];
        }

        #endregion
    }

    /// <summary>
    /// Map OpenXmlElement class ID to schema type in schema.
    /// </summary>
    [DebuggerDisplay("ClassId={ClassId}")]
    internal class SdbClassIdToSchemaTypeIndex : SdbData
    {
        /// <summary>
        /// Start ID of class ID.
        /// </summary>
        public const SdbIndex StartClassId = 10001;

        public const SdbIndex InvalidSchemaTypeIndex = SdbIndex.MaxValue;

        /// <summary>
        /// Class ID - Element Type ID.
        /// </summary>
        public SdbIndex ClassId { get; set; }

        /// <summary>
        /// The index of the schema type in the SdbSchemaType data array.
        /// </summary>
        public SdbIndex SchemaTypeIndex { get; set; }

        /// <summary>
        /// Initializes a new instance of the SdbClassIdToSchemaTypeIndex.
        /// </summary>
        public SdbClassIdToSchemaTypeIndex()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdbClassIdToSchemaTypeIndex.
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="schemaTypeIndex"></param>
        public SdbClassIdToSchemaTypeIndex(SdbIndex classId, SdbIndex schemaTypeIndex)
        {
            this.ClassId = classId;
            this.SchemaTypeIndex = schemaTypeIndex;
        }

        /// <summary>
        /// Return the index of the data in the data array. The data array is sorted by the class ID and the class ID is continuous.
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public static SdbIndex ArrayIndexFromClassId(SdbIndex classId)
        {
            Debug.Assert(classId >= StartClassId);
            return (SdbIndex)(classId - StartClassId);
        }

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public static int TypeSize
        {
            get
            {
                return sizeof(SdbIndex) * 2;
            }
        }

        #region Override SdbData Members

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public override int DataSize
        {
            get { return TypeSize; }
        }

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            return this.GetBytes(this.ClassId.Bytes(), 
                                 this.SchemaTypeIndex.Bytes());
        }

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            this.ClassId = LoadSdbIndex(value, ref startIndex);
            this.SchemaTypeIndex = LoadSdbIndex(value, ref startIndex);
        }

        #endregion
    }

    /// <summary>
    /// Schema type data.
    /// </summary>
    internal class SdbSchemaType : SdbData
    {
        // TODO: the ParticleIndex and SimpleTypeIndex can share one field.

        /// <summary>
        /// The index of the particle in the SdbParticleConstraint data array. 
        /// Will be "SdbData.InvalidId" if the schema type is NOT composite type.
        /// </summary>
        /// <remarks>This field can be eliminated.</remarks>
        public SdbIndex ParticleIndex { get; set; }

        /// <summary>
        /// The index of the simple data in the SdbSimpleTypeRestriction data array. 
        /// Will be "SdbData.InvalidId" if the schema type is NOT simple content only.
        /// </summary>
        public SdbIndex SimpleTypeIndex { get; set; }

        /// <summary>
        /// The count of attributes.
        /// </summary>
        public SdbIndex AttributesCount { get; set; }

        /// <summary>
        /// The index of the first attribute data in the SdbAttributeConstraint data array.
        /// </summary>
        public SdbIndex StartIndexOfAttributes { get; set; }

        /// <summary>
        /// Initializes a new instance of the SdbSchemaType.
        /// </summary>
        public SdbSchemaType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdbSchemaType.
        /// </summary>
        /// <param name="particleIndex"></param>
        /// <param name="simpleTypeIndex"></param>
        /// <param name="attributeCount"></param>
        /// <param name="startAttribute"></param>
        public SdbSchemaType(SdbIndex particleIndex, SdbIndex simpleTypeIndex, SdbIndex attributeCount, SdbIndex startAttribute)
        {
            this.ParticleIndex = particleIndex;
            this.SimpleTypeIndex = simpleTypeIndex;
            this.AttributesCount = attributeCount;
            this.StartIndexOfAttributes = startAttribute;
        }

        /// <summary>
        /// Returns true if the schema type is a schema type which contains particles.
        /// </summary>
        public bool IsCompositeType
        {
            get { return this.ParticleIndex != SdbData.InvalidId; }
        }

        /// <summary>
        /// Returns true if the schema type contains simple content only.
        /// </summary>
        public bool IsSimpleContent
        {
            get { return this.SimpleTypeIndex != SdbData.InvalidId; }
        }

        /// <summary>
        /// The size in bytes of this data structure
        /// </summary>
        public static int TypeSize
        {
            get { return sizeof(SdbIndex) * 4; }
        }

        #region Override SdbData Members

        /// <summary>
        /// The size in bytes of this data structure
        /// </summary>
        public override int DataSize
        {
            get { return TypeSize; }
        }

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            return this.GetBytes(this.ParticleIndex.Bytes(),
                                this.SimpleTypeIndex.Bytes(),
                                this.AttributesCount.Bytes(),
                                this.StartIndexOfAttributes.Bytes());
        }

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            this.ParticleIndex = LoadSdbIndex(value, ref startIndex);
            this.SimpleTypeIndex = LoadSdbIndex(value, ref startIndex);
            this.AttributesCount = LoadSdbIndex(value, ref startIndex);
            this.StartIndexOfAttributes = LoadSdbIndex(value, ref startIndex);
        }

        #endregion
    }

    /// <summary>
    /// Particle constraint data.
    /// </summary>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal class SdbParticleConstraint : SdbData
    {
        /// <summary>
        /// Represent maxOccurs="unbounded" by "0".
        /// </summary>
        public const ushort UnboundedMaxOccurs = 0;

        /// <summary>
        /// The particle type of this particle.
        /// </summary>
        public ParticleType ParticleType { get; set; }

        /// <summary>
        /// When this is an element, save the element type ID (class ID).
        /// </summary>
        public SdbIndex ElementTypeId { get; set; }

        /// <summary>
        /// The xsd:minOccurs value of this particle.
        /// Just use ushort at now. throw exceptions if thera are numbers > ushort.MaxValue.
        /// </summary>
        public ushort MinOccurs { get; set; }

        /// <summary>
        /// The xsd:maxOccurs value of this particle.
        /// ushort is not enough.
        /// </summary>
        public int MaxOccurs { get; set; }

        /// <summary>
        /// Count of children particles.
        /// </summary>
        public SdbIndex ChildrenCount { get; set; }

        /// <summary>
        /// The index of the first child particle index in the SdbParticleChildrenIndex data array.
        /// </summary>
        public SdbIndex ChildrenStartIndex { get; set; }

        /// <summary>
        /// Returns the namespace ID defiend in "xsd:any" when the particle type is ParticleType.Any or ParticleType.AnyWithUri
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]        
        public SdbIndex XsdAnyNamespaceId
        {
            get
            {
                // Valid only when the particle is "xsd:any".
                Debug.Assert(this.ParticleType == ParticleType.Any || this.ParticleType == ParticleType.AnyWithUri);

                // The ID data saved in the .ElementTypeId field.
                return this.ElementTypeId;
            }
        }

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public static int TypeSize
        {
            get
            {
                return sizeof(ParticleType) +
                        sizeof(SdbIndex) +
                        sizeof(ushort) +
                        sizeof(int) +
                        sizeof(SdbIndex) +
                        sizeof(SdbIndex);
            }
        }
        
        #region Override SdbData Members

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public override int DataSize
        {
            get { return TypeSize; }
        }

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            return this.GetBytes(this.ParticleType.Bytes(),
                this.ElementTypeId.Bytes(),
                this.MinOccurs.Bytes(),
                this.MaxOccurs.Bytes(),
                this.ChildrenCount.Bytes(),
                this.ChildrenStartIndex.Bytes());
        }

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            this.ParticleType = (ParticleType)LoadByte(value, ref startIndex);
            this.ElementTypeId = LoadSdbIndex(value, ref startIndex);
            this.MinOccurs = LoadUInt16(value, ref startIndex);
            this.MaxOccurs = LoadInt(value, ref startIndex);
            this.ChildrenCount = LoadSdbIndex(value, ref startIndex);
            this.ChildrenStartIndex = LoadSdbIndex(value, ref startIndex);
        }

        #endregion
    }

    /// <summary>
    /// Particle children index data.
    /// </summary>
    [DebuggerDisplay("ParticleIndex={ParticleIndex}")]
    internal class SdbParticleChildrenIndex : SdbData
    {
        /// <summary>
        /// The index of the particle in the SdbParticleConstraint data array.
        /// </summary>
        public SdbIndex ParticleIndex { get; set; }

        public SdbParticleChildrenIndex()
        {
            this.ParticleIndex = SdbData.InvalidId;
        }

        public SdbParticleChildrenIndex(SdbIndex index)
        {
            this.ParticleIndex = index;
        }

        public SdbParticleChildrenIndex(int index)
        {
            if (index >= SdbData.MaxSdbIndex)
            {
                throw new ArgumentOutOfRangeException("index");
            }
             
            this.ParticleIndex = (SdbIndex)index;
        }

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public static int TypeSize
        {
            get { return sizeof(SdbIndex); }
        }

        #region Override SdbData Members
        
        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public override int DataSize
        {
            get { return TypeSize; }
        }

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            return this.ParticleIndex.Bytes();
        }

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            this.ParticleIndex = LoadSdbIndex(value, ref startIndex);
        }

        #endregion
    }

    /// <summary>
    /// Attribute constraint data.
    /// </summary>
    internal class SdbAttributeConstraint : SdbData
    {
        /// <summary>
        /// The xsd:use value.
        /// </summary>
        public XsdAttributeUse AttributeUse { get; set; }

        /// <summary>
        /// The index of the simple data in the SdbSimpleTypeRestriction data array. 
        /// </summary>
        public SdbIndex SimpleTypeIndex { get; set; }

        /// <summary>
        /// In which file format version this attribute is allowed.
        /// </summary>
        public byte FileFormatVersion { get; set; }

        public SdbAttributeConstraint()
        {
        }

        public SdbAttributeConstraint(XsdAttributeUse xsdAttributeUse, SdbIndex simpleTypeIndex, byte fileFormatVersion)
        {
            this.AttributeUse = xsdAttributeUse;
            this.SimpleTypeIndex = simpleTypeIndex;
            this.FileFormatVersion = fileFormatVersion;
        }

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public static int TypeSize
        {
            get
            {
                // We save the enum data in byte
                return sizeof(XsdAttributeUse) + sizeof(SdbIndex) + sizeof(Byte);
            }
        }

        #region Override SdbData Members

        /// <summary>
        /// The size in bytes of this data structure.
        /// </summary>
        public override int DataSize
        {
            get { return TypeSize; }
        }

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            return this.GetBytes(this.AttributeUse.Bytes(),
                                this.SimpleTypeIndex.Bytes(),
                                this.FileFormatVersion.Bytes());
        }

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            this.AttributeUse = (XsdAttributeUse)LoadByte(value, ref startIndex);
            this.SimpleTypeIndex = LoadSdbIndex(value, ref startIndex);
            this.FileFormatVersion = LoadByte(value, ref startIndex);
        }

        #endregion
    }


    /// <summary>
    /// Define some extension methods to make coding clear.
    /// </summary>
    internal static class ValueExtensionMethods
    {
        // serialize methods
        public static byte[] Bytes(this int value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] Bytes(this SdbIndex value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] Bytes(this ParticleType value)
        {
            return new byte[1] { (byte)value };
        }

        public static byte[] Bytes(this XsdAttributeUse value)
        {
            return new byte[1] { (byte)value };
        }

        public static byte[] Bytes(this byte value)
        {
            return new byte[1] { (byte)value };
        }
    }

}
