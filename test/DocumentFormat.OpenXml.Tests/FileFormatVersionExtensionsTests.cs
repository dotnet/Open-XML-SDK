// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class FileFormatVersionExtensionsTests
    {
        [InlineData(FileFormatVersions.None, false)]
        [InlineData(FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2013, true)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013, false)]
        [Theory]
        public void CheckAny(FileFormatVersions version, bool expected)
        {
            Assert.Equal(expected, version.Any());
        }

        [InlineData(FileFormatVersions.None, false)]
        [InlineData(FileFormatVersions.Office2007, false)]
        [InlineData(FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013, true)]
        [Theory]
        public void CheckAll(FileFormatVersions version, bool expected)
        {
            Assert.Equal(expected, version.All());
        }

        [InlineData(FileFormatVersions.None)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
        [Theory]
        public void AndLaterExceptions(FileFormatVersions version)
        {
            Assert.Throws<ArgumentOutOfRangeException>(nameof(version), () => version.AndLater());
        }

        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2013, true)]
        [Theory]
        public void CheckAtLeast(FileFormatVersions version, FileFormatVersions minimum, bool expected)
        {
            Assert.Equal(expected, version.AtLeast(minimum));
        }

        [InlineData(FileFormatVersions.None)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
        [Theory]
        public void AtLeastExceptions(FileFormatVersions version)
        {
            Assert.Throws<ArgumentOutOfRangeException>(nameof(version), () => version.AtLeast(FileFormatVersions.Office2007));
            Assert.Throws<ArgumentOutOfRangeException>("minimum", () => FileFormatVersions.Office2007.AtLeast(version));
        }
    }
}
