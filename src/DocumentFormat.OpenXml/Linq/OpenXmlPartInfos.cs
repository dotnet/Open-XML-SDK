// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Provides information on a collection of concrete subclasses of <see cref="OpenXmlPart" />.
    /// </summary>
    internal class OpenXmlPartInfos : IReadOnlyDictionary<Type, OpenXmlPartInfo>
    {
        private readonly IDictionary<Type, OpenXmlPartInfo> _partInfos;

        /// <summary>
        /// Initializes a new instance, considering all concrete subtypes of
        /// <see cref="OpenXmlPartRootElement" />.
        /// </summary>
        public OpenXmlPartInfos() : this(GetOpenXmlPartRootElementInfos())
        {
        }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="openXmlPartRootElementInfos">
        /// The collection of subtypes of <see cref="OpenXmlPartRootElement" /> for which
        /// <see cref="OpenXmlPart" />-related information should be provided.
        /// </param>
        public OpenXmlPartInfos(IReadOnlyDictionary<Type, ElementLookup.ElementChild> openXmlPartRootElementInfos)
        {
            _partInfos = new Dictionary<Type, OpenXmlPartInfo>();

            // Get all concrete subclasses of OpenXmlPart. This is the superset of the
            // concrete subclasses for which we will be able to uniquely identify the
            // type of the root element, i.e., a subclass of OpenXmlPartRootElement.
            IEnumerable<Type> openXmlPartTypes =
                Assembly
                    .GetExecutingAssembly()
                    .GetExportedTypes()
                    .Where(t => t.IsAssignableTo(typeof(OpenXmlPart)) && !t.IsAbstract);

            foreach (Type openXmlPartType in openXmlPartTypes)
            {
                // Get all public instance properties the type of which is a concrete subtype of
                // OpenXmlPartRootElement and which allow us to get and set the value.
                List<PropertyInfo> properties = openXmlPartType
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.CanRead && p.CanWrite && openXmlPartRootElementInfos.ContainsKey(p.PropertyType))
                    .ToList();

                // If the type has exactly one property of that kind, we have uniquely identified
                // the type of the root element. The MailMergeRecipientDataPart is one example that
                // has two properties and will thus be ignored.
                if (properties.Count != 1)
                {
                    continue;
                }

                PropertyInfo property = properties.Single();

                Type openXmlPartRootElementType = property.PropertyType;
                XName name = GetXName(openXmlPartRootElementType, openXmlPartRootElementInfos);
                string prefix = OpenXmlNamespace.GetNamespacePrefix(name.NamespaceName)!;

                _partInfos[openXmlPartType] =
                    new OpenXmlPartInfo(openXmlPartType, openXmlPartRootElementType, name, prefix);
            }
        }

        private static IReadOnlyDictionary<Type, ElementLookup.ElementChild> GetOpenXmlPartRootElementInfos()
        {
            return ElementLookup.Parts.Elements.Where(e => e.Type != null).ToDictionary(e => e.Type!, e => e);
        }

        private static XName GetXName(
            Type openXmlPartRootElementType,
            IReadOnlyDictionary<Type, ElementLookup.ElementChild> openXmlPartRootElementInfos)
        {
            OpenXmlQualifiedName qname = openXmlPartRootElementInfos[openXmlPartRootElementType].QName;
            return XName.Get(qname.Name, qname.Namespace.Uri);
        }

        /// <inheritdoc />
        public IEnumerator<KeyValuePair<Type, OpenXmlPartInfo>> GetEnumerator()
        {
            return _partInfos.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _partInfos).GetEnumerator();
        }

        /// <inheritdoc />
        public int Count => _partInfos.Count;

        /// <inheritdoc />
        public bool ContainsKey(Type key)
        {
            return _partInfos.ContainsKey(key);
        }

        /// <inheritdoc />
        public bool TryGetValue(Type key, [MaybeNullWhen(false)] out OpenXmlPartInfo value)
        {
            return _partInfos.TryGetValue(key, out value);
        }

        /// <inheritdoc />
        public OpenXmlPartInfo this[Type key] => _partInfos[key];

        /// <inheritdoc />
        public IEnumerable<Type> Keys => _partInfos.Keys;

        /// <inheritdoc />
        public IEnumerable<OpenXmlPartInfo> Values => _partInfos.Values;
    }
}
