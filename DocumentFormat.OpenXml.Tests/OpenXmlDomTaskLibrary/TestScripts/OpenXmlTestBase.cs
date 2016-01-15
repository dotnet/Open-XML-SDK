// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;
using OxTest;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Presentation;

using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;
using LogUtil;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries
{
    /// <summary>
    /// The OpenXmlDom test framework. It contains help methods for testing OpenXmlDom Classes
    /// </summary>
    public class OpenXmlTestBase
    {
        #region Log
        /// <summary>
        /// Log instance. This is initialized whenever before a test method is being initialized
        /// in the TestInitialize event of VS UnitTesting.
        /// </summary>
        public VerifiableLog Log
        {
            get
            {
                if (this.log == null)
                {
                    // Create directory if not exists
                    if (!Directory.Exists(resultPath))
                        Directory.CreateDirectory(resultPath);

                    // New a log instance
                    string description = this.GetType().FullName;
                    this.log = new VerifiableLog(TestContext.TestName, description, resultPath);
                }
                return log;
            }
        }

        private VerifiableLog log = null;
        #endregion Log

        #region Initialize/Cleanup
        public void MyTestInitialize(string currentTest)
        {
            this.TestContext = new TestContext(currentTest);

            // Initialize the list of created result folders
            this.resultFoldersCreated = new List<string>();

            // Reset log file
            this.log = null;

            // Create result root directory if not exists
            if (!Directory.Exists(TestResultsDirectory))
            {
                Directory.CreateDirectory(TestResultsDirectory);
            }

            // Record test start time to summary log
            var summaryLog = this.Log;
            summaryLog.Comment("Test has been started.");

            // Calls overridable logics
            if (this.initialized == false)
            {
                this.TestInitializeOnce();
                this.initialized = true;
            }
            TestInitialize();
        }

        /// <summary>
        /// The method is called once prior to call the first test method.
        /// Use TestInitialize() instead if you need everytime initialization for each test method.
        /// </summary>
        protected virtual void TestInitializeOnce() { }

        /// <summary>
        /// The method is called multiply prior to call each test method.
        /// Use TestInitializeOnce() instead if you need once initialization.
        /// </summary>
        protected virtual void TestInitialize() { }
        protected virtual void TestCleanup() { }

        private bool initialized = false;
        #endregion

        #region TestContext
        /// <summary>
        /// See http://msdn.microsoft.com/ja-jp/library/ms404699%28VS.80%29.aspx
        /// </summary>

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #endregion

        #region TestFiles

        /// <summary>
        /// List of created result folders.
        /// This will basically contains one directory path,
        /// but if test logic specifies sub test name, it could have two or more paths.
        /// </summary>
        private List<string> resultFoldersCreated;

        public string TestClassName
        {
            get
            {
                string testClassName = this.TestContext.FullyQualifiedTestClassName;

                int lastIndexOfNamespace = testClassName.LastIndexOf('.');
                if (lastIndexOfNamespace > 0)
                {
                    return testClassName.Substring(lastIndexOfNamespace + 1);
                }

                return this.TestContext.FullyQualifiedTestClassName;
            }
        }

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
        /// Alias of SourcePath
        /// </summary>
        protected String sourcePath
        {
            get { return this.SourcePath; }
        }

        /// <summary>
        /// Alias of ResultRootPath.
        /// </summary>
        protected String resultPath
        {
            get { return this.ResultPath; }
        }

        public String indexFolder = @"\\no-such-server\bjoffhost12\resultfile\_index";

        /// <summary>
        /// Root of source folder.
        /// </summary>
        public static string SourceRootPath
        {
            get
            {
                if (_SourceRootPath != null)
                    return _SourceRootPath;

                // find the directory, wherever it may be, to get to the TestDataStorage directory
                var dir = new DirectoryInfo(Environment.CurrentDirectory);
                while (true)
                {
                    if (dir.Name == "DocumentFormat.OpenXml.Tests" || dir.Name == "DocumentFormat.OpenXml.WB.Tests")
                        break;
                    dir = dir.Parent;
                }
                dir = dir.Parent; // go up one more, to the parent of the above dirs
                var testDataStorageDirInfo = new DirectoryInfo(Path.Combine(dir.FullName, "TestDataStorage"));
                _SourceRootPath = testDataStorageDirInfo.FullName;
                return _SourceRootPath;
            }
        }
        private static string _SourceRootPath = null;
        protected void SetSourceRootPath(string path)
        {
            _SourceRootPath = path;
        }

        /// <summary>
        /// Source folder.
        /// </summary>
        public string SourcePath
        {
            get
            {
                if (this._SourcePath == null)
                {
                    // find the directory, wherever it may be, to get to the TestDataStorage directory
                    var dir = new DirectoryInfo(Environment.CurrentDirectory);
                    while (true)
                    {
                        if (dir.Name == "DocumentFormat.OpenXml.Tests" || dir.Name == "DocumentFormat.OpenXml.WB.Tests")
                            break;
                        dir = dir.Parent;
                    }
                    dir = dir.Parent; // go up one more, to the parent of the above dirs
                    var testDataStorageDirInfo = new DirectoryInfo(Path.Combine(dir.FullName, "TestDataStorage"));
                    this._SourcePath = testDataStorageDirInfo.FullName;
                    return this._SourcePath;
                }
                return this._SourcePath;
            }
            set
            {
                // Expand the specified relative path based on source root folder
                this._SourcePath = Path.Combine(SourceRootPath, value);
            }
        }
        private String _SourcePath = null;

        /// <summary>
        /// Root of result folder.
        /// Default value is in "[SystemDrive]:\oxmlsdklog\[TestSuiteName]" format
        /// like "C:\oxmlsdklog\OpenXmlValidationTest" etc.
        /// unless the test is executed from test pass script.
        /// Test pass script specifies _OXMLSDKLOG environment variable so that
        /// it becomes the value for this property.
        /// </summary>
        public static string TestResultsDirectory
        {
            get
            {
                return TestUtil.TestResultsDirectory;
            }
        }

        public string ResultPath
        {
            get
            {
                if (this._ResultPath == null)
                {
                    this._ResultPath = TestResultsDirectory;
                }
                return this._ResultPath;
            }
            set
            {
                // Expand the specified relative path based on result root folder
                this._ResultPath = Path.Combine(TestResultsDirectory, value);
            }
        }
        private string _ResultPath = null;

        public string GetTestFilePath(string filename)
        {
            string testFileFolder = Path.Combine(resultPath, this.TestClassName + "_files");
            string testFilePath = Path.Combine(testFileFolder, filename);

            if (Directory.Exists(testFileFolder) == false)
            {
                this.Log.Comment("Create a test file folder : {0}", testFileFolder);
                Directory.CreateDirectory(testFileFolder);
            }

            this.Log.Comment("Test file path: {0}", testFilePath);

            return testFilePath;
        }

        public FileInfo GetSourceFile(FileInfo testFile)
        {
            if (File.Exists("source-" + testFile.Name))
                File.Delete("source-" + testFile.Name);

            return testFile.CopyTo("source-" + testFile.Name);
        }

        public static DriveInfo GetLargestFreeDrive()
        {
            DriveInfo largetstDrive = null;
            long largestSize = 0;

            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                if (driveInfo.IsReady && driveInfo.AvailableFreeSpace > largestSize)
                {
                    largetstDrive = driveInfo;
                    largestSize = driveInfo.AvailableFreeSpace;
                }
            }
            return largetstDrive;
        }

        /// <summary>
        /// Get test files in the test file storage.
        /// </summary>
        /// <param name="sourceFolder">Relative path to source folder.</param>
        /// <param name="recursive">True to search files recursively</param>
        /// <param name="searchPattern">Search pattern of file name. Wildcard chars are allowed.</param>
        /// <param name="pred">Filter function which limits files to be searched.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> GetTestFiles(string sourceFolder)
        {
            string inputPath = Path.Combine(sourcePath, sourceFolder);
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
            string inputPath = Path.Combine(sourcePath, sourceFile);
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
            string searchPattern = "*";
            bool recursive = true;
            Func<FileInfo, bool> pred = IsOpenXmlFile;
            return CopyTestFiles(sourceFolder, recursive, searchPattern, pred);
        }
        private static string[] _wordprocessingExtension = new string[] { ".docx", ".docm", ".dotx", ".dotm" };
        private static string[] _spreadsheetExtension = new string[] { ".xlam", ".xltm", ".xlsm", ".xltx", ".xlsx" };
        private static string[] _presentationExtension = new string[] { ".ppam", ".pptm", ".ppsm", ".potm", ".pptx", ".ppsx", ".potx" };
        private static bool IsOpenXmlFile(FileInfo file)
        {
            return _wordprocessingExtension.Contains(file.Extension.ToLower())
                || _spreadsheetExtension.Contains(file.Extension.ToLower())
                || _presentationExtension.Contains(file.Extension.ToLower());
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
            string searchPattern = "*";
            Func<FileInfo, bool> pred = IsOpenXmlFile;
            return CopyTestFiles(sourceFolder, recursive, searchPattern, pred, maxFiles);
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
            Func<FileInfo, bool> pred = IsOpenXmlFile;
            return CopyTestFiles(sourceFolder, recursive, searchPattern, pred);
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
            string inputPath = Path.Combine(sourcePath, sourceFolder);
            string outputPath = this.CurrentResultFolder;

            // Cd to the outputPath folder
            Environment.CurrentDirectory = outputPath;

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
        /// Copy the test file specified with the sourceFile parameter.
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <returns></returns>
        public FileInfo CopyTestFileOne(string sourceFile)
        {
            var sourceFolder = Path.GetDirectoryName(sourceFile);
            var sourceFileName = Path.GetFileName(sourceFile);
            Func<FileInfo, bool> pred =
                file => file.Name.Equals(sourceFileName, StringComparison.InvariantCultureIgnoreCase);
            return CopyTestFiles(sourceFolder, false, sourceFileName, pred).First();
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
            var resultFolder = this.TestContext.TestName;
            string outputPath = Path.Combine(resultPath, resultFolder);

            // Create folder
            if (!resultFoldersCreated.Contains(outputPath))
            {
                resultFoldersCreated.Add(outputPath);
                CreateResultFolder(outputPath);
            }

            // Return folder path
            return outputPath;
        }

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
                                TestDataStorage.RootFolder, file.FilePath, result.Description) == false)
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
                        TestDataStorage.RootFolder, file.FilePath, e.Message) == false)
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
                    this.log.Pass(string.Format("Verified {0}", entry.FilePath));

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

    /// <summary>
    /// Base class of the test logic classes that are not TestClass that has TestMethod.
    /// </summary>
    public abstract class OpenXmlTestLogicBase
    {
        public OpenXmlTestLogicBase(OpenXmlTestBase testClassInstance)
        {
            this._TestClassInstance = testClassInstance;
        }

        /// <summary>
        /// Test class instance which is specified in the constructor argument.
        /// </summary>
        public OpenXmlTestBase TestClassInstance
        {
            get { return this._TestClassInstance; }
        }
        private OpenXmlTestBase _TestClassInstance = null;

        #region References to TestClassInstance

        /// <summary>
        /// VerifiableLog instance that is of TestClassInstance.
        /// </summary>
        public LogUtil.VerifiableLog Log
        {
            get { return TestClassInstance.Log; }
        }

        public string resultPath
        {
            get { return this.TestClassInstance.ResultPath; }
        }

        public string sourcePath
        {
            get { return this.TestClassInstance.SourcePath; }
        }

        #endregion
    }
}
