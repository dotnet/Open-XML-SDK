﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    internal class OpenXmlNamespaceIdResolver : IOpenXmlNamespaceIdResolver
    {
        // This list is hard coded for backwards compatibility for before v2.15.0 when there was the possibility someone might use an id.
        // We only provide ids for the items that did have ids - new ones will not have one.
        private readonly List<string> _ids = new()
        {
            string.Empty,
            "xml",
            "cp",
            "ap",
            "op",
            "vt",
            "dc",
            "dcterms",
            "ac",
            "b",
            "a",
            "c",
            "cdr",
            "comp",
            "dgm",
            "lc",
            "wp",
            "pic",
            "xdr",
            "r",
            "ds",
            "m",
            "x",
            "w",
            "p",
            "sl",
            "v",
            "o",
            "w10",
            "xvml",
            "pvml",
            "mc",
            "xne",
            "wne",
            "mso",
            "ax",
            "cppr",
            "cdip",
            "ct",
            "ntns",
            "lp",
            "ma",
            "xsd",
            "inkml",
            "emma",
            "msink",
            "c14",
            "cdr14",
            "a14",
            "p14",
            "pic14",
            "wp14",
            "w14",
            "x14",
            "xdr14",
            "x14ac",
            "dsp",
            "mso14",
            "dgm14",
            "wpc",
            "wpg",
            "wps",
            "sle",
            "com14",
            "c15",
            "cs",
            "we",
            "a15",
            "p15",
            "w15",
            "wetp",
            "x15",
            "x12ac",
            "thm15",
            "x15ac",
            "wp15",
            "pRoam",
            "tsle",
            "p16",
            "a16",
            "cx",
            "c16ac",
            "c16",
            "xr",
            "x16",
            "x16r2",
            "w16se",
            "oac",
            "pc",
            "p173",
            "p1710",
            "p184",
            "xpdl",
            "xlPr",
            "xr2",
            "xr3",
            "xr5",
            "xr6",
            "xr9",
            "xr10",
            "xr16",
            "xlrd2",
            "xlrd",
            "xcalcf",
            "xltc",
            "c16r3",
            "xda",
            "a1611",
            "dgm1611",
            "dgm1612",
            "aink",
            "am3d",
            "adec",
            "aanim",
            "a3danim",
            "ahyp",
            "w16cid",
            "asvg",
            "clbl",
            "aclsh",
            "ask",
            "alf",
            "oel",
            "p188",
            "p202",
            "t",
            "w16cur",
            "w16cex",
            "w16sdtdh",
            "xnsv",
            "xlrdwi",
            "xltc2",
            "x16r3",
            "xxlnp",
            "xlrvr",
            "xxpim",
            "ppt1912SchemaUri",
        };

        public string GetPrefix(byte id)
        {
            if (id < _ids.Count)
            {
                return _ids[id];
            }

            throw new ArgumentOutOfRangeException(nameof(id), ExceptionMessages.NamespaceIdNotAvailable);
        }
    }
}