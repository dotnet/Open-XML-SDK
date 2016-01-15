// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Validation;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Presentation;
    using DocumentFormat.OpenXml.Spreadsheet;
    using DocumentFormat.OpenXml.Wordprocessing;

    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;

    /// <summary>
    /// Test for ISO Strict fileformat on Open XML SDK
    /// </summary>
    public class IsoStrictTest : OpenXmlTestBase
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public IsoStrictTest()
        {
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Office15TCM: 41257: OOXML SDK: ISO Strict Namespace / Relationship Mapping - Readability (WordprocessingML)
        /// </summary>
        [Fact]
        public void TestISOStrictNamespaceWordprocessingML()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O14IsoStrictWord);

            foreach (var entry in entries.Take(5))
            {
                this.Verify(entry);
            }
        }

        /// <summary>
        /// Office15TCM: 41262: OOXML SDK: ISO Strict Namespace / Relationship Mapping - Readability (PresentationML)
        /// </summary>
        [Fact]
        public void TestISOStrictNamespacePresentationML()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O14IsoStrictPowerPoint);

            foreach (var entry in entries.Take(5))
            {
                this.Verify(entry);
            }
        }

        /// <summary>
        /// Office15TCM: 41265: OOXML SDK: File Validation - OOXML ISO Strict Files (SpreadsheetML)
        /// </summary>
        [Fact]
        public void ValidateISOStrictNamespaceSpreadsheetML()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O14IsoStrictExcel).Take(10);

            foreach (var entry in entries)
            {
                this.VerifyValidation(entry, FileFormatVersions.Office2010);
            }
        }

        /// <summary>
        /// Office15TCM: 41266: OOXML SDK: File Validation - OOXML ISO Strict Files (PresentationML)
        /// </summary>
        [Fact]
        public void ValidateISOStrictNamespacePresentationML()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O14IsoStrictPowerPoint).Take(50);

            foreach (var entry in entries)
            {
                this.VerifyValidation(entry, FileFormatVersions.Office2010);
            }
        }

        /// <summary>
        /// Office15TCM: 41263: OOXML SDK: File Validation - OOXML ISO Strict Files (DrawingML)
        /// </summary>
        [Fact]
        public void ValidateISOStrictNamespaceDrawingML()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O14IsoStrictGraphics).Take(50);

            foreach (var entry in entries)
            {
                this.VerifyValidation(entry, FileFormatVersions.Office2010);
            }
        }

        /// <summary>
        /// Office15TCM: 41258: OOXML SDK: File Validation - OOXML ISO Strict Files (WordprocessingML)
        /// </summary>
        [Fact]
        public void ValidateISOStrictNamespaceWordprocessingML()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O14IsoStrictWord).Take(50);

            foreach (var entry in entries)
            {
                this.VerifyValidation(entry, FileFormatVersions.Office2010);
            }
        }
        #endregion

        #region Helper Functions
        private void Verify(ITestData entry)
        {
            using (var document = this.OpenPackage(entry, false))
            {
                if (this.IsIsoStrictFile(document) == true)
                {
                    this.Log.Pass("Opened: {0}", entry.FilePath);
                }
            }
        }

        /// <summary>
        /// Validate OOXML File with specified file format version
        /// </summary>
        /// <param name="entry">ITestData entry for OOXML File</param>
        /// <param name="fileFormatVersion">File Format Version</param>
        private void VerifyValidation(ITestData entry, FileFormatVersions fileFormatVersion)
        {

            using (var document = this.OpenPackage(entry, false))
            {
                OpenXmlValidator isoValidator = new OpenXmlValidator(fileFormatVersion);
                var errorList = isoValidator.Validate(document);
            }
        }

        /// <summary>
        /// Verifying Mapping Table
        /// </summary>
        /// <param name="dictionary">Dictionary object for code</param>
        /// <param name="fileName">File Name for csv file to compare</param>
        private void VerifyMappingTable(Dictionary<string, string> dictionary, string fileName)
        {
            // Creat a sorted dictionary instance from the dictionary object for the mapping table b/w Transtional and ISO Strict
            SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>(dictionary);

            Microsoft.VisualBasic.FileIO.TextFieldParser textFieldParser =
                new Microsoft.VisualBasic.FileIO.TextFieldParser(fileName, System.Text.Encoding.GetEncoding(1252))
                {
                    TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited,
                    Delimiters = new string[] { "," },
                    HasFieldsEnclosedInQuotes = true,
                    TrimWhiteSpace = true,
                };

            // Skip Title raw
            textFieldParser.ReadLine();

            // variable for the number of items in csv file
            int items = 0;

            while (!textFieldParser.EndOfData)
            {
                // fields[0]: Transtional Namespace/Relationship, fields[1]: ISO Strict Namespace/Relationship
                string[] fields = textFieldParser.ReadFields();

                // variable for value
                string value = null;

                // Get a value based on the key specified 
                if (sortedDictionary.TryGetValue(fields[1], out value))
                {
                    this.Log.VerifyValue(value, fields[0], "Verifying namespace/relationship values... Mapping Table (Code) = {0}, Mapping Table (CSV) = {1}", value, fields[0]);
                }
                else
                {
                    this.Log.Fail("Missmatched! URI for Transitional doesn't exist in the dictionary. Transitional = {0}, ISO Strict = {1}", fields[0], fields[1]);
                }

                items++;
            }

            if (sortedDictionary.Count != items)
            {
                Console.WriteLine("There might be missing items in the dictionary. Item Count (Code) = {0}, Item Count (CSV) = {1}", sortedDictionary.Count, items);
            }

            textFieldParser.Close();
        }

        /// <summary>
        /// Opens given Open XML File and returns instance of the package
        /// </summary>
        /// <param name="entry">Test data entry</param>
        /// <param name="editable">Opens the file editable</param>
        /// <returns>Instance of the package</returns>
        private OpenXmlPackage OpenPackage(ITestData entry, bool editable)
        {
            OpenXmlPackage package = null;
            string localPath = entry.FilePath;
            this.Log.Comment("Opening ... {0}", localPath);

            if (File.Exists(localPath) == false)
            {
                this.Log.Warning("Skiped...");
                return package;
            }

            switch (entry.Type)
            {
                case FileType.Word:
                    package = WordprocessingDocument.Open(entry.FilePath, editable);
                    break;
                case FileType.PowerPoint:
                    package = PresentationDocument.Open(entry.FilePath, editable);
                    break;
                case FileType.Excel:
                    package = SpreadsheetDocument.Open(entry.FilePath, editable);
                    break;
            }

            return package;
        }

        /// <summary>
        /// Checks if SDK recognizes OOXML Iso Strict file when opening
        /// </summary>
        /// <param name="package">OOXML Documents to verify</param>
        /// <returns></returns>
        private bool IsIsoStrictFile(OpenXmlPackage package)
        {
            // StrictTranslation is an internal property that indicates which file format of OOXML file is opened, Transitional (false) or Strict (true)
            PropertyInfo propertyInfo = package.GetType().GetProperty("StrictTranslation", BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.Instance);

            return (bool)propertyInfo.GetValue(package, null);
        }

        /// <summary>
        /// Get the Dictionary object that contain the mapping table for Namespace/Relationship between Transtional and ISO Strict
        /// </summary>
        /// <returns>Dictionaty object for the mapping table</returns>
        private Dictionary<string, string> GetIsoStrictNamespaceMappingTable()
        {
            // Get DocumentFormat.OpenXml assembly instance
            Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.Contains("DocumentFormat.OpenXml")).FirstOrDefault();

            // _nanespaceTranslationDic is a dictionary that stores Transtional/ISO Strict Namespace/Relationship information
            FieldInfo fieldInfo = assembly.GetTypes().Where(x => x.Name == "NamespaceIdMap").FirstOrDefault().GetField("_namespaceTranslationDic", BindingFlags.NonPublic | BindingFlags.Static);

            // Retrun the dictionary object that stores Transtional/ISO Strict Namespace/Relationship information
            return (Dictionary<string, string>)fieldInfo.GetValue(assembly.GetType("NamespaceIdMap"));
        }
        #endregion
    }
}
