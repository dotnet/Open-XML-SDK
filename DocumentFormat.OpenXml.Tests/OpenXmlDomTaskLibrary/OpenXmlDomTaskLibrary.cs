// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries
{
    public class OpenXmlDomTaskLibrary
    {

        private static Dictionary<String, Regex> pathMatches = new Dictionary<String, Regex>();
        private static Dictionary<String, Regex> messageMatches = new Dictionary<String, Regex>();

        private static Regex getCachedRegex(String key, Dictionary<String, Regex> table)
        {
            if (false == table.ContainsKey(key))
            {
                try
                {
                    table.Add(key, new Regex(key, RegexOptions.Compiled));
                }
                catch (ArgumentException ae)
                {
                    if (!ae.Message.Contains("An item with the same key has already been added."))
                        throw ae;
                }
                return table[key];
            }
            else
            {
                return table[key];
            }
        }

        private static XmlDocument s_SafeListXDoc = null;
        private static XmlNodeList safeItems = null;

        public static bool IsKnownIssue(string safeListPath, string filePath, string errorMessage)
        {
            string safeListFilePath = Path.Combine(safeListPath, "SafeList.xml");

            if (File.Exists(safeListFilePath) == true)
            {
                if (s_SafeListXDoc == null)
                {
                    s_SafeListXDoc = new XmlDocument();
                    s_SafeListXDoc.Load(safeListFilePath);
                    safeItems = s_SafeListXDoc.GetElementsByTagName("item");
                }

                foreach (XmlNode safeItem in safeItems)
                {
                    // using ToUpper, so that I can avoid RegexOptions.IgnoreCase
                    //if (getCachedRegex(safeItem.Attributes["pathMatch"].Value.ToUpper(), pathMatches).IsMatch(filePath.ToUpper()))
                    var pathMatch = safeItem.Attributes["pathMatch"].Value.ToUpper();
                    var upperName = filePath.ToUpper();
                    if (getCachedRegex(pathMatch, pathMatches).IsMatch(upperName))
                    {
                        if (getCachedRegex(safeItem.Attributes["errMatch"].Value.ToUpper(), pathMatches).IsMatch(errorMessage.ToUpper()))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                throw new FileNotFoundException("SaveList.xml file not found");
            }
        }
    }
}
