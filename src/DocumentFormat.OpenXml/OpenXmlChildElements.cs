// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Implements OpenXmlElementList.
    /// </summary>
    internal class OpenXmlChildElements : OpenXmlElementList
    {
        private OpenXmlElement _container;

        public OpenXmlChildElements(OpenXmlElement container)
        {
            _container = container;
        }

        public override IEnumerator<OpenXmlElement> GetEnumerator()
        {
            if (_container.HasChildren && _container.FirstChild != null)
            {
                for ( OpenXmlElement element = _container.FirstChild;
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
            if (_container.HasChildren)
            {
                for (OpenXmlElement element = _container.FirstChild;
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
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        public override int Count
        {
            get
            {
                int num = 0;
                if (_container.HasChildren)
                {
                    for (OpenXmlElement element = _container.FirstChild;
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
}
