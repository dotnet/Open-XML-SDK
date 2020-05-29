// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

#pragma warning disable CA1001 // Types that own disposable fields should be disposable

namespace DocumentFormat.OpenXml.Validation
{
    internal class ValidationStack
    {
        private readonly ValidationContextDisposable _popDisposable;
        private readonly Stack<ValidationElement> _elements;
        private readonly Stack<ValidationElement> _available;

        public ValidationStack()
        {
            // Start off with a depth of 5
            _elements = new Stack<ValidationElement>(5);
            _available = new Stack<ValidationElement>(5);
            _popDisposable = new ValidationContextDisposable(this);
        }

        public ValidationElement Current => _elements.Count > 0 ? _elements.Peek() : default;

        public IDisposable Push(OpenXmlPackage package = null, OpenXmlPart part = null, OpenXmlElement element = null)
        {
            var current = Current;
            var updated = GetOrCreateElement();

            updated.CopyFrom(current);

            updated.Package = package ?? current.Package;
            updated.Part = part ?? current.Part;
            updated.Element = element ?? current.Element;

            _elements.Push(updated);

            return _popDisposable;
        }

        public IDisposable Push(OpenXmlSimpleType value)
        {
            var current = Current;
            var element = GetOrCreateElement();

            element.CopyFrom(current);

            element.Value = value;

            _elements.Push(element);

            return _popDisposable;
        }

        public IDisposable Push(OpenXmlSimpleType value, AttributeMetadata property, bool isAttribute)
        {
            var current = Current;
            var element = GetOrCreateElement();

            element.CopyFrom(current);

            element.Value = value;
            element.Property = property;
            element.IsAttribute = isAttribute;

            _elements.Push(element);

            return _popDisposable;
        }

        public IDisposable Push(Action<ValidationErrorInfo> addError)
        {
            var current = Current;
            var element = GetOrCreateElement();

            element.CopyFrom(current);

            element.AddError = addError;

            _elements.Push(element);

            return _popDisposable;
        }

        private ValidationElement GetOrCreateElement()
        {
            if (_available.Count > 0)
            {
                return _available.Pop();
            }

            return new ValidationElement();
        }

        private sealed class ValidationContextDisposable : IDisposable
        {
            private readonly ValidationStack _stack;

            public ValidationContextDisposable(ValidationStack stack)
            {
                _stack = stack;
            }

            public void Dispose()
            {
                var available = _stack._elements.Pop();

                available.Clear();

                _stack._available.Push(available);
            }
        }
    }
}
