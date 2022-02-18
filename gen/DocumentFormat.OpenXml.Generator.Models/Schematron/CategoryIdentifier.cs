// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

#nullable disable

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    /// <summary>
    /// Class for category identification
    /// </summary>
    public static class CategoryIdentifier
    {
        private static IdentificationTreeNode root;

        static CategoryIdentifier()
        {
            Initialize();
        }

        /// <summary>
        /// Identify category of specified SchematronData
        /// </summary>
        public static string Identify(string test)
        {
            var tree = SyntaxAnalysor.Analysis(test);

            var cur = root;
            foreach (var node in tree.PreorderTraverse())
            {
                // leaf element is not a keyword
                if (node.Children.Any())
                {
                    cur = cur.GetChildByText(node.Text);

                    Debug.Assert(cur != null);
                }
            }

            return cur.Category;
        }

        private static void Initialize()
        {
            root = new IdentificationTreeNode(string.Empty);

            // root.Category = "1.1";

            // Category modality is compsed by a keywords sequence.
            // Only operator and function name are treated as keyword in schematron.
            // Single category may have mutiple modalities due to optional parameters.
            AddCategoryModality("1.1", new string[] { "@" }, -1, -1);

            AddCategoryModality("1.2", new string[] { "fn:matches", "@" }, -1, -1);

            AddCategoryModality("1.3", new string[] { ">=", "@" }, -1, -1);
            AddCategoryModality("1.3", new string[] { "<=", "@" }, -1, -1);
            AddCategoryModality("1.3", new string[] { ">", "@" }, -1, -1);
            AddCategoryModality("1.3", new string[] { "<", "@" }, -1, -1);
            AddCategoryModality("1.3", new string[] { "and", ">=", "@", "<=", "@" }, -1, -1);
            AddCategoryModality("1.3", new string[] { "and", ">", "@", "<", "@" }, -1, -1);
            AddCategoryModality("1.3", new string[] { "and", ">=", "@", "<", "@" }, -1, -1);
            AddCategoryModality("1.3", new string[] { "and", ">", "@", "<=", "@" }, -1, -1);

            AddCategoryModality("1.4", new string[] { "=", "@" }, -1, -1);
            AddCategoryModality("1.4", new string[] { "or", "=", "@", "=", "@" }, 0, 2);

            AddCategoryModality("1.10", new string[] { "!=", "@" }, -1, -1);
            AddCategoryModality("1.10", new string[] { "and", "!=", "@", "!=", "@" }, 0, 2);

            AddCategoryModality("1.12", new string[] { "=", "fn:string-length", "@" }, -1, -1);
            AddCategoryModality("1.12", new string[] { ">=", "fn:string-length", "@" }, -1, -1);
            AddCategoryModality("1.12", new string[] { "<=", "fn:string-length", "@" }, -1, -1);
            AddCategoryModality("1.12", new string[] { "and", ">=", "fn:string-length", "@", "<=", "fn:string-length", "@" }, -1, -1);

            AddCategoryModality("1.14", new string[] { "and", "@", "=", "@" }, -1, -1);
            AddCategoryModality("1.14", new string[] { "and", "@", "or", "=", "@", "=", "@" }, 2, 4);

            AddCategoryModality("1.15", new string[] { "and", "@", "!=", "@" }, -1, -1);
            AddCategoryModality("1.15", new string[] { "and", "@", "and", "!=", "@", "!=", "@" }, 2, 4);

            AddCategoryModality("1.16", new string[] { "and", "@", "@" }, -1, -1);
            AddCategoryModality("1.16", new string[] { "or", "and", "@", "@", "and", "@", "@" }, 0, 3);

            AddCategoryModality("1.17", new string[] { "<", "@", "@" }, -1, -1);
            AddCategoryModality("1.17", new string[] { "<=", "@", "@" }, -1, -1);

            AddCategoryModality("1.18", new string[] { "or", "and", "@", "=", "@", "!=", "@" }, -1, -1);
            AddCategoryModality("1.18", new string[] { "or", "and", "@", "or", "=", "@", "=", "@", "and", "!=", "@", "!=", "@" }, 3, 5, 8, 10);

            AddCategoryModality("1.19", new string[] { "or", "and", "=", "@", "=", "@", "!=", "@" }, -1, -1);
            AddCategoryModality("1.19", new string[] { "or", "and", "=", "@", "or", "=", "@", "=", "@", "and", "!=", "@", "!=", "@" }, 4, 6, 9, 11);
            AddCategoryModality("1.19", new string[] { "or", "and", "or", "=", "@", "=", "@", "or", "=", "@", "=", "@", "and", "!=", "@", "!=", "@" }, 2, 4, 7, 9, 12, 14);
            AddCategoryModality("1.19", new string[] { "or", "and", "or", "=", "@", "=", "@", "=", "@", "!=", "@" }, 2, 2, 7, 8);

            AddCategoryModality("2.1", new string[] { "[]", "//", "fn:document", "=", "@", "/@" }, -1, -1);

            AddCategoryModality("2.2", new string[] { "=", "/@", "[]", "//", "fn:document", "=", "@", "/@" }, -1, -1);

            AddCategoryModality("2.3", new string[] { "=", "fn:count", "fn:distinct-values", "//", "/@", "fn:count", "//", "/@" }, -1, -1);
            AddCategoryModality("2.3", new string[] { "=", "fn:count", "fn:distinct-values", "fn:lower-case", "//", "/@", "fn:count", "fn:lower-case", "//", "/@" }, -1, -1);
            AddCategoryModality("2.3", new string[] { "=", "fn:count", "fn:distinct-values", "//", "ancestor::", "/@", "fn:count", "//", "ancestor::", "/@" }, -1, -1);
            AddCategoryModality("2.3", new string[] { "=", "fn:count", "fn:distinct-values", "fn:lower-case", "//", "ancestor::", "/@", "fn:count", "fn:lower-case", "//", "ancestor::", "/@" }, -1, -1);

            AddCategoryModality("3.1", new string[] { "fn:Index-of", "//", "fn:document", "/@", "@" }, -1, -1);

            AddCategoryModality("3.2", new string[] { "<", "@", "+", "fn:count", "//", "fn:document" }, -1, -1);

            AddCategoryModality("3.3", new string[] { "=", "fn:count", "fn:distinct-values", "//", "fn:document", "/@", "fn:count", "//", "fn:document", "/@" }, -1, -1);
            AddCategoryModality("3.3", new string[] { "=", "fn:count", "fn:distinct-values", "fn:lower-case", "//", "fn:document", "/@", "fn:count", "fn:lower-case", "//", "fn:document", "/@" }, -1, -1);

            // todo: add more category modalities here.
        }

        private static void AddCategoryModality(string category, string[] keywords, params int[] rings)
        {
            if (rings.Length % 2 != 0)
            {
                throw new ArgumentException();
            }

            var ringStarts = new List<int>();
            var ringEnds = new List<int>();
            for (var i = 0; i < rings.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ringStarts.Add(rings[i]);
                }
                else
                {
                    ringEnds.Add(rings[i]);
                }
            }

            var cur = root;
            IdentificationTreeNode ringHead = null;
            var ringHeadStack = new Stack<IdentificationTreeNode>();

            for (var i = 0; i < keywords.Length; i++)
            {
                var nodes = cur.Children.Where(c => c.Text == keywords[i]);

                Debug.Assert(!nodes.Any() || nodes.Count() == 1);

                if (!nodes.Any())
                {
                    var node = new IdentificationTreeNode(keywords[i]);
                    cur.Children.Add(node);
                    cur = node;
                }
                else
                {
                    cur = nodes.First();
                }

                if (ringStarts.Contains(i))
                {
                    if (ringHead != null)
                    {
                        ringHeadStack.Push(ringHead);
                    }

                    ringHead = cur;
                }

                if (ringEnds.Contains(i))
                {
                    Debug.Assert(ringHead != null);
                    cur.Children.Add(ringHead);

                    if (ringHeadStack.Count != 0)
                    {
                        ringHead = ringHeadStack.Pop();
                    }
                    else
                    {
                        ringHead = null;
                    }
                }
            }

            Debug.Assert(cur.Category == null); // make sure different category has different preorder traverse sequence.

            cur.Category = category;
        }
    }
}
