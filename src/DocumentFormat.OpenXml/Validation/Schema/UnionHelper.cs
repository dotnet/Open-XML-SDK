// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal static class UnionHelper
    {
        internal static OpenXmlSimpleType[] CreatePossibleMembers(UnionValueRestriction unionValueRestriction, FileFormatVersions fileFormatVersion)
        {
            switch (fileFormatVersion)
            {
                case FileFormatVersions.Office2007:
                    return O12UnionHelper.CreatePossibleMembers(unionValueRestriction);

                case FileFormatVersions.Office2010:
                    return O14UnionHelper.CreatePossibleMembers(unionValueRestriction);

                case FileFormatVersions.Office2013:
                    return O15UnionHelper.CreatePossibleMembers(unionValueRestriction);

                default:
                    Debug.Assert(fileFormatVersion.Any());
                    break;
            }

            return null;
        }

        internal static OpenXmlSimpleType CreateTargetValueObject(RedirectedRestriction redirectedRestriction, FileFormatVersions fileFormatVersion)
        {
            switch (fileFormatVersion)
            {
                case FileFormatVersions.Office2007:
                    return O12UnionHelper.CreateTargetValueObject(redirectedRestriction);

                case FileFormatVersions.Office2010:
                    return O14UnionHelper.CreateTargetValueObject(redirectedRestriction);

                case FileFormatVersions.Office2013:
                    return O15UnionHelper.CreateTargetValueObject(redirectedRestriction);

                default:
                    Debug.Assert(fileFormatVersion.Any());
                    break;
            }

            return null;
        }
    }
}
