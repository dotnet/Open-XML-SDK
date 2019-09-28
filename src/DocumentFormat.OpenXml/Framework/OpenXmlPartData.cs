// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal class OpenXmlPartData
    {
        private readonly Lazy<PartConstraintCollection> _constraints;
        private readonly Lazy<PartConstraintCollection> _dataParts;

        public OpenXmlPartData(Type type, Func<Type, OpenXmlElementData> dataFactory)
        {
            _constraints = new Lazy<PartConstraintCollection>(() => PartConstraintCollection.Create<PartConstraintAttribute>(dataFactory, type), true);
            _dataParts = new Lazy<PartConstraintCollection>(() => PartConstraintCollection.Create<DataPartConstraintAttribute>(dataFactory, type), true);
        }

        public PartConstraintCollection PartConstraints => _constraints.Value;

        public PartConstraintCollection DataPartReferenceConstraints => _dataParts.Value;
    }
}
