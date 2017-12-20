// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
            return CopyTestFiles(sourceFolder, true, "*", FileExtensions.IsOpenXmlFile);
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
            return CopyTestFiles(sourceFolder, recursive, "*", FileExtensions.IsOpenXmlFile, maxFiles);
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
            if (pred == null) { pred = file => { return true; }; }

            // Copy sourcefiles to output as testfiles
            var inputDirItem = new DirectoryInfo(inputPath);
            var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
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
    }
}
