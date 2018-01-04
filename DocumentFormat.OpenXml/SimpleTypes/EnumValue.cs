// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the enum value for attributes.
    /// </summary>
    /// <typeparam name="T">Every enum value must be an enum with the EnumStringValueAttribute object.</typeparam>
    [DebuggerDisplay("{InnerText}")]
    public class EnumValue<T> : OpenXmlSimpleType
        where T : struct
    {
        private T? _enumValue;

        //********************************************************************************************
        // Performance profile for OpenXmlValidator shows that parsing string into Enum tooks 50% overall time.
        // The reason is that each time we use reflection to get all the strings for the enum.
        // So the performance is bad, especially for enums with many items like BorderValues.
        //
        // Build a look up dictionary on fly if the enum is parsed for more than Threshold times.
        // This look up table will hooked on the type as static data.
        //********************************************************************************************

        // TODO: how do we know what the threashold should be???
        private const int Threshold = 11;
        private static int parseCount;
        private static Dictionary<string, T> stringToValueLookupTable;
        private static Dictionary<T, FileFormatVersions> fileFormatInformations;
        private static bool fileFormatInformationLoaded;
        private static object lockroot = new object();

        /// <summary>
        /// Initializes a new instance of the EnumValue class.
        /// </summary>
        public EnumValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EnumValue class using the supplied
        /// value of type T.
        /// </summary>
        /// <param name="value">
        /// The value of type T.
        /// </param>
        public EnumValue(T value)
            : base()
        {
            // bug O14 #253976
            if (!Enum.IsDefined(typeof(T), value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), ExceptionMessages.InvalidEnumValue);
            }
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the EnumValue by deep copying the supplied
        /// EnumValue class.
        /// </summary>
        /// <param name="source">
        /// The source EnumValue class.
        /// </param>
        public EnumValue(EnumValue<T> source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            this._enumValue = source._enumValue;
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                if (!this._enumValue.HasValue)
                {
                    if (this.TextValue != null)
                    {
                        TryParse();
                    }
                }

                return this._enumValue.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value of the enum.
        /// </summary>
        public T Value
        {
            get
            {
                if (!this._enumValue.HasValue)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        Parse();
                    }
                }
                else
                {
                    Debug.Assert( this.TextValue == null ||
                                  this.TextValue == ToString(this._enumValue.Value));
                }
                return this._enumValue.Value;
            }

            set
            {
                // bug O14 #253976
                if (! Enum.IsDefined(typeof(T), value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), ExceptionMessages.InvalidEnumValue);
                }
                this._enumValue = value;
                this.TextValue = null;
            }
        }

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this._enumValue.HasValue)
                {
                    this.TextValue = ToString(this._enumValue.Value);
                }
                return this.TextValue;
            }

            set
            {
                this.TextValue = value;
                this._enumValue = null;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to an enum.
        /// </summary>
        /// <param name="xmlAttribute">The EnumValue to convert.</param>
        /// <returns>
        /// The converted enum value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator T(EnumValue<T> xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return xmlAttribute.Value;
        }

        /// <summary>
        /// Initializes a new EnumValue class by converting the supplied enum
        /// value.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new EnumValue instance corresponding to the value.</returns>
        public static implicit operator EnumValue<T>(T value)
        {
            return new EnumValue<T>(value);
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted string.</returns>
        public static implicit operator String(EnumValue<T> value)
        {
            if (value == null)
                return null;

            return value.InnerText;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new EnumValue<T>(this);

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this._enumValue = GetEnumValue(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            T value;
            this._enumValue = null;
            if ( TryGetEnumValue(this.TextValue, out value))
            {
                this._enumValue = value;
                return true;
            }
            return false;
        }

        internal static string ToString(T enumVal)
        {
            FieldInfo fi = enumVal.GetType().GetTypeInfo().GetDeclaredField(enumVal.ToString());
            EnumStringAttribute stringAttr = fi.GetCustomAttribute<EnumStringAttribute>();

            if (stringAttr != null)
            {
                return stringAttr.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        internal static bool TryGetEnumValue(string stringVal, out T result)
        {
            if (parseCount > Threshold)
            {
                if (stringToValueLookupTable == null)
                {
                    // build a look up table to improve performance.
                    Dictionary<string, T> lookupTable = new Dictionary<string, T>();

                    Array values = Enum.GetValues(typeof(T));
                    foreach (T enumVal in values)
                    {
                        FieldInfo fi = enumVal.GetType().GetTypeInfo().GetDeclaredField(enumVal.ToString());
                        EnumStringAttribute stringAttr = fi.GetCustomAttribute<EnumStringAttribute>();

                        lookupTable.Add(stringAttr.Value, enumVal);
                    }

                    stringToValueLookupTable = lookupTable;
                }

                Debug.Assert(stringToValueLookupTable != null && stringToValueLookupTable.Count > 0);
                return stringToValueLookupTable.TryGetValue( stringVal,out result);
            }
            else
            {
                parseCount++;

                Array values = Enum.GetValues(typeof(T));

                foreach (T enumVal in values)
                {
                    FieldInfo fi = enumVal.GetType().GetTypeInfo().GetDeclaredField(enumVal.ToString());
                    EnumStringAttribute stringAttr = fi.GetCustomAttribute<EnumStringAttribute>();

                    if (stringAttr != null && stringAttr.Value == stringVal)
                    {
                        result = enumVal;
                        return true;
                    }
                }

                result = new T();
                return false;
            }
        }

        internal static T GetEnumValue(string stringVal)
        {
            T result;

            if (TryGetEnumValue(stringVal, out result))
            {
                return result;
            }

            throw new FormatException(ExceptionMessages.TextIsInvalidEnumValue);
        }

        /// <summary>
        /// Test whether the value is allowed in the specified file format version.
        /// </summary>
        /// <param name="fileFormat">The file format version.</param>
        /// <returns>True if the value is defined in the specified file format version.</returns>
        /// <remarks>
        /// Method to support enum validation in schema validation.
        /// </remarks>
        internal override bool IsInVersion(FileFormatVersions fileFormat)
        {
            Debug.Assert( this.HasValue);

            if (!fileFormatInformationLoaded && fileFormatInformations == null)
            {
                Dictionary<T, FileFormatVersions> lookupTable = null;

                Array values = Enum.GetValues(typeof(T));

                foreach (T enumVal in values)
                {
                    FieldInfo fi = this.Value.GetType().GetTypeInfo().GetDeclaredField(enumVal.ToString());
                    OfficeAvailabilityAttribute versionAttr = fi.GetCustomAttribute<OfficeAvailabilityAttribute>();

                    if (versionAttr != null)
                    {
                        if (lookupTable == null)
                        {
                            lookupTable = new Dictionary<T, FileFormatVersions>();
                        }
                        lookupTable.Add(enumVal, versionAttr.OfficeVersion);
                    }
                }

                lock (lockroot)
                {
                    fileFormatInformations = lookupTable;
                    fileFormatInformationLoaded = true;
                }
            }

            Debug.Assert(fileFormatInformationLoaded);
            if (fileFormatInformations != null)
            {
                FileFormatVersions supportedVersion;

                if (fileFormatInformations.TryGetValue(this.Value, out supportedVersion))
                {
                    return supportedVersion.Includes(fileFormat);
                }
                else
                {
                    // If the OfficeAvailabilityAttribute is not set, then it means the value item exist in both versions.
                    return true;
                }
            }
            else
            {
                // all items are allowed in both Office2007 and Office2010.
                return true;
            }
        }
    }
}
