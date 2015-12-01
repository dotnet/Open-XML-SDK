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
                table.Add(key, new Regex(key, RegexOptions.Compiled));
                return table[key];
            }
            else
            {
                return table[key];
            }
        }


        public static bool IsKnownIssue(string safeListPath, string filePath, string errorMessage)
        {
            string safeListFilePath = Path.Combine(safeListPath, "SafeList.xml");

            if (File.Exists(safeListFilePath) == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(safeListFilePath);

                XmlNodeList safeItems = doc.GetElementsByTagName("item");
                foreach (XmlNode safeItem in safeItems)
                {
                    // using ToUpper, so that I can avoid RegexOptions.IgnoreCase
                    if (getCachedRegex(safeItem.Attributes["pathMatch"].Value.ToUpper(), pathMatches).IsMatch(filePath.ToUpper()))
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
