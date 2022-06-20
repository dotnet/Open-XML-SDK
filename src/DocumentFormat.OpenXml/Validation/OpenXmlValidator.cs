// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the OpenXmlValidator.
    /// </summary>
    public class OpenXmlValidator
    {
        private readonly ValidationSettings _settings;
        private readonly ValidationCache _cache;
        private readonly DocumentValidator _documentValidator;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlValidator"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="FileFormatVersions.Office2007"/>.
        /// </remarks>
        public OpenXmlValidator()
            : this(FileFormatVersions.Office2007)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlValidator"/>.
        /// </summary>
        /// <param name="fileFormat">The target file format to be validated against.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the <paramref name="fileFormat"/> parameter is not a known format.</exception>
        public OpenXmlValidator(FileFormatVersions fileFormat)
        {
            fileFormat.ThrowExceptionIfFileFormatNotSupported(nameof(fileFormat));

            _settings = new ValidationSettings(fileFormat);
            _cache = new ValidationCache(fileFormat);
            _documentValidator = new DocumentValidator(_cache);
        }

        /// <summary>
        /// Gets the target file format to be validated against.
        /// </summary>
        public FileFormatVersions FileFormat => _settings.FileFormat;

        /// <summary>
        /// Gets or sets the maximum number of errors the OpenXmlValidator will return.
        /// Default is <c>1000</c>. A <c>0</c> value means no limitation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw when the value set is less than zero.</exception>
        public int MaxNumberOfErrors
        {
            get => _settings.MaxNumberOfErrors;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _settings.MaxNumberOfErrors = value;
            }
        }

        /// <summary>
        /// Validates the specified document.
        /// </summary>
        /// <param name="openXmlPackage">The target <see cref="OpenXmlPackage"/>.</param>
        /// <returns>A set of validation errors.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="openXmlPackage"/> parameter is null.</exception>
        public IEnumerable<ValidationErrorInfo> Validate(OpenXmlPackage openXmlPackage)
            => Validate(openXmlPackage, default);

        /// <summary>
        /// Validates the specified document.
        /// </summary>
        /// <param name="openXmlPackage">The target <see cref="OpenXmlPackage"/>.</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>A set of validation errors.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="openXmlPackage"/> parameter is null.</exception>
#if FEATURE_CANCELLATION_TOKEN
        public
#else
        private
#endif
        IEnumerable<ValidationErrorInfo> Validate(OpenXmlPackage openXmlPackage, CancellationToken token = default)
        {
            // Note: This is private on .NET 3.5 as CancellationToken on that platform is not available.
            if (openXmlPackage is null)
            {
                throw new ArgumentNullException(nameof(openXmlPackage));
            }

            if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
                openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormat)
            {
                var exceptionMessage = SR.Format(
                    ExceptionMessages.DocumentFileFormatVersionMismatch,
                    openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions,
                    FileFormat);

                throw new InvalidOperationException(exceptionMessage);
            }

            return _documentValidator.Validate(openXmlPackage, _settings, token);
        }

        /// <summary>
        /// Validates the specified content in the <paramref name="openXmlPart"/>.
        /// </summary>
        /// <param name="openXmlPart">The target OpenXmlPart.</param>
        /// <returns>A set of validation errors.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="openXmlPart"/> parameter is null.</exception>
        /// <exception cref="InvalidOperationException">Throw when the specified part is not a defined part in the specified <see cref="FileFormat"/> version.</exception>
        public IEnumerable<ValidationErrorInfo> Validate(OpenXmlPart openXmlPart)
            => Validate(openXmlPart, default);

        /// <summary>
        /// Validates the specified content in the <paramref name="openXmlPart"/>.
        /// </summary>
        /// <param name="openXmlPart">The target OpenXmlPart.</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>A set of validation errors.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="openXmlPart"/> parameter is null.</exception>
        /// <exception cref="InvalidOperationException">Throw when the specified part is not a defined part in the specified <see cref="FileFormat"/> version.</exception>
#if FEATURE_CANCELLATION_TOKEN
        public
#else
        private
#endif
        IEnumerable<ValidationErrorInfo> Validate(OpenXmlPart openXmlPart, CancellationToken token = default)
        {
            // Note: This is private on .NET 3.5 as CancellationToken on that platform is not available.
            if (openXmlPart is null)
            {
                throw new ArgumentNullException(nameof(openXmlPart));
            }

            var openXmlPackage = openXmlPart.OpenXmlPackage;
            if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
                openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormat)
            {
                var exceptionMessage = SR.Format(
                    ExceptionMessages.DocumentFileFormatVersionMismatch,
                    openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions,
                    FileFormat);

                throw new InvalidOperationException(exceptionMessage);
            }

            FileFormat.ThrowIfNotInVersion(openXmlPart);

            return _documentValidator.Validate(openXmlPart, _settings, token);
        }

        /// <summary>
        /// Validates the specified element.
        /// </summary>
        /// <param name="openXmlElement">The target OpenXmlElement.</param>
        /// <returns>A set of validation errors.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="openXmlElement"/> parameter is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the <paramref name="openXmlElement"/> is type of <see cref="OpenXmlUnknownElement"/>, <see cref="OpenXmlMiscNode"/>, <see cref="AlternateContent"/>, <see cref="AlternateContentChoice"/> or <see cref="AlternateContentFallback"/>.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the <paramref name="openXmlElement"/> is not defined in the specified <see cref="FileFormat"/>.</exception>
        public IEnumerable<ValidationErrorInfo> Validate(OpenXmlElement openXmlElement)
            => Validate(openXmlElement, default);

        /// <summary>
        /// Validates the specified element.
        /// </summary>
        /// <param name="openXmlElement">The target OpenXmlElement.</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>A set of validation errors.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="openXmlElement"/> parameter is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the <paramref name="openXmlElement"/> is type of <see cref="OpenXmlUnknownElement"/>, <see cref="OpenXmlMiscNode"/>, <see cref="AlternateContent"/>, <see cref="AlternateContentChoice"/> or <see cref="AlternateContentFallback"/>.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the <paramref name="openXmlElement"/> is not defined in the specified <see cref="FileFormat"/>.</exception>
#if FEATURE_CANCELLATION_TOKEN
        public
#else
        private
#endif
        IEnumerable<ValidationErrorInfo> Validate(OpenXmlElement openXmlElement, CancellationToken token = default)
        {
            // Note: This is private on .NET 3.5 as CancellationToken on that platform is not available.
            if (openXmlElement is null)
            {
                throw new ArgumentNullException(nameof(openXmlElement));
            }

            if (openXmlElement is OpenXmlUnknownElement)
            {
                throw new ArgumentOutOfRangeException(nameof(openXmlElement), ExceptionMessages.CannotValidateUnknownElement);
            }

            if (openXmlElement is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException(nameof(openXmlElement), ExceptionMessages.CannotValidateMiscNode);
            }

            if (openXmlElement is AlternateContent ||
                openXmlElement is AlternateContentChoice ||
                openXmlElement is AlternateContentFallback)
            {
                throw new ArgumentOutOfRangeException(nameof(openXmlElement), ExceptionMessages.CannotValidateAcbElement);
            }

            FileFormat.ThrowIfNotInVersion(openXmlElement);

            var validationContext = new ValidationContext(openXmlElement.Features.GetNamespaceResolver(), _settings, _cache, token);

            using (validationContext.Stack.Push(element: openXmlElement))
            {
                _documentValidator.Validate(validationContext);

                return validationContext.Errors;
            }
        }
    }
}
