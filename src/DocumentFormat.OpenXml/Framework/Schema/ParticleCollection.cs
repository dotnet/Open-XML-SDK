// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Schema
{
    internal readonly struct ParticleCollection<TElement> : IEnumerable<TElement>
        where TElement : OpenXmlElement
    {
        private readonly OpenXmlCompositeElement _element;
        private readonly CompiledParticle _compiled;
        private readonly ParticlePath _elementPath;

        internal ParticleCollection(CompiledParticle compiled, OpenXmlCompositeElement element)
        {
            _element = element;
            _compiled = compiled;
            _elementPath = compiled.Find<TElement>();
        }

        public void Clear()
        {
            var enumerator = new OpenXmlCompositeElementEnumerator(this);
            var remove = default(OpenXmlElement);

            while (enumerator.MoveNext())
            {
                if (remove != null)
                {
                    remove.Remove();
                    remove = null;
                }

                var data = enumerator.Current;
                var current = _compiled.Find(data);

                if (current != null && current.Equals(_elementPath))
                {
                    remove = data;
                }
            }

            if (remove != null)
            {
                remove.Remove();
            }
        }

        public bool IsNil => _compiled is null || _elementPath is null;

        public int Count
        {
            get
            {
                int count = 0;

                foreach (var _ in this)
                {
                    count++;
                }

                return count;
            }
        }

        public bool Add(TElement value)
        {
            if (IsNil)
            {
                return false;
            }

            var node = GetNode();

            if (node is null)
            {
                _element.PrependChild(value);
            }
            else
            {
                _element.InsertAfter(value, node);
            }

            return true;
        }

        public bool Contains(TElement item)
        {
            foreach (var child in this)
            {
                if (Equals(child, item))
                {
                    return true;
                }
            }

            return false;
        }

        private OpenXmlElement GetNode()
        {
            var enumerator = new OpenXmlCompositeElementEnumerator(this);

            while (enumerator.MoveNext())
            {
                var data = enumerator.Current;
                var compared = _elementPath.CompareTo(enumerator.Path);

                if (compared < 0)
                {
                    return data.PreviousSibling();
                }
                else if (compared == 0)
                {
                    var result = enumerator.Current;

                    while (enumerator.MoveNext() && enumerator.Path.Equals(_elementPath))
                    {
                        result = enumerator.Current;
                    }

                    return result;
                }
                else if (data == _element.LastChild)
                {
                    return data;
                }
            }

            return null;
        }

        public Enumerator GetEnumerator() => new Enumerator(_element);

        IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public struct Enumerator : IEnumerator<TElement>
        {
            private OpenXmlElement _child;

            public Enumerator(OpenXmlElement element)
            {
                _child = element.FirstChild;
                Current = null;
            }

            public TElement Current { get; private set; }

            object IEnumerator.Current => Current;

            void IDisposable.Dispose()
            {
            }

            public bool MoveNext()
            {
                Current = null;

                while (_child != null)
                {
                    if (_child.GetType() == typeof(TElement))
                    {
                        Current = (TElement)_child;
                        _child = _child.NextSibling();
                        return true;
                    }

                    _child = _child.NextSibling();
                }

                return false;
            }

            void IEnumerator.Reset() => throw new NotImplementedException();
        }

        private struct OpenXmlCompositeElementEnumerator
        {
            private ParticleCollection<TElement> _collection;

            public OpenXmlCompositeElementEnumerator(in ParticleCollection<TElement> collection)
            {
                _collection = collection;
                Current = default;
                Path = null;
            }

            public OpenXmlElement Current { get; private set; }

            public ParticlePath Path { get; private set; }

            private bool Complete()
            {
                _collection = default;
                Path = null;
                Current = null;
                return false;
            }

            private bool IsComplete => Current is null || Current == _collection._element.FirstChild;

            public bool MoveNext()
            {
                if (_collection.IsNil)
                {
                    return false;
                }

                if (Current is null)
                {
                    return Initialize();
                }

                Advance();

                if (IsComplete)
                {
                    return Complete();
                }

                if (_collection._elementPath.Type == ParticleType.All && !_collection._elementPath.IsSibling(Path))
                {
                    return Complete();
                }

                return IsComplete ? Complete() : true;
            }

            private bool Initialize()
            {
                Advance();

                if (Current is null)
                {
                    return Complete();
                }

                while (_collection._elementPath.CompareTo(Path) < 0)
                {
                    if (Current == _collection._element.LastChild)
                    {
                        return false;
                    }

                    Advance();

                    if (IsComplete)
                    {
                        return Complete();
                    }
                }

                return true;
            }

            private void Advance()
            {
                do
                {
                    if (Current is null)
                    {
                        Current = _collection._element.FirstChild;

                        if (Current is null)
                        {
                            return;
                        }
                    }
                    else
                    {
                        Current = Current.Next;

                        if (IsComplete)
                        {
                            return;
                        }
                    }

                    Path = _collection._compiled.Find(Current);
                } while (Path == null);
            }
        }
    }
}
