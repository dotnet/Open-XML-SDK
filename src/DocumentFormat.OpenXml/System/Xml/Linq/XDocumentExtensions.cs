// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace System.Xml.Linq
{
    internal static class XDocumentExtensions
    {
        public static void Save(this XDocument doc, Stream stream)
        {
            using var writer = new StreamWriter(stream);

            doc.Save(writer);
        }
    }
}
