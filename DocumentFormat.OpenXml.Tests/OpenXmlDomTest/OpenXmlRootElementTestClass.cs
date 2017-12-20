// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlRootElementTestClass : OpenXmlDomTestBase
    {
        public OpenXmlRootElementTestClass(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void PartRootElementFactoryTest()
        {
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
