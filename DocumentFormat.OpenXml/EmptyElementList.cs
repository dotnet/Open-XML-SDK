// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
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
            throw new ArgumentOutOfRangeException(nameof(index));
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
}
