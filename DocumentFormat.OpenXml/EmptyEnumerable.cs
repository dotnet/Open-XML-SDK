// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
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
