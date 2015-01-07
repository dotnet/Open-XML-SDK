// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
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
                    Debug.Assert(fileFormatVersion == FileFormatVersions.Office2007 || fileFormatVersion == FileFormatVersions.Office2010 || fileFormatVersion == FileFormatVersions.Office2013);
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
                    Debug.Assert(fileFormatVersion == FileFormatVersions.Office2007 || fileFormatVersion == FileFormatVersions.Office2010 || fileFormatVersion == FileFormatVersions.Office2013);
                    break;
            }
            return null;
        }
    }
}
