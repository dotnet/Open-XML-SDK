// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage
{
    public class TestDataStorage
    {
        private List<ITestDataGroup> dataGroups = new List<ITestDataGroup>();

        public enum DataGroups
        {
            O14IsoStrictWord,
            O14IsoStrictExcel,
            O14IsoStrictPowerPoint,
            O14IsoStrictGraphics,
            O14IsoStrictAdditional,
            O14Validation,
            O15ConformanceWord,
            O15ConformanceExcel,
            O15ConformancePowerPoint,
            O15ConformanceM2,
            O15ConformanceBeta1,
            RobustnessWindowsPhone7,
            RobustnessOFCAT,
            RobustnessLowLevel,
            RobustnessBugRegression,
        }

        private static String m_RootFolder = null;

        public static string RootFolder
        {
            get
            {
                if (m_RootFolder != null)
                    return m_RootFolder;
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
                return testDataStorageDirInfo.FullName;
            }
        }

        public TestDataStorage()
        {
            string rootFolder = RootFolder;

            if (!Directory.Exists(rootFolder))
            {
                throw new ApplicationException("Can't access the root folder of the TestDataStorage at: '" + rootFolder + "'");
            }

            string o14IsoStrictFolder = Path.Combine(rootFolder, @"O14ISOStrict\");
            string o14ValidationFolder = Path.Combine(rootFolder, @"ValidationTestFiles\");
            string o15ConformanceFolder = Path.Combine(rootFolder, @"O15Conformance\");
            string robustnessFolder = Path.Combine(rootFolder, @"Robustness\");
            string lowLevelFolder = Path.Combine(rootFolder, @"SDKLowLevelTestFiles\");

            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O14IsoStrictWord.ToString(),
                    "Wordprocessing Files in ISO Strict",
                    o14IsoStrictFolder + @"Word\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O14IsoStrictExcel.ToString(),
                    "SpreadsheetML Files in ISO Strict",
                    o14IsoStrictFolder + @"Excel\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O14IsoStrictPowerPoint.ToString(),
                    "PresentationML Files in ISO Strict",
                    o14IsoStrictFolder + @"PowerPoint\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O14IsoStrictGraphics.ToString(),
                    "DrawingML Files in ISO Strict",
                    o14IsoStrictFolder + @"Graphics\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O14IsoStrictAdditional.ToString(),
                    "Additional Test Files in ISO Strict",
                    o14IsoStrictFolder + @"AdditionalFiles\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O14Validation.ToString(),
                    "O14 Validation Test Files",
                    o14ValidationFolder));

            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O15ConformanceWord.ToString(),
                    "O15 Conformance WordprocessingML Test Files",
                    o15ConformanceFolder + @"WD\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O15ConformanceExcel.ToString(),
                    "O15 Conformance SpreadsheetML Test Files",
                    o15ConformanceFolder + @"XL\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O15ConformancePowerPoint.ToString(),
                    "O15 Conformance PresentationML Test Files",
                    o15ConformanceFolder + @"PPT\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O15ConformanceM2.ToString(),
                    "O15 Conformance M2 Converted Test Files",
                    o15ConformanceFolder + @"M2\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.O15ConformanceBeta1.ToString(),
                    "O15 Conformance Beta1 Converted Test Files",
                    o15ConformanceFolder + @"Beta1\"));

            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.RobustnessOFCAT.ToString(),
                    "Various Test Files created by non-Office products",
                    robustnessFolder + @"OFCAT\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.RobustnessWindowsPhone7.ToString(),
                    "Various Test Files created by non-Office products",
                    robustnessFolder + @"WP7\"));
            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.RobustnessBugRegression.ToString(),
                    "Various Test Files created by non-Office products",
                    robustnessFolder + @"BugRegression\"));

            this.RegisterDataGroup(
                new FileDataGroup(
                    DataGroups.RobustnessLowLevel.ToString(),
                    "Test Files mostly cover DOM elements",
                    lowLevelFolder));
        }

        public List<ITestData> GetEntries(DataGroups dataGroup, string fileMatch)
        {
            return this.GetEntries(dataGroup.ToString(), fileMatch);
        }

            public List<ITestData> GetEntries(string groupPattern, string fileMatch)
        {
            try
            {
                Regex fileMatchPattern = new Regex(fileMatch);
                var matchedEntries = from f in this.GetEntries(groupPattern)
                                     where fileMatchPattern.IsMatch(f.FilePath) == true
                                     select f;

                return matchedEntries.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<ITestData> GetEntries(DataGroups dataGroup)
        {
            return this.GetEntries(dataGroup.ToString());
        }

        public List<ITestData> GetEntries(string groupPattern)
        {
            List<ITestData> results = new List<ITestData>();

            try
            {
                Regex idPattern = new Regex(groupPattern);
                var matchedGroups = from dg in this.dataGroups
                                    where idPattern.IsMatch(dg.ID) == true
                                    select dg;
                foreach (var group in matchedGroups)
                {
                    results.AddRange(group.GetEntries());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return results;
        }

        #region Support Methods
        public void RegisterDataGroup(ITestDataGroup group)
        {
            this.dataGroups.Add(group);
        }
        #endregion
    }
}
