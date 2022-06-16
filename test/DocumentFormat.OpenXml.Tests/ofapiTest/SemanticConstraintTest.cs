// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Semantic;
using Xunit;

using Excel = DocumentFormat.OpenXml.Spreadsheet;
using Word = DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Tests
{
    public class SemanticConstraintTest
    {
        [Fact]
        public void AttributeMinMaxConstraintTest()
        {
            var column = new Excel.Column();
            var context = new ValidationContext(new OpenXmlNamespaceResolver());
            context.Stack.Push(element: column);

            var constraint = new AttributeMinMaxConstraint(string.Empty, "min", string.Empty, "max");

            column.Max = 2;
            column.Min = 1;
            Assert.Null(constraint.ValidateCore(context)); // max > min, should pass validation

            column.Max = 2;
            column.Min = 2;
            Assert.Null(constraint.ValidateCore(context)); // max == min, should pass validation

            column.Max = 2;
            column.Min = 3;
            Assert.NotNull(constraint.ValidateCore(context)); // max < min, validation should be failed.
        }

        [Fact]
        public void AttributePairConstraintTest()
        {
            var moveFromRangeStart = new Word.MoveFromRangeStart();
            var context = new ValidationContext(new OpenXmlNamespaceResolver());
            context.Stack.Push(element: moveFromRangeStart);

            var constraint = new AttributePairConstraint("http://schemas.openxmlformats.org/wordprocessingml/2006/main", "colFirst", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "colLast");

            moveFromRangeStart.ColumnFirst = 1;
            moveFromRangeStart.ColumnLast = 2;
            Assert.Null(constraint.ValidateCore(context));

            moveFromRangeStart.RemoveAttribute("colFirst", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            moveFromRangeStart.ColumnLast = 2;
            Assert.NotNull(constraint.ValidateCore(context));

            moveFromRangeStart.ColumnFirst = 1;
            moveFromRangeStart.RemoveAttribute("colLast", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            Assert.NotNull(constraint.ValidateCore(context));

            moveFromRangeStart.ColumnFirst = null;
            moveFromRangeStart.ColumnLast = null;
            Assert.Null(constraint.ValidateCore(context));
        }
    }
}
