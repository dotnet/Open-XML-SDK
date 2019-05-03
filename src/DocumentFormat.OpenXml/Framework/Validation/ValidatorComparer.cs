// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework
{
    internal class ValidatorComparer : IComparer<IOpenXmlSimpleTypeValidator>
    {
        public static IComparer<IOpenXmlSimpleTypeValidator> Instance { get; } = new ValidatorComparer();

        private ValidatorComparer()
        {
        }

        public int Compare(IOpenXmlSimpleTypeValidator x, IOpenXmlSimpleTypeValidator y) => Map(x).CompareTo(Map(y));

        private static int Map(IOpenXmlSimpleTypeValidator v)
        {
            if (v.GetType() == typeof(RequiredValidatorAttribute))
            {
                return 0;
            }
            else
            {
                return int.MaxValue;
            }
        }
    }
}
