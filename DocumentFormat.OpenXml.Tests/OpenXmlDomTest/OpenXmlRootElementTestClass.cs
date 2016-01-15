// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

using Xunit;

namespace DocumentFormat.OpenXml.Tests
{

    public class OpenXmlRootElementTestClass : OpenXmlDomTestBase
    {
        [Fact]
        public void PartRootElementFactoryTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles("asSources")
               .Where(f => f.IsOpenXmlFile());

            foreach (var testfile in testfiles)
            {
                Log.BeginGroup(testfile.FullName);
                using (var package = testfile.OpenPackage(false))
                {
                    var parts = package.DescendantParts()
                        .Where(p => p.IsReflectable())
                        .OrderBy(p => p.Uri.ToString());
                    foreach (var part in parts)
                    {
                        var root = part.RootElement();
                        Log.Comment("Part: {0} @ {1}. Root:{2} - {3}", part.GetType().Name, part.Uri.ToString(), root.GetType(), root.GetFullName());
                    }
                    Log.Pass("Verified: {0}", testfile.Name);
                }
            }
        }
    }
}