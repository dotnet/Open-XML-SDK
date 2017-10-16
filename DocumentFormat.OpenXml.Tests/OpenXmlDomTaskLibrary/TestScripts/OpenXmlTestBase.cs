﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;
using DocumentFormat.OpenXml.Validation;
using LogUtil;
using OxTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries
{
    /// <summary>
    /// The OpenXmlDom test framework. It contains help methods for testing OpenXmlDom Classes
    /// </summary>
    public class OpenXmlTestBase
    {
        protected OpenXmlTestBase(ITestOutputHelper output, string path = null)
        {
            Log = new VerifiableLog(output);

            if (path == null)
            {
                SourcePath = TestUtil.TestDataStorage;
            }
            else
            {
                SourcePath = Path.Combine(TestUtil.TestDataStorage, path);
            }
        }

        protected VerifiableLog Log { get; }

        #region TestFiles
        /// <summary>
        /// Get current result folder path.
        /// If result folder is not yet created, create it and return the path.
        /// </summary>
        public string CurrentResultFolder
        {
            get
            {
                if (this.currentResultFolder == null)
                {
                    this.currentResultFolder = CreateResultFolder();
                }
                return this.currentResultFolder;
            }
        }

        private string currentResultFolder;

        /// <summary>
        /// Root of source folder.
        /// </summary>
        public static string SourceRootPath { get; } = TestUtil.TestDataStorage;

        /// <summary>
        /// Source folder.
        /// </summary>
        public string SourcePath { get; }

        /// <summary>
        /// Root of result folder.
        /// Default value is in "[SystemDrive]:\oxmlsdklog\[TestSuiteName]" format
        /// like "C:\oxmlsdklog\OpenXmlValidationTest" etc.
        /// unless the test is executed from test pass script.
        /// Test pass script specifies _OXMLSDKLOG environment variable so that
        /// it becomes the value for this property.
        /// </summary>
        public static string TestResultsDirectory { get; } = TestUtil.TestResultsDirectory;

        public string ResultPath { get; } = TestResultsDirectory;

        public string GetTestFilePath(string filename)
        {
            string testFileFolder = Path.Combine(ResultPath, this.TestClassName + "_files");
            string testFilePath = Path.Combine(testFileFolder, filename);

            if (Directory.Exists(testFileFolder) == false)
            {
                this.Log.Comment("Create a test file folder : {0}", testFileFolder);
                Directory.CreateDirectory(testFileFolder);
            }

            this.Log.Comment("Test file path: {0}", testFilePath);

            return testFilePath;
        }

        /// <summary>
        /// Get test files in the test file storage.
        /// </summary>
        /// <param name="sourceFolder">Relative path to source folder.</param>
        /// <param name="recursive">True to search files recursively</param>
        /// <param name="searchPattern">Search pattern of file name. Wildcard chars are allowed.</param>
        /// <param name="pred">Filter function which limits files to be searched.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> GetTestFiles(string sourceFolder, string subFolder)
        {
            string inputPath = Path.Combine(SourcePath, sourceFolder, subFolder);
            return new DirectoryInfo(inputPath).GetFiles("*", SearchOption.AllDirectories);
        }

        /// <summary>
        /// Get the specified test file in the test file storage.
        /// </summary>
        /// <param name="sourceFile">File name you want to get.
        /// This can be a relative path from the source folder.</param>
        /// <returns></returns>
        public FileInfo GetTestFileOne(string sourceFile)
        {
            string inputPath = Path.Combine(SourcePath, sourceFile);
            return new FileInfo(inputPath);
        }

        /// <summary>
        /// Copy test files to result folder.
        /// </summary>
        /// <param name="sourceFolder">Relative path to source folder.</param>
        /// <param name="recursive">True to search files recursively</param>
        /// <param name="searchPattern">Search pattern of file name. Wildcard chars are allowed.</param>
        /// <param name="pred">Filter function which limits files to be copied.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> CopyTestFiles(string sourceFolder)
        {
            return CopyTestFiles(sourceFolder, true, "*", OpenXmlDomTestExtension.IsOpenXmlFile);
        }

        public IEnumerable<FileInfo> CopyTestFiles(string sourceFolder, string subFolder)
        {
            return CopyTestFiles(Path.Combine(sourceFolder, subFolder));
        }

        /// <summary>
        /// Copy test files to result folder.
        /// </summary>
        /// <param name="sourceFolder">Relative path to source folder.</param>
        /// <param name="recursive">True to search files recursively</param>
        /// <param name="searchPattern">Search pattern of file name. Wildcard chars are allowed.</param>
        /// <param name="pred">Filter function which limits files to be copied.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> CopyTestFiles(string sourceFolder, bool recursive, int? maxFiles = null)
        {
            return CopyTestFiles(sourceFolder, recursive, "*", OpenXmlDomTestExtension.IsOpenXmlFile, maxFiles);
        }

        /// <summary>
        /// Copy test files to result folder.
        /// </summary>
        /// <param name="sourceFolder">Relative path to source folder.</param>
        /// <param name="recursive">True to search files recursively</param>
        /// <param name="searchPattern">Search pattern of file name. Wildcard chars are allowed.</param>
        /// <param name="pred">Filter function which limits files to be copied.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> CopyTestFiles(string sourceFolder, bool recursive, string searchPattern)
        {
            return CopyTestFiles(sourceFolder, recursive, searchPattern, OpenXmlDomTestExtension.IsOpenXmlFile);
        }

        /// <summary>
        /// Copy test files to result folder.
        /// </summary>
        /// <param name="sourceFolder">Relative path to source folder.</param>
        /// <param name="recursive">True to search files recursively</param>
        /// <param name="searchPattern">Search pattern of file name. Wildcard chars are allowed.</param>
        /// <param name="pred">Filter function which limits files to be copied.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> CopyTestFiles(string sourceFolder, bool recursive, string searchPattern, Func<FileInfo, bool> pred, int? maxFiles = null)
        {
            string inputPath = Path.Combine(SourcePath, sourceFolder);
            string outputPath = this.CurrentResultFolder;

            // Cd to the outputPath folder
            Directory.SetCurrentDirectory(outputPath);

            // Ensure pred is not null
            if (pred == null) { pred = (file => { return true; }); }

            // Copy sourcefiles to output as testfiles
            var inputDirItem = new DirectoryInfo(inputPath);
            var searchOption = (recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            var sourcefiles = inputDirItem.GetFiles(searchPattern, searchOption).Where(pred);
            if (maxFiles != null)
                sourcefiles = sourcefiles.Take((int)maxFiles);

            // Create return value's instance
            var retFiles = new List<FileInfo>();

            // Copy all files searched to result folder
            foreach (var file in sourcefiles)
            {
                // Calculate destination file path
                string destfile = System.IO.Path.Combine(outputPath, file.Name);

                // Create target directory if not exists
                if (!Directory.Exists(Path.GetDirectoryName(destfile)))
                    Directory.CreateDirectory(Path.GetDirectoryName(destfile));

                if (!File.Exists(destfile))
                {
                    // Copy the file
                    retFiles.Add(file.CopyTo(destfile, true));
                }
            }

            // Return list of copied files
            return retFiles;
        }

        /// <summary>
        /// Helper method to create result folder.
        /// </summary>
        /// <param name="outputPath"></param>
        protected static void CreateResultFolder(string outputPath)
        {
            OpenXmlTestBase.DeleteFolder(outputPath);
            Directory.CreateDirectory(outputPath);
        }

        /// <summary>
        /// Helper method to delete a folder recursively whatever it contains any files or directories
        /// </summary>
        /// <param name="path">Target directory path</param>
        public static void DeleteFolder(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (var file in new DirectoryInfo(path).GetFiles("*", SearchOption.AllDirectories))
                {
                    if (file.IsReadOnly)
                        file.Attributes = FileAttributes.Normal;
                }
                Directory.Delete(path, true);
            }
        }

        /// <summary>
        /// Helper method to create result folder corresponding to current test name.
        /// If already created, just return the result folder path.
        /// Otherwise, create the folder and return its path.
        /// </summary>
        /// <returns>Path of the result folder.</returns>
        private string CreateResultFolder()
        {
            // Caculate result folder path
            var resultFolder = this.TestClassName;
            string outputPath = Path.Combine(ResultPath, resultFolder);

            CreateResultFolder(outputPath);

            // Return folder path
            return outputPath;
        }

        // TODO: Remove this
        protected string TestClassName { get; } = Guid.NewGuid().ToString();

        #endregion TestFiles

        #region Validation Helpers
        public void ValidateDocuments(OpenXmlValidator validator, IEnumerable<ITestData> entries)
        {
            foreach (var file in entries)
            {
                Log.Comment("Open: {0}", file.FilePath);
                bool errorDetected = false;

                try
                {
                    using (var doc = this.OpenDocument(file, false))
                    {
                        var validateResults = validator.Validate(doc);

                        foreach (var result in validateResults)
                        {
                            if (OpenXmlDomTaskLibrary.IsKnownIssue(
                                TestUtil.TestDataStorage, file.FilePath, result.Description) == false)
                            {
                                errorDetected = true;
                                Log.Fail("Validation Error: {0}", result.Description);
                            }
                            else
                            {
                                Log.Warning("Known Issue: {0}", result.Description);
                            }
                        }
                    }

                    Log.VerifyFalse(errorDetected, "Validation passed: " + file.FilePath);
                }
                catch (Exception e)
                {
                    if (OpenXmlDomTaskLibrary.IsKnownIssue(
                        TestUtil.TestDataStorage, file.FilePath, e.Message) == false)
                    {
                        errorDetected = true;
                        Log.Fail("Exception: {0}", e.Message);
                    }
                    else
                    {
                        Log.Warning("Known Exception: {0}", e.Message);
                    }
                }
            }
        }

        public OpenXmlPackage OpenDocument(ITestData entry, bool isEditable)
        {
            switch (entry.Type)
            {
                case FileType.Word:
                    return WordprocessingDocument.Open(entry.FilePath, isEditable);
                case FileType.Excel:
                    return SpreadsheetDocument.Open(entry.FilePath, isEditable);
                case FileType.PowerPoint:
                    return PresentationDocument.Open(entry.FilePath, isEditable);
                default:
                    return null;
            }
        }
        #endregion

        #region Element Usage Parser
        public void AnalyzeElementUsage(IEnumerable<ITestData> entries)
        {
            foreach (var entry in entries)
            {
                this.Log.Comment("Open: {0}", entry.FilePath);
                System.Diagnostics.Debug.WriteLine("Open: {0}", entry.FilePath);

                using (var doc = this.OpenDocument(entry, false))
                {
                    this.AnalyzeElementUsage(doc);
                    Log.Pass(string.Format("Verified {0}", entry.FilePath));

                    foreach (var e in this.elementUsageInPackage)
                    {
                        this.Log.Comment("ElementInPackage: {0}", e);
                    }
                }
            }

            this.Log.Comment("Total Element Usage:");
            foreach (var e in this.AnalizedElementUsage)
            {
                this.Log.Comment("Element: {0}", e);
            }
        }

        public void AnalyzeElementUsage(OpenXmlPackage package)
        {
            this.parsedParts.Clear();
            this.elementUsageInPackage.Clear();

            foreach (var id in package.Parts)
            {
                this.AnalyzeElementUsage(id.OpenXmlPart);
            }
        }

        private void AnalyzeElementUsage(OpenXmlElement element)
        {
            if (element != null)
            {
                this.UpdateElementUsage(element);

                foreach (var childElement in element.Descendants())
                {
                    this.UpdateElementUsage(childElement);
                }
            }
        }

        private void UpdateElementUsage(OpenXmlElement element)
        {
            string elementType = element.GetType().FullName;

            if (this.elementUsage.Contains(elementType) == false)
            {
                this.elementUsage.Add(elementType);
            }
            if (this.elementUsageInPackage.Contains(elementType) == false)
            {
                this.elementUsageInPackage.Add(elementType);
            }
        }

        private void AnalyzeElementUsage(OpenXmlPart part)
        {
            if (this.parsedParts.Contains(part.Uri.ToString()) == true)
            {
                return;
            }
            this.parsedParts.Add(part.Uri.ToString());

            foreach (var id in part.Parts)
            {
                OpenXmlReader reader = null;

                try
                {
                    reader = OpenXmlDomReader.Create(id.OpenXmlPart);
                }
                catch
                {
                    // Skips unread parts such as embedded font
                }

                if (reader != null)
                {
                    while (reader.Read() == true)
                    {
                        if (reader.IsStartElement == true)
                        {
                            OpenXmlElement element = reader.LoadCurrentElement();
                            this.AnalyzeElementUsage(element);
                        }
                    }
                }

                this.AnalyzeElementUsage(id.OpenXmlPart);
            }
        }

        public List<string> AnalizedElementUsage
        {
            get
            {
                return this.elementUsage;
            }
        }

        private List<string> elementUsage = new List<string>();
        private List<string> elementUsageInPackage = new List<string>();
        private List<string> parsedParts = new List<string>();
        #endregion
    }
}
