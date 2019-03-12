// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class OpenXmlPartData
    {
        private readonly Lazy<PartConstraintCollection> _constraints;
        private readonly Lazy<PartConstraintCollection> _dataParts;

        public OpenXmlPartData(Type type, PackageCache cache)
        {
            _constraints = new Lazy<PartConstraintCollection>(() => PartConstraintCollection.Create<PartConstraintAttribute>(cache, type), true);
            _dataParts = new Lazy<PartConstraintCollection>(() => PartConstraintCollection.Create<DataPartConstraintAttribute>(cache, type), true);
        }

        public static OpenXmlPartData Create(OpenXmlPartContainer part) => PackageCache.Cache.ParsePart(part);

        public PartConstraintCollection PartConstraints => _constraints.Value;

        public PartConstraintCollection DataPartReferenceConstraints => _dataParts.Value;
    }
}
