// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the attribute which is used to decorate a class for type of the possible child elements.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public sealed class ChildElementInfoAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance of ChildElementTypeAttribute.
        /// </summary>
        /// <param name="elementType">Specifies the type of the possible child element.</param>
        public ChildElementInfoAttribute(Type elementType)
            : this(elementType, FileFormatVersions.Office2007)
        {
        }

        /// <summary>
        /// Initialize a new instance of ChildElementTypeAttribute.
        /// </summary>
        /// <param name="elementType">Specifies the type of the possible child element.</param>
        /// <param name="availableInOfficeVersion">Specifies the office version where the child element is first available.</param>
        public ChildElementInfoAttribute(Type elementType, FileFormatVersions availableInOfficeVersion)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            ElementType = elementType;
            AvailableInVersion = availableInOfficeVersion.AndLater();
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// Gets the type of the possible child element.
        /// </summary>
        public Type ElementType { get; }

        /// <summary>
        /// Gets the Office version(s) where the child element is available.
        /// </summary>
        [Obsolete("This property is no longer used and will be removed in a later release")]
        public FileFormatVersions AvailableInVersion { get; }
    }
}
