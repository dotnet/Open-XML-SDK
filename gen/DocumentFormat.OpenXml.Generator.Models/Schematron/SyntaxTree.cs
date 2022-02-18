// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable disable

using DocumentFormat;

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    /// <summary>
    /// Syntax tree
    /// </summary>
    public class SyntaxTree
    {
        public SyntaxTreeNode Root { get; set; }

        public IEnumerable<SyntaxTreeNode> PreorderTraverse()
        {
            var list = new List<SyntaxTreeNode>();

            PreorderTraverseNode(Root, list);

            return list;
        }

        private void PreorderTraverseNode(SyntaxTreeNode node, List<SyntaxTreeNode> list)
        {
            list.Add(node);

            if (!node.Children.Any())
            {
                return;
            }
            else
            {
                foreach (var child in node.Children)
                {
                    PreorderTraverseNode(child, list);
                }
            }
        }
    }
}
