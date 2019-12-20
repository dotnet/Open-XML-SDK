// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;

#pragma warning disable CA1001 // Types that own disposable fields should be disposable

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Validation context.
    /// </summary>
    internal class ValidationContext
    {
        private readonly ValidationContextDisposable _popDisposable;
        private readonly Stack<CurrentElement> _elements;

        public ValidationContext(FileFormatVersions version = FileFormatVersions.Office2007)
            : this(new ValidationSettings(version), new ValidationCache(version))
        {
        }

        public ValidationContext(ValidationContext other)
            : this(other.Settings, other.Cache)
        {
        }

        public ValidationContext(ValidationSettings settings, ValidationCache cache)
        {
            Cache = cache ?? throw new ArgumentNullException(nameof(cache));
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
            Errors = new List<ValidationErrorInfo>();
            McContext = new MCContext(false);

            _elements = new Stack<CurrentElement>();
            _elements.Push(new CurrentElement(null, default, false, Errors.Add));
            _popDisposable = new ValidationContextDisposable(_elements);
        }

        public ValidationCache Cache { get; }

        public ValidationSettings Settings { get; }

        public List<ValidationErrorInfo> Errors { get; }

        /// <summary>
        /// Gets target file format.
        /// </summary>
        public FileFormatVersions FileFormat => Settings.FileFormat;

        public bool Valid => Errors.Count == 0;

        public bool IsCancelled => MaxNumberOfErrors > 0 && Errors.Count >= MaxNumberOfErrors;

        public void Clear() => Errors.Clear();

        internal StateManager State { get; } = new StateManager();

        internal IValidationContextEvents Events => State;

        /// <summary>
        /// Gets or sets the target OpenXmlPackage.
        /// </summary>
        public OpenXmlPackage Package { get; internal set; }

        /// <summary>
        /// Gets or sets the target OpenXmlPart
        /// </summary>
        public OpenXmlPart Part { get; internal set; }

        /// <summary>
        /// Gets or sets the target element.
        /// </summary>
        public OpenXmlElement Element { get; internal set; }

        /// <summary>
        /// Gets used to track MC context.
        /// </summary>
        internal MCContext McContext { get; }

        /// <summary>
        /// Gets or sets a value indicating whether collect ExpectedChildren or not.
        /// </summary>
        internal bool CollectExpectedChildren { get; set; }

        /// <summary>
        /// Get the first child of this.Element according to the MC Mode.
        /// </summary>
        /// <returns>The first child in the MC mode.</returns>
        internal OpenXmlElement GetFirstChildMc()
        {
            return Element.GetFirstChildMc(McContext, FileFormat);
        }

        /// <summary>
        /// Get the next child of this.Element according to the MC Mode.
        /// </summary>
        /// <param name="child">The child after which the next child going to be retrieved.</param>
        /// <returns>The next child after the specified child in the MC mode.</returns>
        internal OpenXmlElement GetNextChildMc(OpenXmlElement child)
        {
            return Element.GetNextChildMc(child, McContext, FileFormat);
        }

        /// <summary>
        /// Gets the maximum number of errors. A zero (0) value means no limitation.
        /// When the errors >= MaxNumberOfErrors, errors will not be recorded, and MaxNumberOfErrorsEvent will be fired.
        /// </summary>
        public int MaxNumberOfErrors => Settings.MaxNumberOfErrors;

        public CurrentElement Current => _elements.Peek();

        public IDisposable PushElement(OpenXmlSimpleType value, ElementProperty<OpenXmlSimpleType> type, bool isAttribute)
        {
            _elements.Push(new CurrentElement(value, type, isAttribute, Current.AddError));

            return _popDisposable;
        }

        public IDisposable Push(Action<ValidationErrorInfo> addError)
        {
            var current = Current;

            _elements.Push(new CurrentElement(current.Value, current.Property, current.IsAttribute, addError));

            return _popDisposable;
        }

        public ValidatorContext ToContext()
        {
            return new ValidatorContext(this);
        }

        public ParticleConstraint GetParticleConstraint() => Cache.GetConstraint(Element);

        public void AddError(ValidationErrorInfo error)
        {
            if (error != null && !IsCancelled)
            {
                Current.AddError(error);
            }
        }

        public void CreateError(string id, ValidationErrorType errorType, string description = null)
        {
            var error = new ValidationErrorInfo
            {
                Id = id,
                Description = description,
                Part = Part,
                ErrorType = errorType,
                Node = Element,
            };

            AddError(error);
        }

        public readonly struct CurrentElement
        {
            public CurrentElement(OpenXmlSimpleType value, ElementProperty<OpenXmlSimpleType> property, bool isAttribute, Action<ValidationErrorInfo> addError)
            {
                Value = value;
                Property = property;
                IsAttribute = isAttribute;
                AddError = addError;
            }

            public OpenXmlSimpleType Value { get; }

            public ElementProperty<OpenXmlSimpleType> Property { get; }

            public bool IsAttribute { get; }

            public Action<ValidationErrorInfo> AddError { get; }
        }

        private sealed class ValidationContextDisposable : IDisposable
        {
            private readonly Stack<CurrentElement> _stack;

            public ValidationContextDisposable(Stack<CurrentElement> stack)
            {
                _stack = stack;
            }

            public void Dispose() => _stack.Pop();
        }
    }
}
