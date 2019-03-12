// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class OpenXmlPartData
    {
        private readonly Type _type;

        private PartConstraintCollection _constraints;
        private PartConstraintCollection _dataParts;

        public OpenXmlPartData(Type type)
        {
            _type = type;
        }

        /// <summary>
        /// Gets the constraint rule
        /// </summary>
        /// <returns>The constraint rule.</returns>
        public PartConstraintCollection PartConstraints
        {
            get
            {
                if (_constraints == null)
                {
                    _constraints = PackageCache.Cache.GetPartConstraints(_type);
                }

                return _constraints;
            }
        }

        /// <summary>
        /// Gets the constraint rule of DataPartReferenceRelationship.
        /// </summary>
        /// <returns>The constraint rule.</returns>
        public PartConstraintCollection DataPartReferenceConstraints
        {
            get
            {
                if (_dataParts == null)
                {
                    _dataParts = PackageCache.Cache.GetDataPartConstraints(_type);
                }

                return _dataParts;
            }
        }
    }
}
