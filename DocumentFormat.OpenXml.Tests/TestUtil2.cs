// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Reflection;

namespace OxTest
{
    public static class TestUtil
    {
        public static string RootFolder => Path.GetDirectoryName(typeof(TestUtil).GetTypeInfo().Assembly.Location);

        public static string TestDataStorage => Path.Combine(RootFolder, "Assets", "TestDataStorage");

        private static bool? s_DeleteTempFiles = null;

        public static bool DeleteTempFiles
        {
            get
            {
                if (s_DeleteTempFiles != null)
                    return (bool)s_DeleteTempFiles;
                FileInfo donotdelete = new FileInfo("donotdelete.txt");
                s_DeleteTempFiles = !donotdelete.Exists;
                return (bool)s_DeleteTempFiles;
            }
        }

        private static DirectoryInfo s_TempDir = null;

        public static string TestResultsDirectory
        {
            get
            {
                if (s_TempDir != null)
                {
                    return s_TempDir.FullName;
                }
                else
                {
                    s_TempDir = new DirectoryInfo(Path.Combine(RootFolder, "results", Guid.NewGuid().ToString()));
                    s_TempDir.Create();
                    return s_TempDir.FullName;
                }
            }
        }
    }
}
