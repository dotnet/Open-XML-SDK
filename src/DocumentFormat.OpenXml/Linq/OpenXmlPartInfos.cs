// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
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
    public class OpenXmlPartInfos : IReadOnlyDictionary<Type, OpenXmlPartInfo>
    {
        private readonly IDictionary<Type, OpenXmlPartInfo> _infos;

        /// <summary>
        /// Initializes a new instance, considering all concrete subtypes of
        /// <see cref="OpenXmlPartRootElement" />.
        /// </summary>
        public OpenXmlPartInfos() : this(GetOpenXmlPartRootElementTypes())
        {
        }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="openXmlPartRootElementTypes">
        /// The collection of subtypes of <see cref="OpenXmlPartRootElement" /> for which
        /// <see cref="OpenXmlPart" />-related information should be provided.
        /// </param>
        public OpenXmlPartInfos(IReadOnlyCollection<Type> openXmlPartRootElementTypes)
        {
            _infos = new Dictionary<Type, OpenXmlPartInfo>();

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
                    .Where(p => p.CanRead && p.CanWrite && openXmlPartRootElementTypes.Contains(p.PropertyType))
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
                XName name = openXmlPartRootElementType.GetXName();
                string prefix = OpenXmlNamespace.GetNamespacePrefix(name.NamespaceName)!;

                _infos[openXmlPartType] =
                    new OpenXmlPartInfo(openXmlPartType, openXmlPartRootElementType, name, prefix);
            }
        }

        private static IReadOnlySet<Type> GetOpenXmlPartRootElementTypes()
        {
            return new HashSet<Type>(
                Assembly
                    .GetExecutingAssembly()
                    .GetExportedTypes()
                    .Where(type => type.IsAssignableTo(typeof(OpenXmlPartRootElement)) &&
                                   !type.IsAbstract &&
                                   type.HasSchemaInfo()));
        }

        /// <inheritdoc />
        public IEnumerator<KeyValuePair<Type, OpenXmlPartInfo>> GetEnumerator()
        {
            return _infos.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _infos).GetEnumerator();
        }

        /// <inheritdoc />
        public int Count => _infos.Count;

        /// <inheritdoc />
        public bool ContainsKey(Type key)
        {
            return _infos.ContainsKey(key);
        }

        /// <inheritdoc />
        public bool TryGetValue(Type key, [MaybeNullWhen(false)] out OpenXmlPartInfo value)
        {
            return _infos.TryGetValue(key, out value);
        }

        /// <inheritdoc />
        public OpenXmlPartInfo this[Type key] => _infos[key];

        /// <inheritdoc />
        public IEnumerable<Type> Keys => _infos.Keys;

        /// <inheritdoc />
        public IEnumerable<OpenXmlPartInfo> Values => _infos.Values;
    }
}
