// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

#nullable disable

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    internal class IdentificationTreeNode
    {
        public string Text { get; set; }

        public List<IdentificationTreeNode> Children { get; set; }

        public string Category { get; set; }

        public IdentificationTreeNode(string text)
        {
            Text = text;
            Children = new List<IdentificationTreeNode>();
        }

        public IdentificationTreeNode GetChildByText(string text)
        {
            var nodes = Children.Where(c => c.Text == text.Trim());

            if (!nodes.Any())
            {
                return null;
            }

            Debug.Assert(nodes.Count() == 1);

            return nodes.First();
        }
    }
}
