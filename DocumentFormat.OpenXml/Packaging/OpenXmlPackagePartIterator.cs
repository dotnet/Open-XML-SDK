// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Traversal parts in the <see cref="OpenXmlPackage"/> by breadth-first.
    /// </summary>
    internal class OpenXmlPackagePartIterator : IEnumerable<OpenXmlPart>
    {
        private OpenXmlPackage _package;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the OpenXmlPackagePartIterator class using the supplied OpenXmlPackage class.
        /// </summary>
        /// <param name="package">The OpenXmlPackage to use to enumerate parts.</param>
        public OpenXmlPackagePartIterator(OpenXmlPackage package)
        {
            Debug.Assert(package != null);
            this._package = package;
        }

        #endregion

        #region IEnumerable<OpenXmlPart> Members
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

        #endregion

        #region IEnumerable Members

        /// <summary>
        /// Gets an enumerator for parts in the whole package.
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
