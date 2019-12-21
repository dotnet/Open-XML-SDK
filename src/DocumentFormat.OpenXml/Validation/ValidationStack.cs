// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
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

        public ValidationStack()
        {
            // Start off with a depth of 5
            _elements = new Stack<ValidationElement>(5);
            _popDisposable = new ValidationContextDisposable(_elements);
        }

        public ValidationElement Current => _elements.Count > 0 ? _elements.Peek() : default;

        public IDisposable Push(OpenXmlPackage package = null, OpenXmlPart part = null)
        {
            var current = Current;

            _elements.Push(new ValidationElement(
                package ?? current.Package,
                part ?? current.Part,
                current.Value,
                current.Property,
                current.IsAttribute,
                current.AddError));

            return _popDisposable;
        }

        public IDisposable Push(OpenXmlSimpleType value, ElementProperty<OpenXmlSimpleType> property, bool isAttribute)
        {
            var current = Current;

            _elements.Push(new ValidationElement(
                current.Package,
                current.Part,
                value,
                property,
                isAttribute,
                current.AddError));

            return _popDisposable;
        }

        public IDisposable Push(Action<ValidationErrorInfo> addError)
        {
            var current = Current;

            _elements.Push(new ValidationElement(
                current.Package,
                current.Part,
                current.Value,
                current.Property,
                current.IsAttribute,
                addError));

            return _popDisposable;
        }

        private sealed class ValidationContextDisposable : IDisposable
        {
            private readonly Stack<ValidationElement> _stack;

            public ValidationContextDisposable(Stack<ValidationElement> stack)
            {
                _stack = stack;
            }

            public void Dispose() => _stack.Pop();
        }
    }
}
