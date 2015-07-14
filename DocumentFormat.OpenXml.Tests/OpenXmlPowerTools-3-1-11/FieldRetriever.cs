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

Version: 2.6.00
 * Enhance to support the HtmlConverter

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public class FieldRetriever
    {
        public static string InstrText(XElement root, int id)
        {

            XNamespace w = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

#if false
            // This is the old code.  Both versions work - the caching version is significantly faster.
            var relevantElements = root.Descendants()
                .Where(e =>
                {
                    Stack<FieldElementTypeInfo> s = e.Annotation<Stack<FieldElementTypeInfo>>();
                    if (s != null)
                        return s.Any(z => z.Id == id &&
                            z.FieldElementType == FieldElementTypeEnum.InstrText);
                    return false;
                })
                .ToList();
#else
            var cachedAnnotationInformation = root.Annotation<Dictionary<int, List<XElement>>>();
            if (cachedAnnotationInformation == null)
                throw new OpenXmlPowerToolsException("Internal error");

            // it is possible that a field code contains no instr text
            if (!cachedAnnotationInformation.ContainsKey(id))
                return "";
            var relevantElements = cachedAnnotationInformation[id];
#endif

            var groupedSubFields = relevantElements
                .GroupAdjacent(e =>
                {
                    Stack<FieldElementTypeInfo> s = e.Annotation<Stack<FieldElementTypeInfo>>();
                    var stackElement = s.FirstOrDefault(z => z.Id == id);
                    var elementsBefore = s.TakeWhile(z => z != stackElement);
                    return elementsBefore.Any();
                })
                .ToList();

            var instrText = groupedSubFields
                .Select(g =>
                {
                    if (g.Key == false)
                    {
                        return g.Select(e =>
                        {
                            Stack<FieldElementTypeInfo> s = e.Annotation<Stack<FieldElementTypeInfo>>();
                            var stackElement = s.FirstOrDefault(z => z.Id == id);
                            if (stackElement.FieldElementType == FieldElementTypeEnum.InstrText &&
                                e.Name == w + "instrText")
                                return e.Value;
                            return "";
                        })
                            .StringConcatenate();
                    }
                    else
                    {
                        Stack<FieldElementTypeInfo> s = g.First().Annotation<Stack<FieldElementTypeInfo>>();
                        var stackElement = s.FirstOrDefault(z => z.Id == id);
                        var elementBefore = s.TakeWhile(z => z != stackElement).Last();
                        var subFieldId = elementBefore.Id;
                        return InstrText(root, subFieldId);
                    }
                })
                .StringConcatenate();

            return "{" + instrText + "}";
        }

        public static void AnnotateWithFieldInfo(OpenXmlPart part)
        {
            XNamespace w = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

            XElement root = part.GetXDocument().Root;
            var r = root.DescendantsAndSelf()
                .Rollup(
                    new FieldElementTypeStack
                    {
                        Id = 0,
                        FiStack = null,
                    },
                    (e, s) =>
                    {
                        if (e.Name == w + "fldChar")
                        {
                            if (e.Attribute(w + "fldCharType").Value == "begin")
                            {
                                Stack<FieldElementTypeInfo> fis;
                                if (s.FiStack == null)
                                    fis = new Stack<FieldElementTypeInfo>();
                                else
                                    fis = new Stack<FieldElementTypeInfo>(s.FiStack.Reverse());
                                fis.Push(
                                    new FieldElementTypeInfo
                                    {
                                        Id = s.Id + 1,
                                        FieldElementType = FieldElementTypeEnum.Begin,
                                    });
                                return new FieldElementTypeStack
                                {
                                    Id = s.Id + 1,
                                    FiStack = fis,
                                };
                            };
                            if (e.Attribute(w + "fldCharType").Value == "separate")
                            {
                                Stack<FieldElementTypeInfo> fis = new Stack<FieldElementTypeInfo>(s.FiStack.Reverse());
                                FieldElementTypeInfo wfi = fis.Pop();
                                fis.Push(
                                    new FieldElementTypeInfo
                                    {
                                        Id = wfi.Id,
                                        FieldElementType = FieldElementTypeEnum.Separate,
                                    });
                                return new FieldElementTypeStack
                                {
                                    Id = s.Id,
                                    FiStack = fis,
                                };
                            }
                            if (e.Attribute(w + "fldCharType").Value == "end")
                            {
                                Stack<FieldElementTypeInfo> fis = new Stack<FieldElementTypeInfo>(s.FiStack.Reverse());
                                FieldElementTypeInfo wfi = fis.Pop();
                                return new FieldElementTypeStack
                                {
                                    Id = s.Id,
                                    FiStack = fis,
                                };
                            }
                        }
                        if (s.FiStack == null || s.FiStack.Count() == 0)
                            return s;
                        FieldElementTypeInfo wfi3 = s.FiStack.Peek();
                        if (wfi3.FieldElementType == FieldElementTypeEnum.Begin)
                        {
                            Stack<FieldElementTypeInfo> fis = new Stack<FieldElementTypeInfo>(s.FiStack.Reverse());
                            FieldElementTypeInfo wfi2 = fis.Pop();
                            fis.Push(
                                new FieldElementTypeInfo
                                {
                                    Id = wfi2.Id,
                                    FieldElementType = FieldElementTypeEnum.InstrText,
                                });
                            return new FieldElementTypeStack
                            {
                                Id = s.Id,
                                FiStack = fis,
                            };
                        }
                        if (wfi3.FieldElementType == FieldElementTypeEnum.Separate)
                        {
                            Stack<FieldElementTypeInfo> fis = new Stack<FieldElementTypeInfo>(s.FiStack.Reverse());
                            FieldElementTypeInfo wfi2 = fis.Pop();
                            fis.Push(
                                new FieldElementTypeInfo
                                {
                                    Id = wfi2.Id,
                                    FieldElementType = FieldElementTypeEnum.Result,
                                });
                            return new FieldElementTypeStack
                            {
                                Id = s.Id,
                                FiStack = fis,
                            };
                        }
                        if (wfi3.FieldElementType == FieldElementTypeEnum.End)
                        {
                            Stack<FieldElementTypeInfo> fis = new Stack<FieldElementTypeInfo>(s.FiStack.Reverse());
                            fis.Pop();
                            if (!fis.Any())
                                fis = null;
                            return new FieldElementTypeStack
                            {
                                Id = s.Id,
                                FiStack = fis,
                            };
                        }
                        return s;
                    });
            var elementPlusInfo = root.DescendantsAndSelf().Zip(r, (t1, t2) =>
            {
                return new
                {
                    Element = t1,
                    Id = t2.Id,
                    WmlFieldInfoStack = t2.FiStack,
                };
            });
            foreach (var item in elementPlusInfo)
            {
                if (item.WmlFieldInfoStack != null)
                    item.Element.AddAnnotation(item.WmlFieldInfoStack);
            }

            //This code is useful when you want to take a look at the annotations, making sure that they are made correctly.
            //
            //foreach (var desc in root.DescendantsAndSelf())
            //{
            //    Stack<FieldElementTypeInfo> s = desc.Annotation<Stack<FieldElementTypeInfo>>();
            //    if (s != null)
            //    {
            //        Console.WriteLine(desc.Name.LocalName.PadRight(20));
            //        foreach (var item in s)
            //        {
            //            Console.WriteLine("    {0:0000} {1}", item.Id, item.FieldElementType.ToString());
            //            Console.ReadKey();
            //        }
            //    }
            //}

            var cachedAnnotationInformation = new Dictionary<int, List<XElement>>();
            foreach (var desc in root.DescendantsTrimmed(d => d.Name == W.rPr || d.Name == W.pPr))
            {
                Stack<FieldElementTypeInfo> s = desc.Annotation<Stack<FieldElementTypeInfo>>();

                if (s != null )
                {
                    foreach (var item in s)
                    {
                        if (item.FieldElementType == FieldElementTypeEnum.InstrText)
                        {
                            if (cachedAnnotationInformation.ContainsKey(item.Id))
                            {
                                cachedAnnotationInformation[item.Id].Add(desc);
                            }
                            else
                            {
                                cachedAnnotationInformation.Add(item.Id, new List<XElement>() { desc });
                            }
                        }
                    }
                }
            }
            root.AddAnnotation(cachedAnnotationInformation);
        }

        private enum State
        {
            InToken,
            InWhiteSpace,
            InQuotedToken,
            OnOpeningQuote,
            OnClosingQuote,
            OnBackslash,
        }

        private static string[] GetTokens(string field)
        {
            State state = State.InWhiteSpace;
            int tokenStart = 0;
            char quoteStart = char.MinValue;
            List<string> tokens = new List<string>();
            for (int c = 0; c < field.Length; c++)
            {
                if (Char.IsWhiteSpace(field[c]))
                {
                    if (state == State.InToken)
                    {
                        tokens.Add(field.Substring(tokenStart, c - tokenStart));
                        state = State.InWhiteSpace;
                        continue;
                    }
                    if (state == State.OnOpeningQuote)
                    {
                        tokenStart = c;
                        state = State.InQuotedToken;
                    }
                    if (state == State.OnClosingQuote)
                        state = State.InWhiteSpace;
                    continue;
                }
                if (field[c] == '\\')
                {
                    if (state == State.InQuotedToken)
                    {
                        state = State.OnBackslash;
                        continue;
                    }
                }
                if (state == State.OnBackslash)
                {
                    state = State.InQuotedToken;
                    continue;
                }
                if (field[c] == '"' || field[c] == '\'' || field[c] == 0x201d)
                {
                    if (state == State.InWhiteSpace)
                    {
                        quoteStart = field[c];
                        state = State.OnOpeningQuote;
                        continue;
                    }
                    if (state == State.InQuotedToken)
                    {
                        if (field[c] == quoteStart)
                        {
                            tokens.Add(field.Substring(tokenStart, c - tokenStart));
                            state = State.OnClosingQuote;
                            continue;
                        }
                        continue;
                    }
                    if (state == State.OnOpeningQuote)
                    {
                        if (field[c] == quoteStart)
                        {
                            state = State.OnClosingQuote;
                            continue;
                        }
                        else
                        {
                            tokenStart = c;
                            state = State.InQuotedToken;
                            continue;
                        }
                    }
                    continue;
                }
                if (state == State.InWhiteSpace)
                {
                    tokenStart = c;
                    state = State.InToken;
                    continue;
                }
                if (state == State.OnOpeningQuote)
                {
                    tokenStart = c;
                    state = State.InQuotedToken;
                    continue;
                }
                if (state == State.OnClosingQuote)
                {
                    tokenStart = c;
                    state = State.InToken;
                    continue;
                }
            }
            if (state == State.InToken)
                tokens.Add(field.Substring(tokenStart, field.Length - tokenStart));
            return tokens.ToArray();
        }

        public static FieldInfo ParseField(string field)
        {
            FieldInfo emptyField = new FieldInfo
            {
                FieldType = "",
                Arguments = new string[] { },
                Switches = new string[] { },
            };

            if (field.Length == 0)
                return emptyField;
            string fieldType = field.TrimStart().Split(' ').FirstOrDefault();
            if (fieldType == null || fieldType.ToUpper() != "HYPERLINK")
                return emptyField;
            string[] tokens = GetTokens(field);
            if (tokens.Length == 0)
                return emptyField;
            FieldInfo fieldInfo = new FieldInfo()
            {
                FieldType = tokens[0],
                Switches = tokens.Where(t => t[0] == '\\').ToArray(),
                Arguments = tokens.Skip(1).Where(t => t[0] != '\\').ToArray(),
            };
            return fieldInfo;
        }

        public class FieldInfo
        {
            public string FieldType;
            public string[] Switches;
            public string[] Arguments;
        }

        public enum FieldElementTypeEnum
        {
            Begin,
            InstrText,
            Separate,
            Result,
            End,
        };

        public class FieldElementTypeInfo
        {
            public int Id;
            public FieldElementTypeEnum FieldElementType;
        }

        public class FieldElementTypeStack
        {
            public int Id;
            public Stack<FieldElementTypeInfo> FiStack;
        }
    }
}
