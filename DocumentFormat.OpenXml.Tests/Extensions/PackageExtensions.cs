// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static class PackageExtensions
    {
        /// <summary>
        /// Get Main Part of current package
        /// </summary>
        /// <param name="package">current package</param>
        /// <returns>Return main part of current package, null if not exist.</returns>
        public static OpenXmlPart MainPart(this OpenXmlPackage package)
        {
            if (null == package)
            {
                throw new ArgumentNullException(nameof(package));
            }

            if (package is WordprocessingDocument word)
            {
                return word.MainDocumentPart;
            }
            else if (package is SpreadsheetDocument spreadsheet)
            {
                return spreadsheet.WorkbookPart;
            }
            else if (package is PresentationDocument presentation)
            {
                return presentation.PresentationPart;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Non-Main Part of current package
        /// </summary>
        /// <param name="package">current package</param>
        /// <returns>Return non-main part of current package, null if not exist.</returns>
        public static IEnumerable<OpenXmlPart> NonMainParts(this OpenXmlPackage package)
        {
            return package.DescendantParts()
                .Where(p => p.IsReflectable() && !p.IsMainPart());
        }

        /// <summary>
        /// Gets all parts contained in the <see cref="OpenXmlPackage" /> in a
        /// breadth-first fashion, i.e., the direct and indirect relationship
        /// targets of the package (where the <see cref="OpenXmlPartContainer.Parts" />
        /// property only returns the direct relationship targets).
        /// </summary>
        public static IEnumerable<OpenXmlPart> GetAllParts(this OpenXmlPackage package)
        {
            return new OpenXmlParts(package);
        }

        /// <summary>
        /// Enumeration of all parts contained in an <see cref="OpenXmlPackage" />
        /// rather than just the direct relationship targets.
        /// </summary>
        private class OpenXmlParts : IEnumerable<OpenXmlPart>
        {
            private readonly OpenXmlPackage _package;

            /// <summary>
            /// Initializes a new instance of the OpenXmlPackagePartIterator class using the supplied OpenXmlPackage class.
            /// </summary>
            /// <param name="package">The OpenXmlPackage to use to enumerate parts</param>
            public OpenXmlParts(OpenXmlPackage package)
            {
                _package = package;
            }

            /// <summary>
            /// Gets an enumerator for parts in the whole package.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<OpenXmlPart> GetEnumerator()
            {
                var parts = new List<OpenXmlPart>();
                var queue = new Queue<OpenXmlPart>();

                // Enqueue all direct relationship targets.
                foreach (var target in _package.Parts)
                {
                    queue.Enqueue(target.OpenXmlPart);
                }

                while (queue.Count > 0)
                {
                    // Add next part from queue to the set of parts to be returned.
                    var part = queue.Dequeue();
                    parts.Add(part);

                    // Enqueue all direct relationship targets of current part that
                    // are not already enqueued or in the set of parts to be returned.
                    foreach (var indirectTarget in part.Parts)
                    {
                        if (!queue.Contains(indirectTarget.OpenXmlPart) &&
                            !parts.Contains(indirectTarget.OpenXmlPart))
                        {
                            queue.Enqueue(indirectTarget.OpenXmlPart);
                        }
                    }
                }

                // Done.
                return parts.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
