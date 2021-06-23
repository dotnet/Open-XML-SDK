// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Provides Open XML schema-related extension methods.
    /// </summary>
    public static class SchemaExtensions
    {
        #region Methods Referencing Obsolete Code

#pragma warning disable CS0618 // Type or member is obsolete

        /*
         * TODO: Replace SchemaAttrAttribute with new mechanism as soon as it is available.
         */

        /// <summary>
        /// Determines whether the given <see cref="Type" /> has associated schema information.
        /// </summary>
        /// <param name="type">The <see cref="Type" /></param>
        /// <returns><see langword="true"/>, if the <see cref="Type" /> does have schema information; <see langword="false"/>, otherwise.</returns>
        public static bool HasSchemaInfo(this Type type)
        {
            return type.GetCustomAttribute<SchemaAttrAttribute>() != null;
        }

        /// <summary>
        /// Gets the given <see cref="Type" />'s schema-defined <see cref="XName" />.
        /// </summary>
        /// <param name="openXmlPartRootElementType">The <see cref="Type" />.</param>
        /// <returns>The <see cref="XName" />.</returns>
        public static XName GetXName(this Type openXmlPartRootElementType)
        {
            var attribute = openXmlPartRootElementType.GetCustomAttribute<SchemaAttrAttribute>();

            return attribute != null
                ? XName.Get(attribute.Tag, attribute.NamespaceUri)
                : throw new ArgumentException($"Invalid type: '{openXmlPartRootElementType.FullName}'.");
        }

#pragma warning restore CS0618 // Type or member is obsolete

        #endregion
    }
}
