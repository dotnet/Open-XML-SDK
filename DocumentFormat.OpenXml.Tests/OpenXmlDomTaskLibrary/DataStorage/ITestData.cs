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
