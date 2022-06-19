// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DocumentFormat.OpenXml.Validation
{
    internal class ValidationContext
    {
        private readonly CancellationToken _token;

        public ValidationContext(IOpenXmlNamespaceResolver resolver, FileFormatVersions version = FileFormatVersions.Office2007)
            : this(resolver, new ValidationSettings(version), new ValidationCache(version), default)
        {
        }

        public ValidationContext(IOpenXmlNamespaceResolver resolver, ValidationSettings settings, ValidationCache cache, CancellationToken token)
        {
            _token = token;

            Cache = cache ?? throw new ArgumentNullException(nameof(cache));
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
            Errors = new List<ValidationErrorInfo>();
            McContext = new MCContext(resolver, false);

            Stack = new ValidationStack();
            State = new StateManager(this);

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

        /// <summary>
        /// If a <see cref="CancellationToken"/> is used and is cancelled, this will throw. Otherwise, it will
        /// check the number of errors against the <see cref="MaxNumberOfErrors"/>.
        /// </summary>
        /// <returns><c>true</c> if error count is too high.</returns>
        public bool CheckIfCancelled()
        {
            _token.ThrowIfCancellationRequested();

            return MaxNumberOfErrors > 0 && Errors.Count >= MaxNumberOfErrors;
        }

        public void Clear() => Errors.Clear();

        public StateManager State { get; }

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
        internal OpenXmlElement? GetFirstChildMc()
            => Stack.Current?.Element?.GetFirstChildMc(McContext, FileFormat);

        /// <summary>
        /// Get the next child of this.Element according to the MC Mode.
        /// </summary>
        /// <param name="child">The child after which the next child going to be retrieved.</param>
        /// <returns>The next child after the specified child in the MC mode.</returns>
        internal OpenXmlElement? GetNextChildMc(OpenXmlElement? child)
            => child is null ? null : Stack.Current?.Element?.GetNextChildMc(child, McContext, FileFormat);

        /// <summary>
        /// Gets the maximum number of errors. A zero (0) value means no limitation.
        /// When the errors >= MaxNumberOfErrors, errors will not be recorded, and MaxNumberOfErrorsEvent will be fired.
        /// </summary>
        public int MaxNumberOfErrors => Settings.MaxNumberOfErrors;

        public ValidationStack Stack { get; }

        public ParticleConstraint? GetParticleConstraint() => Stack.Current?.Element is OpenXmlElement element ? Cache.GetConstraint(element) : null;

        public void AddError(ValidationErrorInfo error)
        {
            if (error is not null && !CheckIfCancelled())
            {
                Stack.Current?.AddError?.Invoke(error);
            }
        }

        public void CreateError(string id, ValidationErrorType errorType, string? description = null)
        {
            var current = Stack.Current;

            var error = new ValidationErrorInfo
            {
                Id = id,
                Description = description ?? string.Empty,
                Part = current?.Part,
                ErrorType = errorType,
                Node = current?.Element,
            };

            AddError(error);
        }
    }
}
