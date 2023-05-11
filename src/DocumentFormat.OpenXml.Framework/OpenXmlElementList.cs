// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml;

/// <summary>
/// A struct that helps enumerate the child elements of an <see cref="OpenXmlElement"/>
/// </summary>
public readonly record struct OpenXmlElementList :
#if NET46 || NETCOREAPP || NETSTANDARD
    IReadOnlyList<OpenXmlElement>,
#endif
    IEnumerable<OpenXmlElement>
{
    private readonly OpenXmlElement _container;

    /// <summary>
    /// Creates an instance of <see cref="OpenXmlElementList"/>.
    /// </summary>
    /// <param name="container"></param>
    public OpenXmlElementList(OpenXmlElement container)
    {
        _container = container;
    }

    /// <summary>
    /// Gets a node at the specified index.
    /// </summary>
    /// <param name="index">Index to retrieve the element.</param>
    /// <returns>The element if found.</returns>
    public OpenXmlElement this[int index]
    {
        get
        {
            foreach (var item in this)
            {
                if (index == 0)
                {
                    return item;
                }

                index--;
            }

            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    /// <summary>
    /// Gets the number of children the element has.
    /// </summary>
    public int Count
    {
        get
        {
            int num = 0;
            if (_container.HasChildren)
            {
                for (var element = _container.FirstChild; element is not null; element = element.NextSibling())
                {
                    num++;
                }
            }

            return num;
        }
    }

    /// <summary>
    /// Gets an <see cref="Enumerator"/> for the collection.
    /// </summary>
    /// <returns>The enumerator.</returns>
    public Enumerator GetEnumerator() => new(_container);

    /// <summary>
    /// Gets the first item of type <typeparamref name="T"/> in the children.
    /// </summary>
    /// <typeparam name="T">Type to search for.</typeparam>
    /// <returns>First instance if found.</returns>
    public T? First<T>()
        where T : OpenXmlElement
    {
        foreach (var item in this)
        {
            if (item is T t)
            {
                return t;
            }
        }

        return default;
    }

    IEnumerator<OpenXmlElement> IEnumerable<OpenXmlElement>.GetEnumerator() => GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>
    /// An enumerator used for <see cref="OpenXmlElementList"/>.
    /// </summary>
    public struct Enumerator : IEnumerator<OpenXmlElement>
    {
        private OpenXmlElement? _element;

        internal Enumerator(OpenXmlElement element)
        {
            _element = element.FirstChild;
        }

        /// <summary>
        /// Gets the current <see cref="OpenXmlElement"/> for the enumerator.
        /// </summary>
        public OpenXmlElement Current => _element!;

        object IEnumerator.Current => Current;

        /// <summary>
        /// Moves the enumerator forward.
        /// </summary>
        /// <returns><c>true</c> if it was moved, <c>false</c> otherwise.</returns>
        public bool MoveNext()
        {
            if (_element is null)
            {
                return false;
            }

            _element = _element.NextSibling();
            return true;
        }

        void IDisposable.Dispose()
        {
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
