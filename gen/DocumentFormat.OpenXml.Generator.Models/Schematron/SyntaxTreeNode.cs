// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable disable

using DocumentFormat;

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    /// <summary>
    /// Syntax tree node
    /// </summary>
    public class SyntaxTreeNode
    {
        private readonly List<SyntaxTreeNode> _children = new List<SyntaxTreeNode>();

        public SyntaxTreeNode Parent { get; set; }

        public string Text { get; set; }

        public int Weight { get; set; }

        public SyntaxTreeNode()
        {
            Weight = 0;
        }

        public SyntaxTreeNode AppendChild(string text) => AppendChild(new SyntaxTreeNode() { Text = text });

        public SyntaxTreeNode ReplaceChild(SyntaxTreeNode oldNode, SyntaxTreeNode newNode)
        {
            var index = _children.IndexOf(oldNode);
            _children.Insert(index, newNode);
            newNode.Parent = this;
            _children.Remove(oldNode);

            return newNode;
        }

        public IEnumerable<SyntaxTreeNode> AppendChildren(IEnumerable<SyntaxTreeNode> nodes)
        {
            foreach (var node in nodes)
            {
                AppendChild(node);
            }

            return nodes;
        }

        public IEnumerable<SyntaxTreeNode> RemoveAll()
        {
            var result = new SyntaxTreeNode[_children.Count];

            foreach (var child in _children)
            {
                child.Parent = null;
            }

            _children.CopyTo(result);
            _children.Clear();

            return result;
        }

        public SyntaxTreeNode AppendChild(SyntaxTreeNode node)
        {
            _children.Add(node);
            node.Parent = this;
            return node;
        }

        public SyntaxTreeNode RemoveChild(SyntaxTreeNode node)
        {
            _children.Remove(node);
            node.Parent = null;
            return node;
        }

        public IEnumerable<SyntaxTreeNode> Children
        {
            get
            {
                foreach (var node in _children)
                {
                    yield return node;
                }
            }
        }
    }
}
