/***************************************************************************

Copyright (c) Microsoft Corporation 2012-2013.

This code is licensed using the Microsoft Public License (Ms-PL).  The text of the license can be found here:

http://www.microsoft.com/resources/sharedsource/licensingbasics/publiclicense.mspx

Published at http://OpenXmlDeveloper.org
Resource Center and Documentation: http://openxmldeveloper.org/wiki/w/wiki/powertools-for-open-xml.aspx

Developer: Eric White
Blog: http://www.ericwhite.com
Twitter: @EricWhiteDev
Email: eric@ericwhite.com

Version: 2.6.01
 * Add languageCultureName parameter to GetListItemText methods.  This enables a single implementation to handle
   more than one language/culture where appropriate.

Version: 2.6.00

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXmlPowerTools
{
    class ListItemTextGetter_Default
    {
        private static string[] RomanOnes =
        {
            "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"
        };

        private static string[] RomanTens =
        {
            "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"
        };

        private static string[] RomanHundreds =
        {
            "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "M"
        };

        private static string[] RomanThousands =
        {
            "", "M", "MM", "MMM", "MMMM", "MMMMM", "MMMMMM", "MMMMMMM", "MMMMMMMM",
            "MMMMMMMMM", "MMMMMMMMMM"
        };

        private static string[] OneThroughNineteen = {
            "one", "two", "three", "four", "five", "six", "seven", "eight",
            "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
            "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static string[] Tens = {
            "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy",
            "eighty", "ninety"
        };

        private static string[] OrdinalOneThroughNineteen = {
            "first", "second", "third", "fourth", "fifth", "sixth",
            "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth",
            "thirteenth", "fourteenth", "fifteenth", "sixteenth",
            "seventeenth", "eighteenth", "nineteenth"
        };

        private static string[] OrdinalTenths = {
            "tenth", "twentieth", "thirtieth", "fortieth", "fiftieth",
            "sixtieth", "seventieth", "eightieth", "ninetieth"
        };

        public static string GetListItemText(string languageCultureName, int levelNumber, string numFmt)
        {
            if (numFmt == "none")
            {
                return "";
            }
            if (numFmt == "decimal")
            {
                return levelNumber.ToString();
            }
            if (numFmt == "decimalZero")
            {
                if (levelNumber <= 9)
                    return "0" + levelNumber.ToString();
                else
                    return levelNumber.ToString();
            }
            if (numFmt == "upperRoman")
            {
                int ones = levelNumber % 10;
                int tens = (levelNumber % 100) / 10;
                int hundreds = (levelNumber % 1000) / 100;
                int thousands = levelNumber / 1000;
                return RomanThousands[thousands] + RomanHundreds[hundreds] +
                    RomanTens[tens] + RomanOnes[ones];
            }
            if (numFmt == "lowerRoman")
            {
                int ones = levelNumber % 10;
                int tens = (levelNumber % 100) / 10;
                int hundreds = (levelNumber % 1000) / 100;
                int thousands = levelNumber / 1000;
                return (RomanThousands[thousands] + RomanHundreds[hundreds] +
                    RomanTens[tens] + RomanOnes[ones]).ToLower();
            }
            if (numFmt == "upperLetter")
            {
                int levelNumber2 = levelNumber % 780;
                if (levelNumber2 == 0)
                    levelNumber2 = 780;
                string a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int c = (levelNumber2 - 1) / 26;
                int n = (levelNumber2 - 1) % 26;
                char x = a[n];
                return "".PadRight(c + 1, x);
            }
            if (numFmt == "lowerLetter")
            {
                int levelNumber3 = levelNumber % 780;
                if (levelNumber3 == 0)
                    levelNumber3 = 780;
                string a = "abcdefghijklmnopqrstuvwxyz";
                int c = (levelNumber3 - 1) / 26;
                int n = (levelNumber3 - 1) % 26;
                char x = a[n];
                return "".PadRight(c + 1, x);
            }
            if (numFmt == "ordinal")
            {
                string suffix;
                if (levelNumber % 100 == 11 || levelNumber % 100 == 12 ||
                    levelNumber % 100 == 13)
                    suffix = "th";
                else if (levelNumber % 10 == 1)
                    suffix = "st";
                else if (levelNumber % 10 == 2)
                    suffix = "nd";
                else if (levelNumber % 10 == 3)
                    suffix = "rd";
                else
                    suffix = "th";
                return levelNumber.ToString() + suffix;
            }
            if (numFmt == "cardinalText")
            {
                string result = "";
                int t1 = levelNumber / 1000;
                int t2 = levelNumber % 1000;
                if (t1 >= 1)
                    result += OneThroughNineteen[t1 - 1] + " thousand";
                if (t1 >= 1 && t2 == 0)
                    return result.Substring(0, 1).ToUpper() +
                        result.Substring(1);
                if (t1 >= 1)
                    result += " ";
                int h1 = (levelNumber % 1000) / 100;
                int h2 = levelNumber % 100;
                if (h1 >= 1)
                    result += OneThroughNineteen[h1 - 1] + " hundred";
                if (h1 >= 1 && h2 == 0)
                    return result.Substring(0, 1).ToUpper() +
                        result.Substring(1);
                if (h1 >= 1)
                    result += " ";
                int z = levelNumber % 100;
                if (z <= 19)
                    result += OneThroughNineteen[z - 1];
                else
                {
                    int x = z / 10;
                    int r = z % 10;
                    result += Tens[x - 1];
                    if (r >= 1)
                        result += "-" + OneThroughNineteen[r - 1];
                }
                return result.Substring(0, 1).ToUpper() +
                    result.Substring(1);
            }
            if (numFmt == "ordinalText")
            {
                string result = "";
                int t1 = levelNumber / 1000;
                int t2 = levelNumber % 1000;
                if (t1 >= 1 && t2 != 0)
                    result += OneThroughNineteen[t1 - 1] + " thousand";
                if (t1 >= 1 && t2 == 0)
                {
                    result += OneThroughNineteen[t1 - 1] + " thousandth";
                    return result.Substring(0, 1).ToUpper() +
                        result.Substring(1);
                }
                if (t1 >= 1)
                    result += " ";
                int h1 = (levelNumber % 1000) / 100;
                int h2 = levelNumber % 100;
                if (h1 >= 1 && h2 != 0)
                    result += OneThroughNineteen[h1 - 1] + " hundred";
                if (h1 >= 1 && h2 == 0)
                {
                    result += OneThroughNineteen[h1 - 1] + " hundredth";
                    return result.Substring(0, 1).ToUpper() +
                        result.Substring(1);
                }
                if (h1 >= 1)
                    result += " ";
                int z = levelNumber % 100;
                if (z <= 19)
                    result += OrdinalOneThroughNineteen[z - 1];
                else
                {
                    int x = z / 10;
                    int r = z % 10;
                    if (r == 0)
                        result += OrdinalTenths[x - 1];
                    else
                        result += Tens[x - 1];
                    if (r >= 1)
                        result += "-" + OrdinalOneThroughNineteen[r - 1];
                }
                return result.Substring(0, 1).ToUpper() +
                    result.Substring(1);
            }
            if (numFmt == "01, 02, 03, ...")
            {
                return string.Format("{0:000}", levelNumber);
            }
            if (numFmt == "001, 002, 003, ...")
            {
                return string.Format("{0:000}", levelNumber);
            }
            if (numFmt == "0001, 0002, 0003, ...")
            {
                return string.Format("{0:0000}", levelNumber);
            }
            if (numFmt == "00001, 00002, 00003, ...")
            {
                return string.Format("{0:00000}", levelNumber);
            }
            if (numFmt == "bullet")
                return "";
            if (numFmt == "decimalEnclosedCircle")
            {
                if (levelNumber >= 1 && levelNumber <= 20)
                {
                    // 9311 + levelNumber
                    var s = new string(new[] { (char)(9311 + levelNumber) });
                    return s;
                }
                return levelNumber.ToString();
            }
            return levelNumber.ToString();
        }
    }
}
