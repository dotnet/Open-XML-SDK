// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Diagnostics;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Traversal parts in the <see cref="OpenXmlPackage"/> by breadth-first.
    /// </summary>
    internal class OpenXmlPackagePartIterator : IEnumerable<OpenXmlPart>
    {
        private readonly OpenXmlPackage _package;

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackagePartIterator class using the supplied OpenXmlPackage class.
        /// </summary>
        /// <param name="package">The OpenXmlPackage to use to enumerate parts.</param>
        public OpenXmlPackagePartIterator(OpenXmlPackage package)
        {
            Debug.Assert(package != null);
            this._package = package;
        }

        /// <summary>
        /// Gets an enumerator for parts in the whole package.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<OpenXmlPart> GetEnumerator()
        {
            return GetPartsByBreadthFirstTraversal();
        }

        // Traverses the parts graph by breath-first
        private IEnumerator<OpenXmlPart> GetPartsByBreadthFirstTraversal()
        {
            Debug.Assert(_package != null);
            var returnedParts = new List<OpenXmlPart>();
            Queue<OpenXmlPart> tmpQueue = new Queue<OpenXmlPart>();

            // Enqueue child parts of the package.
            foreach (var idPartPair in _package.Parts)
            {
                tmpQueue.Enqueue(idPartPair.OpenXmlPart);
            }

            while (tmpQueue.Count > 0)
            {
                var part = tmpQueue.Dequeue();
                returnedParts.Add(part);

                foreach (var subIdPartPair in part.Parts)
                {
                    if (!tmpQueue.Contains(subIdPartPair.OpenXmlPart)
                        && !returnedParts.Contains(subIdPartPair.OpenXmlPart))
                    {
                        tmpQueue.Enqueue(subIdPartPair.OpenXmlPart);
                    }
                }
            }
            return returnedParts.GetEnumerator();
        }

        /// <summary>
        /// Gets an enumerator for parts in the whole package.
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
