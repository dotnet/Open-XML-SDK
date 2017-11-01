using System;
using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    public interface IFile : IDisposable
    {
        string Path { get; }

        Stream Open();
    }
}
