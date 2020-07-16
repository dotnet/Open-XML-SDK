// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Validation context.
    /// </summary>
    internal class ValidationContext
    {
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

            Stack = new ValidationStack();

            Stack.Push(Errors.Add);
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

        public StateManager State { get; } = new StateManager();

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
            return Stack.Current.Element.GetFirstChildMc(McContext, FileFormat);
        }

        /// <summary>
        /// Get the next child of this.Element according to the MC Mode.
        /// </summary>
        /// <param name="child">The child after which the next child going to be retrieved.</param>
        /// <returns>The next child after the specified child in the MC mode.</returns>
        internal OpenXmlElement GetNextChildMc(OpenXmlElement child)
        {
            return Stack.Current.Element.GetNextChildMc(child, McContext, FileFormat);
        }

        /// <summary>
        /// Gets the maximum number of errors. A zero (0) value means no limitation.
        /// When the errors >= MaxNumberOfErrors, errors will not be recorded, and MaxNumberOfErrorsEvent will be fired.
        /// </summary>
        public int MaxNumberOfErrors => Settings.MaxNumberOfErrors;

        public ValidationStack Stack { get; }

        public ParticleConstraint GetParticleConstraint() => Cache.GetConstraint(Stack.Current.Element);

        public void AddError(ValidationErrorInfo error)
        {
            if (error != null && !IsCancelled)
            {
                Stack.Current.AddError(error);
            }
        }

        public void CreateError(string id, ValidationErrorType errorType, string description = null)
        {
            var current = Stack.Current;

            var error = new ValidationErrorInfo
            {
                Id = id,
                Description = description,
                Part = current.Part,
                ErrorType = errorType,
                Node = current.Element,
            };

            AddError(error);
        }
    }
}
