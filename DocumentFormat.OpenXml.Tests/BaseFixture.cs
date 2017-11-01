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

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class BaseFixture
    {
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
                    var firstString = firstParts[i].GetXmlString();
                    var secondString = secondParts[i].GetXmlString();

                    Assert.Equal(firstString, secondString);
                }
                else
                {
                    byte[] firstByteArray;
                    using (var stream = firstParts[i].GetStream())
                    using (var binaryReader = new BinaryReader(stream))
                    {
                        var len = (int)binaryReader.BaseStream.Length;
                        firstByteArray = binaryReader.ReadBytes(len);
                    }

                    byte[] secondByteArray;
                    using (var stream = secondParts[i].GetStream())
                    using (var binaryReader = new BinaryReader(stream))
                    {
                        var len = (int)binaryReader.BaseStream.Length;
                        secondByteArray = binaryReader.ReadBytes(len);
                    }

                    Assert.Equal(firstByteArray, secondByteArray);
                }
            }
        }
    }
}
