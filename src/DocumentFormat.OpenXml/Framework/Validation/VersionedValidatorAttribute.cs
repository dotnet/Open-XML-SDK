// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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

        public Type SimpleType { get; set; }

        public void Validate(ValidatorContext context)
        {
            if (IsValid(context.Version))
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

        protected OpenXmlSimpleType GetValue(ValidatorContext context)
        {
            var input = context.Value;

            if (input is null)
            {
                return null;
            }

            if (SimpleType is null)
            {
                return input;
            }

            if (input.GetType() == SimpleType)
            {
                return input;
            }

            var factory = PackageCache.Cache.GetFactory<OpenXmlSimpleType>(SimpleType);
            var output = factory();

            output.InnerText = input.InnerText;

            return output;
        }

        protected abstract void ValidateVersion(ValidatorContext context);
    }
}
