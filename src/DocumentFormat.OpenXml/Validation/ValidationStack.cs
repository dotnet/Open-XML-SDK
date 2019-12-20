// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
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

        public ValidationElement Current => _elements.Peek();

        public IDisposable Push(OpenXmlSimpleType value, ElementProperty<OpenXmlSimpleType> type, bool isAttribute)
        {
            _elements.Push(new ValidationElement(value, type, isAttribute, Current.AddError));

            return _popDisposable;
        }

        public IDisposable Push(Action<ValidationErrorInfo> addError)
        {
            var current = Current;

            _elements.Push(new ValidationElement(current.Value, current.Property, current.IsAttribute, addError));

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
