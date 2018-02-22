// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the custom attribute for fields in a generated enum.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class EnumStringAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the EnumStringAttribute class using
        /// the supplied text string.
        /// </summary>
        /// <param name="value">The text string.</param>
        public EnumStringAttribute(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets the text string in the custom attribute.
        /// </summary>
        public string Value { get; }
    }
}
