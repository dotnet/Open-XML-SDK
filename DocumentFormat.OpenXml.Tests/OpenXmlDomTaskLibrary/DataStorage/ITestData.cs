// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage
{
    public interface ITestData
    {
        FileType Type { get; }
        string FilePath { get; }
        Stream GetStream();
        string Description { get; }
    }
}
