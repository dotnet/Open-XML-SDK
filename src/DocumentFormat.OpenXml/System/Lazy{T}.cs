// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// An implementation of Lazy{T} that is supported on .NET 3.5 and is always thread-safe.
    /// </summary>
    /// <typeparam name="T">Type to create.</typeparam>
    internal sealed class Lazy<T>
    {
        private readonly object _sync = new object();

        private T _value;
        private Func<T> _factory;
        private bool _isValueCreated;

        public Lazy(Func<T> factory, bool threadSafe)
        {
            _factory = factory;
        }

        public Lazy(Func<T> factory)
        {
            _factory = factory;
        }

        public bool IsValueCreated
        {
            get
            {
                lock(_sync)
                {
                    return _isValueCreated;
                }
            }
        }

        public T Value
        {
            get
            {
                if(!_isValueCreated)
                {
                    lock(_sync)
                    {
                        if(!_isValueCreated)
                        {
                            _value = _factory();
                            _isValueCreated = true;
                            _factory = null;
                        }
                    }
                }

                return _value;
            }
        }
    }
}
