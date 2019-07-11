// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security;
using System.Security.Policy;

namespace IsolatedStorageExceptionWorkaround
{
    /// <summary>
    /// When an application tries to use DocumentFormat.OpenXml in an AppDomain that does not have sufficient evidence, the following
    /// error may occur:
    ///
    /// <![CDATA[
    /// System.IO.IsolatedStorage.IsolatedStorageException: Unable to determine the identity of domain.
    /// ]]>
    ///
    /// This can occur in scenarios where the code is hosted, such as add-ins or extensions. A simple work around is to create
    /// your own app-domain to do the process. However, keep in mind, that if an object does not inherit from <see cref="MarshalByRefObject"/>
    /// it may be costly to copy to the new app domain.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            GetExtension(ExtensionType.NoDomain).Run();
            GetExtension(ExtensionType.SingleDomain).Run();
            GetExtension(ExtensionType.WrappedDomain).Run();
        }

        public enum ExtensionType
        {
            NoDomain,
            SingleDomain,
            WrappedDomain,
        }

        public static IExtension GetExtension(ExtensionType type)
        {
            IExtension BuildExtension<T>(string name)
            {
                var domain = AppDomain.CreateDomain(name, new Evidence());
                return (IExtension)domain.CreateInstanceAndUnwrap(typeof(T).Assembly.FullName, typeof(T).FullName);
            }

            switch (type)
            {
                case ExtensionType.NoDomain:
                    return new Extension();
                case ExtensionType.SingleDomain:
                    return BuildExtension<Extension>("extension1");
                case ExtensionType.WrappedDomain:
                    return BuildExtension<ExtensionWithAppDomain>("extension2");
                default:
                    throw new InvalidOperationException();
            }
        }

        public interface IExtension
        {
            void Run();
        }

        private class Extension : MarshalByRefObject, IExtension
        {
            public void Run()
            {
                try
                {
                    Console.WriteLine($"[{AppDomain.CurrentDomain.FriendlyName}] Evidence count: {AppDomain.CurrentDomain.Evidence.Cast<object>().Count()})");

                    var file = Path.GetTempFileName();

                    using (var document = SpreadsheetDocument.Create(file, SpreadsheetDocumentType.Workbook, true))
                    {
                        // Add a WorkbookPart to the document.
                        var workbookPart = document.AddWorkbookPart();
                        workbookPart.Workbook = new Workbook();

                        // Add a WorksheetPart to the WorkbookPart.
                        var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                        worksheetPart.Worksheet = new Worksheet();
                        var sheets = workbookPart.Workbook.AppendChild(new Sheets());
                        var sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Test Sheet" };
                        sheets.Append(sheet);
                        workbookPart.Workbook.Save();
                    }

                    using (var document = SpreadsheetDocument.Open(file, true))
                    {
                        var worksheetPart = document.WorkbookPart.WorksheetParts.First();
                        var sheetData = worksheetPart.Worksheet.AppendChild(new SheetData());
                        var str = new string('h', (int)10e5);
                        for (uint i = 1; i < 10; i++)
                        {
                            var row = new Row();
                            row.Append(new Cell { CellValue = new CellValue(str) });
                            sheetData.AppendChild(row);
                        }
                    }

                    Console.WriteLine($"[{AppDomain.CurrentDomain.FriendlyName}] Done");
                }
                catch (IsolatedStorageException)
                {
                    Console.WriteLine($"[{AppDomain.CurrentDomain.FriendlyName}] Caught exception");
                }
            }
        }

#pragma warning disable CA1812 // Class is not instantiated. Called via AppDomain.CreateInstanceAndUnwrap
        private class ExtensionWithAppDomain : MarshalByRefObject, IExtension
#pragma warning restore CA1812 // Class is not instantiated. Called via AppDomain.CreateInstanceAndUnwrap
        {
            private readonly IExtension _other;

            public ExtensionWithAppDomain()
            {
                var evidence = new Evidence();
                evidence.AddHostEvidence(new Zone(SecurityZone.MyComputer));

                var domain = AppDomain.CreateDomain($"{AppDomain.CurrentDomain.FriendlyName}_Evidence", evidence);
                _other = (IExtension)domain.CreateInstanceAndUnwrap(typeof(Extension).Assembly.FullName, typeof(Extension).FullName);
            }

            public void Run() => _other.Run();
        }
    }
}
