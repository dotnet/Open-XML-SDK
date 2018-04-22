// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the DateTime value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DateTimeValue : OpenXmlComparableSimpleValue<DateTime>
    {
        //the following format string is copied from System.IO.Packaging.PartBasedPackageProperties()
        //We use the XmlConvert.ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption)

        //private static string[] _dateTimeFormats;

        //private string[] DateTimeFormats
        //{
        //    get {
        //        if (_dateTimeFormats == null)
        //        {
        //            // copied from WindowsBase System.IO.Packaging.PartBasedPackageProperties()
        //            _dateTimeFormats = new string[] {
        //                "yyyy-MM-ddTHH:mm:ss", "yyyy-MM-ddTHH:mm:ssZ", "yyyy-MM-ddTHH:mm:sszzz", @"\-yyyy-MM-ddTHH:mm:ss", @"\-yyyy-MM-ddTHH:mm:ssZ", @"\-yyyy-MM-ddTHH:mm:sszzz", "yyyy-MM-ddTHH:mm:ss.ff", "yyyy-MM-ddTHH:mm:ss.fZ", "yyyy-MM-ddTHH:mm:ss.fzzz", @"\-yyyy-MM-ddTHH:mm:ss.f", @"\-yyyy-MM-ddTHH:mm:ss.fZ", @"\-yyyy-MM-ddTHH:mm:ss.fzzz", "yyyy-MM-ddTHH:mm:ss.ff", "yyyy-MM-ddTHH:mm:ss.ffZ", "yyyy-MM-ddTHH:mm:ss.ffzzz", @"\-yyyy-MM-ddTHH:mm:ss.ff",
        //                @"\-yyyy-MM-ddTHH:mm:ss.ffZ", @"\-yyyy-MM-ddTHH:mm:ss.ffzzz", "yyyy-MM-ddTHH:mm:ss.fff", "yyyy-MM-ddTHH:mm:ss.fffZ", "yyyy-MM-ddTHH:mm:ss.fffzzz", @"\-yyyy-MM-ddTHH:mm:ss.fff", @"\-yyyy-MM-ddTHH:mm:ss.fffZ", @"\-yyyy-MM-ddTHH:mm:ss.fffzzz", "yyyy-MM-ddTHH:mm:ss.ffff", "yyyy-MM-ddTHH:mm:ss.ffffZ", "yyyy-MM-ddTHH:mm:ss.ffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.ffff", @"\-yyyy-MM-ddTHH:mm:ss.ffffZ", @"\-yyyy-MM-ddTHH:mm:ss.ffffzzz", "yyyy-MM-ddTHH:mm:ss.fffff", "yyyy-MM-ddTHH:mm:ss.fffffZ",
        //                "yyyy-MM-ddTHH:mm:ss.fffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.fffff", @"\-yyyy-MM-ddTHH:mm:ss.fffffZ", @"\-yyyy-MM-ddTHH:mm:ss.fffffzzz", "yyyy-MM-ddTHH:mm:ss.ffffff", "yyyy-MM-ddTHH:mm:ss.ffffffZ", "yyyy-MM-ddTHH:mm:ss.ffffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.ffffff", @"\-yyyy-MM-ddTHH:mm:ss.ffffffZ", @"\-yyyy-MM-ddTHH:mm:ss.ffffffzzz", "yyyy-MM-ddTHH:mm:ss.fffffff", "yyyy-MM-ddTHH:mm:ss.fffffffZ", "yyyy-MM-ddTHH:mm:ss.fffffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.fffffff", @"\-yyyy-MM-ddTHH:mm:ss.fffffffZ", @"\-yyyy-MM-ddTHH:mm:ss.fffffffzzz"
        //                };
        //        }
        //        return _dateTimeFormats;
        //    }
        //}

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class.
        /// </summary>
        public DateTimeValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class using the supplied
        /// DateTime value.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        public DateTimeValue(DateTime value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class by deep copying the
        /// supplied DateTimeValue class.
        /// </summary>
        /// <param name="source">
        /// The source DateTimeValue class.
        /// </param>
        public DateTimeValue(DateTimeValue source)
            : base(source)
        {
        }

        private protected override string GetText(DateTime input) => XmlConvert.ToString(input, XmlDateTimeSerializationMode.RoundtripKind);

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        private protected override DateTime Parse(string input)
        {
            // in System.IO.Packaging.PartBasedPackageProperties.GetDateData()
            // the code is: System.Xml.XmlConvert.ToDateTime(this.TextValue, this.DateTimeFormats);
            return XmlConvert.ToDateTime(TextValue, XmlDateTimeSerializationMode.Utc);
        }

        /// <summary>
        /// Implicitly converts the specified value to a DateTime value.
        /// </summary>
        /// <param name="xmlAttribute">
        /// The DateTimeValue object to convert.
        /// </param>
        /// <returns>
        /// The converted DateTime value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator DateTime(DateTimeValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToDateTime(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class by implicitly
        /// converting the supplied DateTime value.
        /// </summary>
        /// <param name="value">
        /// The DateTime value.
        /// </param>
        /// <returns>A new DateTimeValue instance with the value.</returns>
        public static implicit operator DateTimeValue(DateTime value)
        {
            return FromDateTime(value);
        }

        /// <summary>
        /// Returns a new DateTimeValue object that was created from a DateTime value.
        /// </summary>
        /// <param name="value">A DateTime value to use to create a new DateTimeValue object.</param>
        /// <returns>A DateTimeValue object that corresponds to the value parameter.</returns>
        public static DateTimeValue FromDateTime(DateTime value)
        {
            return new DateTimeValue(value);
        }

        /// <summary>
        /// Returns the DateTime value representation of a DateTimeValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A DateTimeValue object used to retrieve a DateTime value representation.
        /// </param>
        /// <returns>A DateTime value that represents a DateTimeValue object.</returns>
        public static DateTime ToDateTime(DateTimeValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new DateTimeValue(this);
    }
}
