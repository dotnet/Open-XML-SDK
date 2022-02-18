// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

#nullable disable

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    /// <summary>
    /// Class for schematron statement analysis
    /// </summary>
    public static class SyntaxAnalysor
    {
        private static readonly Dictionary<char, string[]> _keyWorDictionary = new Dictionary<char, string[]>();
        private static readonly Dictionary<string, int> _WeightDictionary = new Dictionary<string, int>();

        /// <summary>
        /// Static constructor
        /// </summary>
        static SyntaxAnalysor()
        {
            InitializeKeyWordDictionary();
            InitializeWeightDictionary();
        }

        /// <summary>
        /// Analysis specified expression.
        /// </summary>
        /// <param name="expression" />
        /// <returns></returns>
        public static SyntaxTree Analysis(string expression)
        {
            var tree = Run(ConvertSpecialWords(expression));

            AdjustSyntaxTree(tree);

            return tree;
        }

        /// <summary>
        /// List all key word of schematron operator here
        /// </summary>
        private static void InitializeKeyWordDictionary()
        {
            _keyWorDictionary.Add('=', new string[] { "=" });
            _keyWorDictionary.Add('!', new string[] { "!=" });
            _keyWorDictionary.Add('<', new string[] { "<", "<=" });
            _keyWorDictionary.Add('>', new string[] { ">", ">=" });
            _keyWorDictionary.Add('|', new string[] { "|" });
            _keyWorDictionary.Add('+', new string[] { "+" });
            _keyWorDictionary.Add('*', new string[] { "*" });
            _keyWorDictionary.Add(' ', new string[] { " - ", " div ", " or ", " and ", " mod " });
            _keyWorDictionary.Add('/', new string[] { "/@", "//" }); // "/",
            _keyWorDictionary.Add('a', new string[] { "ancestor::" });
            _keyWorDictionary.Add('@', new string[] { "@" });
        }

        /// <summary>
        /// Give each operator a weight.
        /// Bigger weight means lower precedence.
        /// </summary>
        private static void InitializeWeightDictionary()
        {
            _WeightDictionary.Add("*", 2);
            _WeightDictionary.Add(" div ", 2);
            _WeightDictionary.Add(" mod ", 2);
            _WeightDictionary.Add("+", 3);
            _WeightDictionary.Add("-", 3);
            _WeightDictionary.Add("|", 3);
            _WeightDictionary.Add("=", 4);
            _WeightDictionary.Add("!=", 4);
            _WeightDictionary.Add("<", 4);
            _WeightDictionary.Add(">", 4);
            _WeightDictionary.Add("<=", 4);
            _WeightDictionary.Add(">=", 4);
            _WeightDictionary.Add(" or ", 5);
            _WeightDictionary.Add(" and ", 5);
            _WeightDictionary.Add("/@", 1);
            _WeightDictionary.Add("//", 1);
            _WeightDictionary.Add("ancestor::", 0);
            _WeightDictionary.Add("@", 1);
        }

        /// <summary>
        /// Identify keyword from specified text.
        /// </summary>
        /// <param name="text">Source text from which this method will indentify keyword.</param>
        /// <param name="pos">
        /// Index of specified text.
        /// As input, it specifies start index of idenfication.
        /// As output, it specifies index of matched keyword's last character in soure text.
        /// i.e. if test="A KEYWORD B", matchedKeyword="KEYWORD" then pos=8 (index of 'D' in "A KEYWORD B").
        /// </param>
        /// <param name="keywordCandidates">Keyword candidates.</param>
        /// <returns></returns>
        private static string IdentifyKeyWord(string text, ref int pos, string[] keywordCandidates)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            if (pos < 0 || pos >= text.Length)
            {
                return null;
            }

            string result = null;
            foreach (var candidate in keywordCandidates)
            {
                var targetLength = candidate.Length;
                if (pos + targetLength - 1 > text.Length)
                {
                    continue;
                }
                else
                {
                    var isKeyWord = true;
                    for (var i = 0; i < targetLength; i++)
                    {
                        if (text[pos + i] != candidate[i])
                        {
                            isKeyWord = false;
                            break;
                        }
                    }

                    if (isKeyWord)
                    {
                        // always match longest keyword.
                        // for example in "a <= b", we need return "<=" instead of "<".
                        if (result == null || result.Length < candidate.Length)
                        {
                            result = candidate;
                        }
                    }
                }
            }

            if (result != null)
            {
                pos += result.Length - 1;
            }

            return result;
        }

        /// <summary>
        /// Convert special xml words.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ConvertSpecialWords(string text)
        {
            var result = text.Replace("&gt;", ">");
            result = result.Replace("&lt;", "<");
            result = result.Replace("&amp;", "&");

            return result;
        }

        /// <summary>
        /// Construct syntax tree
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static SyntaxTree Run(string text)
        {
            var syntaxTree = new SyntaxTree() { Root = new SyntaxTreeNode() { Text = "()", Weight = 6 } };
            var nodeStack = new Stack<SyntaxTreeNode>();

            var currentNode = syntaxTree.Root.AppendChild(string.Empty);

            var quotationStack = new Stack<char>();

            for (var i = 0; i < text.Length; i++)
            {
                if (quotationStack.Count != 0)
                {
                    if (text[i] == '\\' && i < text.Length - 1 && (text[i + 1] == '\'' || text[i + 1] == '"'))
                    {
                        currentNode.Text += text[i + 1].ToString();
                        i++;

                        continue;
                    }

                    currentNode.Text += text[i].ToString();
                    if (quotationStack.Peek() == text[i])
                    {
                        if (i == 0 || text[i - 1] != '^')
                        {
                            quotationStack.Pop();
                        }
                    }

                    continue;
                }
                else if (text[i] == '"' || text[i] == '\'')
                {
                    quotationStack.Push(text[i]);
                    currentNode.Text += text[i].ToString();
                    continue;
                }
                else if (text[i] == '[')
                {
                    currentNode.Text = currentNode.Text.Trim();

                    var parent = currentNode.Parent;
                    while (parent.Weight < 5)
                    {
                        currentNode = parent;
                        parent = parent.Parent;
                    }

                    var newNode = new SyntaxTreeNode
                    {
                        Text = "[]",
                        Weight = 5,
                    };

                    parent.RemoveChild(currentNode);
                    newNode.AppendChild(currentNode);
                    parent.AppendChild(newNode);
                    currentNode = newNode.AppendChild(string.Empty);
                    nodeStack.Push(newNode);
                }
                else if (text[i] == ']')
                {
                    currentNode.Text = currentNode.Text.Trim();
                    if (string.IsNullOrEmpty(currentNode.Text))
                    {
                        currentNode.Parent.RemoveChild(currentNode);
                    }

                    currentNode = nodeStack.Pop();
                }
                else if (text[i] == '(')
                {
                    currentNode.Text = currentNode.Text.Trim();

                    if (string.IsNullOrEmpty(currentNode.Text))
                    {
                        currentNode.Text = "()";
                    }
                    else
                    {
                        currentNode.Text = "fn:" + currentNode.Text;
                    }

                    nodeStack.Push(currentNode);
                    currentNode.Weight = 5;
                    currentNode = currentNode.AppendChild(string.Empty);
                }
                else if (text[i] == ')')
                {
                    currentNode.Text = currentNode.Text.Trim();
                    if (string.IsNullOrEmpty(currentNode.Text))
                    {
                        currentNode.Parent.RemoveChild(currentNode);
                    }

                    currentNode = nodeStack.Pop();
                }
                else if (text[i] == ',')
                {
                    currentNode.Text = currentNode.Text.Trim();
                    if (string.IsNullOrEmpty(currentNode.Text))
                    {
                        currentNode.Parent.RemoveChild(currentNode);
                    }

                    do
                    {
                        currentNode = nodeStack.Pop();
                    }
                    while (!currentNode.Text.StartsWith("fn:"));

                    nodeStack.Push(currentNode);
                    currentNode = currentNode.AppendChild(string.Empty);
                }
                else if (_keyWorDictionary.Keys.Contains(text[i]))
                {
                    var keyWord = IdentifyKeyWord(text, ref i, _keyWorDictionary[text[i]]);
                    if (!string.IsNullOrEmpty(keyWord))
                    {
                        currentNode.Text = currentNode.Text.Trim();

                        var weight = _WeightDictionary[keyWord];
                        while (currentNode.Parent != syntaxTree.Root && currentNode.Parent.Weight < weight)
                        {
                            currentNode = currentNode.Parent;
                        }

                        var parent = currentNode.Parent;
                        var old = parent.RemoveChild(currentNode);

                        currentNode = parent.AppendChild(keyWord);
                        currentNode.Weight = weight;

                        if (!string.IsNullOrEmpty(old.Text))
                        {
                            currentNode.AppendChild(old);
                        }

                        currentNode = currentNode.AppendChild(string.Empty);
                    }
                    else
                    {
                        currentNode.Text += text[i].ToString();
                    }
                }
                else
                {
                    currentNode.Text += text[i].ToString();
                }
            }

            return syntaxTree;
        }

        /// <summary>
        /// Remove all "()" nodes in syntax tree.
        /// </summary>
        /// <param name="tree"></param>
        private static void AdjustSyntaxTree(SyntaxTree tree)
        {
            while (tree.Root.Text == "()")
            {
                Debug.Assert(tree.Root.Children.Count() == 1);

                tree.Root = tree.Root.Children.ElementAt(0);
                tree.Root.Parent = null;
            }

            AdjustSyntaxTreeNode(tree.Root);
        }

        private static void AdjustSyntaxTreeNode(SyntaxTreeNode node)
        {
            if (node.Text == "()")
            {
                Debug.Assert(node.Children.Count() == 1);

                node = node.Parent.ReplaceChild(node, node.Children.ElementAt(0));
            }

            foreach (var ch in node.Children.ToArray())
            {
                AdjustSyntaxTreeNode(ch);
            }
        }
    }
}
