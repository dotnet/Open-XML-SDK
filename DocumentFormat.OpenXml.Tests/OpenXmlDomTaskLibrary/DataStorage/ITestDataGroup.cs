using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage
{
    public interface ITestDataGroup
    {
        string ID { get; }
        string Description { get; }
        List<ITestData> GetEntries();
    }
}
