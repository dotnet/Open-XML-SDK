// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents an ordered collection of OpenXmlElement elements.
    /// </summary>
    public abstract class OpenXmlElementList : IEnumerable<OpenXmlElement>
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlElementList class.
        /// </summary>
        protected OpenXmlElementList()
        {
        }

        internal static OpenXmlElementList Empty { get; } = new EmptyElementList();

        /// <summary>
        /// Gets the OpenXmlElement element at the specified index.
        /// </summary>
        /// <param name="index">
        /// A zero-based integer that represents an index in the list of elements.
        /// </param>
        /// <returns>
        /// An OpenXmlElement element at the specified index in the collection. Returns
        ///  null (Nothing in Visual Basic) if the index is greater than or equal
        ///  to the number of elements in the list.
        /// </returns>
        public abstract OpenXmlElement GetItem(int index);

        /// <summary>
        /// Gets the number of OpenXmlElement elements in the OpenXmlElementList.
        /// </summary>
        public abstract int Count { get; }

        /// <summary>
        /// Gets a node at the specified index.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public virtual OpenXmlElement this[int i]
        {
            get
            {
                return GetItem(i);
            }
        }

        /// <summary>
        /// Finds the first child element of type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T First<T>() where T : OpenXmlElement
        {
            foreach (OpenXmlElement item in this)
            {
                if (item is T element)
                {
                    return element;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets an IEnumerable for a specific type of element.
        /// </summary>
        /// <typeparam name="T">Type of element</typeparam>
        /// <returns></returns>
        public IEnumerable<T> OfType<T>() where T : OpenXmlElement
        {
            foreach (OpenXmlElement item in this)
            {
                if (item is T)
                    yield return (T)item;
            }
        }

        /// <summary>
        /// Gets an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the collection. </returns>
        public abstract IEnumerator<OpenXmlElement> GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

        private sealed class EmptyElementList : OpenXmlElementList
        {
            public override OpenXmlElement GetItem(int index)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            public override int Count => 0;

            public override IEnumerator<OpenXmlElement> GetEnumerator()
            {
                yield break;
            }
        }
    }
}
