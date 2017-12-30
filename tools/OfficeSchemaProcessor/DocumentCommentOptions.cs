// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace OfficeSchemaProcessor
{
    public class DocumentCommentOptions
    {
        public string Summary { get; set; }

        public IEnumerable<(string paramName, string message)> Parameters { get; set; } = Array.Empty<(string, string)>();

        public string Return { get; set; }
    }
}
