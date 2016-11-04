using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxTest
{
    public class TestUtil
    {
        private static DirectoryInfo s_TestFilesDir = null;

        public static string TestFilesDir
        {
            get
            {
                if (s_TestFilesDir != null)
                    return s_TestFilesDir.FullName;
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
                s_TestFilesDir = testDataStorageDirInfo;
                return s_TestFilesDir.FullName;
            }
        }

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
                    return s_TempDir.FullName;
                else
                {
                    var now = DateTime.Now;
                    var tempDirName = String.Format("TestResults-{0:00}-{1:00}-{2:00}-{3:00}{4:00}{5:00}", now.Year - 2000, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                    s_TempDir = new DirectoryInfo(Path.Combine(".", tempDirName));
                    s_TempDir.Create();
                    return s_TempDir.FullName;
                }
            }
        }
    }
}
