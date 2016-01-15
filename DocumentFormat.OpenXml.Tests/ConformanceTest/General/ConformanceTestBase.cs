// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DocumentFormat.OpenXml.Tests
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;

    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;

    public abstract class ConformanceTestBase<TReflectedCode, TPackage, TElement> : OpenXmlTestBase
        where TElement : OpenXmlElement
        where TPackage : OpenXmlPackage
    {
        private readonly string baseFileName = "Base";
        private readonly string editedFileName = "Edited";

        #region Test Settings
        protected string PackageExtension
        {
            get
            {
                Type type = typeof(TPackage);

                if (type == typeof(WordprocessingDocument))
                {
                    return ".docx";
                }
                if (type == typeof(PresentationDocument))
                {
                    return ".pptx";
                }
                if (type == typeof(SpreadsheetDocument))
                {
                    return ".xlsx";
                }
                return ".unknown";
            }
        }

        protected string BaseFileName
        {
            get { return this.baseFileName + this.PackageExtension; }
        }

        protected string ModifiedFileName
        {
            get { return this.editedFileName + this.PackageExtension; }
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ConformanceTestBase()
        {
        }

        /// <summary>
        /// Creates a base Word file for the tests.
        /// </summary>
        protected override void TestInitializeOnce()
        {
            // Creates the test document
            this.CreatePackage(this.GetTestFilePath(this.BaseFileName));
        }
        #endregion

        #region Preset Tests
        protected delegate void ElementHandler(TElement element);

        protected void SimpleReadWriteTest(ElementHandler preTest, ElementHandler update, ElementHandler postTest)
        {
            string originalFilePath = this.GetTestFilePath(this.BaseFileName);
            string modifiedFilePath = this.GetTestFilePath(this.ModifiedFileName);

            System.IO.File.Copy(originalFilePath, modifiedFilePath, true);
            this.Log.Comment("File copy [{0}] to [{1}]", originalFilePath, modifiedFilePath);

            using (var package = this.OpenDocument(modifiedFilePath, true))
            {
                var elements = this.GetElements(package);

                preTest(elements.First<TElement>());
                update(elements.First<TElement>());
            }

            this.Log.Pass("Updated the element on [{0}].", modifiedFilePath);

            using (var package = this.OpenDocument(modifiedFilePath, false))
            {
                var elements = this.GetElements(package);

                postTest(elements.First<TElement>());
            }

        }
        #endregion

        #region Package Operators
        /// <summary>
        /// Creates test file
        /// </summary>
        /// <param name="createFilePath">file path to create</param>
        protected void CreatePackage(string path)
        {
            Type reflectedCode = typeof(TReflectedCode);
            object documentGenerator = Activator.CreateInstance(reflectedCode);
            var createPackageMethod = reflectedCode.GetMethod("CreatePackage");
            createPackageMethod.Invoke(documentGenerator, new object[] { path });

            this.Log.Pass("Document generated. path=[{0}]", path);
        }

        /// <summary>
        /// Opens an existing document
        /// </summary>
        /// <param name="path">file path to open</param>
        /// <param name="enableEdit">open the file in writable mode</param>
        /// <returns>document package</returns>
        protected OpenXmlPackage OpenDocument(string path, bool enableEdit)
        {
            OpenXmlPackage package = null;

            OpenSettings settings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(
                        MarkupCompatibilityProcessMode.ProcessAllParts,
                        DocumentFormat.OpenXml.FileFormatVersions.Office2013)
                };

            Type type = typeof(TPackage);

            if (type == typeof(WordprocessingDocument))
            {
                package = WordprocessingDocument.Open(path, enableEdit, settings);
            }
            else if (type == typeof(PresentationDocument))
            {
                package = PresentationDocument.Open(path, enableEdit, settings);
            }
            else if (type == typeof(SpreadsheetDocument))
            {
                package = SpreadsheetDocument.Open(path, enableEdit, settings);
            }

            this.Log.Pass("Opened test document {0}", path);

            return package;
        }
        #endregion

        #region Element Operators
        /// <summary>
        /// Obtains elements in a documet package
        /// </summary>
        /// <typeparam name="TElement">Element type</typeparam>
        /// <param name="package">Target document</param>
        /// <returns>Found elements</returns>
        protected IEnumerable<TElement> GetElements(OpenXmlPackage package)
        {
            List<TElement> elements = new List<TElement>();

            WordprocessingDocument wordprocessing = package as WordprocessingDocument;
            PresentationDocument presentation = package as PresentationDocument;
            SpreadsheetDocument spreadsheet = package as SpreadsheetDocument;

            if (wordprocessing != null)
            {
                elements.AddRange(wordprocessing.MainDocumentPart.Document.Descendants<TElement>());
            }
            else if (presentation != null)
            {
                foreach (var slidePart in presentation.PresentationPart.SlideParts)
                {
                    elements.AddRange(slidePart.Slide.Descendants<TElement>());
                }
            }
            else if (spreadsheet != null)
            {
                foreach (var sheet in spreadsheet.WorkbookPart.Workbook.Sheets)
                {
                    elements.AddRange(sheet.Descendants<TElement>());
                }
            }

            this.Log.VerifyTrue(
                elements.Count > 0,
                string.Format(
                    "Elements [{0}] are detected in [{1}]",
                    typeof(TElement).ToString(),
                    package.Package.PackageProperties.Title));

            return elements;
        }
        #endregion
    }
}
