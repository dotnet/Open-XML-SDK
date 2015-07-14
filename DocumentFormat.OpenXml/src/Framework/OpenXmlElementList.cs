// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents an ordered collection of OpenXmlElement elements.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public abstract class OpenXmlElementList : IEnumerable<OpenXmlElement>
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlElementList class.
        /// </summary>
        protected OpenXmlElementList()
        {
        }

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
                return this.GetItem(i);
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
                if (item is T)
                {
                    return (T)item;
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

        #region IEnumerable<OpenXmlElement> Members

        /// <summary>
        /// Gets an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the collection. </returns>
        public abstract IEnumerator<OpenXmlElement> GetEnumerator();

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }

    /// <summary>
    /// Implements OpenXmlElementList.
    /// </summary>
    internal class OpenXmlChildElements : OpenXmlElementList
    {
        private OpenXmlElement _container;

        public OpenXmlChildElements(OpenXmlElement container)
        {
            this._container = container;
        }
        
        public override IEnumerator<OpenXmlElement> GetEnumerator()
        {
            if (this._container.HasChildren && this._container.FirstChild != null)
            {
                for ( OpenXmlElement element = this._container.FirstChild; 
                      element != null;
                      element = element.NextSibling() )
                {
                    yield return element;
                }
            }
            else
            {
                yield break;
            }
        }

        public override OpenXmlElement GetItem(int index)
        {
            if (this._container.HasChildren)
            {
                for (OpenXmlElement element = this._container.FirstChild;
                          element != null;
                          element = element.NextSibling())
                {
                    if (index == 0)
                    {
                        return element;
                    }
                    index--;
                }
                
            }            
            // return null;
            throw new ArgumentOutOfRangeException("index");
        }

        public override int Count
        {
            get
            {
                int num = 0;
                if (this._container.HasChildren)
                {
                    for (OpenXmlElement element = this._container.FirstChild;
                              element != null;
                              element = element.NextSibling())
                    {
                        num++;
                    }
                }
                return num; 
            }
        }
    }

    internal sealed class EmptyElementList : OpenXmlElementList
    {
        private static readonly EmptyElementList _EmptyElementList = new EmptyElementList();

        private EmptyElementList()
        {
        }

        /// <summary>
        /// Static singleton.
        /// </summary>
        internal static EmptyElementList EmptyElementListSingleton
        {
            get
            {
                return _EmptyElementList;
            }
        }
        
        public override OpenXmlElement GetItem(int index)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        public override int Count
        {
            get { return 0; }
        }

        public override IEnumerator<OpenXmlElement> GetEnumerator()
        {
            return EmptyEnumerator<OpenXmlElement>.EmptyEnumeratorSingleton;
        }
    }

    /// <summary>
    /// Empty Enumerator.
    /// </summary>
    internal sealed class EmptyEnumerator<T> : IEnumerator<T>
    {
        private static readonly IEnumerator<T> _EmptyEnumerator = new EmptyEnumerator<T>();

        private EmptyEnumerator()
        {
        }

        /// <summary>
        /// Static singleton.
        /// </summary>
        internal static IEnumerator<T> EmptyEnumeratorSingleton
        {
            get
            {
                return _EmptyEnumerator;
            }
        }


        #region IEnumerator<OpenXmlElement> Members

        public T Current
        {
            get
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyCollection);
            }
        }

        #endregion

        #region IEnumerator Members

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion

    }

    internal class EmptyEnumerable<T> : IEnumerable<T>
    {

        private static readonly EmptyEnumerable<T> _dummy = new EmptyEnumerable<T>();

        #region IEnumerable<KeyValuePair<string,string>> Members

        public IEnumerator<T> GetEnumerator()
        {
            return EmptyEnumerator<T>.EmptyEnumeratorSingleton;
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return EmptyEnumerator<T>.EmptyEnumeratorSingleton;
        }

        #endregion

        private EmptyEnumerable() { }

        public static EmptyEnumerable<T> EmptyEnumerableSingleton 
        {
            get
            {
                return _dummy;
            }
        }
    }
}
