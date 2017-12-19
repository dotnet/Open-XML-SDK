// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
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
}
