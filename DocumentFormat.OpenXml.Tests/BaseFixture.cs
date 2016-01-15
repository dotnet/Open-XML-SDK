/*
 * BaseFixture.cs - Base Fixture
 * 
 * Copyright 2014-2015 Thomas Barnekow
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * Developer: Thomas Barnekow
 * Email: thomas<at/>barnekow<dot/>info
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using DocumentFormat.OpenXml.Packaging;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "VirtualMemberNeverOverriden.Global")]
    public class BaseFixture : IDisposable
    {
        protected static string s_TestFileLocation = null;

        public static string TestFilesPath
        {
            get
            {
                if (s_TestFileLocation != null)
                    return s_TestFileLocation;
                // find the directory, wherever it may be, to get to the TestFiles directory
                var dir = new DirectoryInfo(Environment.CurrentDirectory);
                while (true)
                {
                    if (dir.Name == "DocumentFormat.OpenXml.Tests" || dir.Name == "DocumentFormat.OpenXml.WB.Tests")
                        break;
                    dir = dir.Parent;
                }
                dir = dir.Parent; // go up one more, to the parent of the above dirs
                var testDataStorageDirInfo = new DirectoryInfo(Path.Combine(dir.FullName, "TestFiles/"));
                s_TestFileLocation = testDataStorageDirInfo.FullName;
                return s_TestFileLocation;
            }
        }

        protected BaseFixture()
        {
        }

        protected BaseFixture(string directoryPath)
        {
            DirectoryPath = directoryPath;
        }

        /// <summary>
        /// Gets or sets the test fixture's test directory path.
        /// When set, this directory will be emptied upon disposal.
        /// </summary>
        private string DirectoryPath { get; set; }

        /// <summary>
        /// Given the path of a test document, potentially including a directory portion,
        /// produces the path of the document within the TestFiles folder.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        protected static string GetTestFilePath(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");

            var combinedPath = Path.Combine(TestFilesPath, Path.GetFileName(path));
            return combinedPath;
        }

        /// <summary>
        /// Asserts that two OpenXmlPackage instances have the same content.
        /// </summary>
        /// <param name="first">The first OpenXmlPackage</param>
        /// <param name="second">The second OpenXmlPackage</param>
        protected static void AssertThatPackagesAreEqual(OpenXmlPackage first, OpenXmlPackage second)
        {
            var firstParts = first.GetAllParts().ToList();
            var secondParts = second.GetAllParts().ToList();
            Assert.Equal(firstParts.Select(p => p.GetType()), secondParts.Select(p => p.GetType()));

            // Assert that the parts' root elements are equal.
            for (var i = 0; i < firstParts.Count(); i++)
            {
                if (firstParts[i].ContentType.EndsWith("xml"))
                {
                    var firstString = GetXmlString(firstParts[i]); // firstParts[i].GetRootElement().ToString();
                    var secondString = GetXmlString(secondParts[i]); // secondParts[i].GetRootElement().ToString();
                    Assert.Equal(firstString, secondString);
                }
                else
                {
                    byte[] firstByteArray;
                    using (var stream = firstParts[i].GetStream())
                    using (var binaryReader = new BinaryReader(stream))
                    {
                        var len = (int) binaryReader.BaseStream.Length;
                        firstByteArray = binaryReader.ReadBytes(len);
                    }

                    byte[] secondByteArray;
                    using (var stream = secondParts[i].GetStream())
                    using (var binaryReader = new BinaryReader(stream))
                    {
                        var len = (int) binaryReader.BaseStream.Length;
                        secondByteArray = binaryReader.ReadBytes(len);
                    }

                    Assert.Equal(firstByteArray, secondByteArray);
                }
            }
        }

        /// <summary>
        /// Lets the given part's RootElement produce the XML string.
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        protected static string GetXmlString(OpenXmlPart part)
        {
            var sb = new StringBuilder();
            using (var xw = XmlWriter.Create(sb))
            {
                if (part.RootElement != null)
                    part.RootElement.WriteTo(xw);
                else
                    sb.Append(string.Empty);
            }
            return sb.ToString();
        }

        protected static void PreparePresentationDocument(string path)
        {
            using (var document = PresentationDocument.Open(path, true))
            {
                foreach (var part in document.GetAllParts())
                    if (part.RootElement != null)
                        part.RootElement.Save();
            }
        }

        protected static void PrepareSpreadsheetDocument(string path)
        {
            using (var document = SpreadsheetDocument.Open(path, true))
            {
                foreach (var part in document.GetAllParts())
                    if (part.RootElement != null)
                        part.RootElement.Save();
            }
        }

        protected static void PrepareWordprocessingDocument(string path)
        {
            using (var document = WordprocessingDocument.Open(path, true))
            {
                foreach (var part in document.GetAllParts())
                    if (part.RootElement != null)
                        part.RootElement.Save();
            }
        }

        //protected static void RemoveFiles(string path, string searchPattern)
        //{
        //    var directory = new DirectoryInfo(path);
        //    foreach (var file in directory.GetFiles(searchPattern))
        //        file.Delete();
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && DirectoryPath != null)
            {
                Directory.Delete(DirectoryPath, true);
            }
        }
    }

    /// <summary>
    /// Provides selected extension methods for testing purposes.
    /// </summary>
    public static class SelectedExtensions
    {
        /// <summary>
        /// Gets all parts contained in the <see cref="OpenXmlPackage" /> in a
        /// breadth-first fashion, i.e., the direct and indirect relationship
        /// targets of the package (where the <see cref="OpenXmlPartContainer.Parts" />
        /// property only returns the direct relationship targets).
        /// </summary>
        public static IEnumerable<OpenXmlPart> GetAllParts(this OpenXmlPackage package)
        {
            return new OpenXmlParts(package);
        }
    }

    /// <summary>
    /// Enumeration of all parts contained in an <see cref="OpenXmlPackage" />
    /// rather than just the direct relationship targets.
    /// </summary>
    public class OpenXmlParts : IEnumerable<OpenXmlPart>
    {
        private readonly OpenXmlPackage _package;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackagePartIterator class using the supplied OpenXmlPackage class.
        /// </summary>
        /// <param name="package">The OpenXmlPackage to use to enumerate parts</param>
        public OpenXmlParts(OpenXmlPackage package)
        {
            _package = package;
        }

        #endregion

        #region IEnumerable<OpenXmlPart> Members

        /// <summary>
        /// Gets an enumerator for parts in the whole package.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<OpenXmlPart> GetEnumerator()
        {
            var parts = new List<OpenXmlPart>();
            var queue = new Queue<OpenXmlPart>();

            // Enqueue all direct relationship targets.
            foreach (var target in _package.Parts)
            {
                queue.Enqueue(target.OpenXmlPart);
            }

            while (queue.Count > 0)
            {
                // Add next part from queue to the set of parts to be returned.
                var part = queue.Dequeue();
                parts.Add(part);

                // Enqueue all direct relationship targets of current part that
                // are not already enqueued or in the set of parts to be returned.
                foreach (var indirectTarget in part.Parts)
                {
                    if (!queue.Contains(indirectTarget.OpenXmlPart) &&
                        !parts.Contains(indirectTarget.OpenXmlPart))
                    {
                        queue.Enqueue(indirectTarget.OpenXmlPart);
                    }
                }
            }

            // Done.
            return parts.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        /// <summary>
        /// Gets an enumerator for parts in the whole package.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}