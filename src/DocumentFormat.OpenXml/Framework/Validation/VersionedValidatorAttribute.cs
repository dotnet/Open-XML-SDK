// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal abstract class VersionedValidatorAttribute : Attribute, IOpenXmlSimpleTypeValidator, IUnionValidator
    {
        private FileFormatVersions? _version;
        private FileFormatVersions? _initialVersion;
        private byte? _unionId;

        public FileFormatVersions Version
        {
            get => _version.GetValueOrDefault();
            set => _version = value;
        }

        public FileFormatVersions InitialVersion
        {
            get => _initialVersion.GetValueOrDefault();
            set => _initialVersion = value;
        }

        public byte UnionId
        {
            get => _unionId.GetValueOrDefault();
            set => _unionId = value;
        }

        byte? IUnionValidator.UnionId => _unionId;

        public void Validate(ValidationContext context)
        {
            if (IsValid(context.FileFormat))
            {
                ValidateVersion(context);
            }
        }

        private bool IsValid(FileFormatVersions version)
        {
            if (_initialVersion.HasValue)
            {
                return version.AtLeast(_initialVersion.Value);
            }
            else if (_version.HasValue)
            {
                return _version.Value == version;
            }
            else
            {
                return true;
            }
        }

        protected abstract void ValidateVersion(ValidationContext context);
    }
}
