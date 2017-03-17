// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DocumentFormat.OpenXml.Internal.SemanticValidation;
using DocumentFormat.OpenXml;
using Excel = DocumentFormat.OpenXml.Spreadsheet;
using Word = DocumentFormat.OpenXml.Wordprocessing;
using Vml = DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for SemanticConstraintTest
    /// </summary>
    
    public class SemanticConstraintTest
    {
        public SemanticConstraintTest()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [Fact]
        public void AttributeMinMaxConstraintTest()
        {
            Excel.Column column = new Excel.Column();
            ValidationContext context = new ValidationContext() { Element = column };

            AttributeMinMaxConstraint constraint = new AttributeMinMaxConstraint("", "min", "", "max") ;

            column.Max = 2;
            column.Min = 1;
            Assert.Null(constraint.Validate(context)); //max > min, should pass validation

            column.Max = 2;
            column.Min = 2;
            Assert.Null(constraint.Validate(context)); //max == min, should pass validation

            column.Max = 2;
            column.Min = 3;
            Assert.NotNull(constraint.Validate(context)); //max < min, validation should be failed.
        }

        [Fact]
        public void AttributePairConstraintTest()
        {
            Word.MoveFromRangeStart moveFromRangeStart = new Word.MoveFromRangeStart();
            ValidationContext context = new ValidationContext() { Element = moveFromRangeStart };

            AttributePairConstraint constraint = new AttributePairConstraint("http://schemas.openxmlformats.org/wordprocessingml/2006/main", "colFirst", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "colLast");

            moveFromRangeStart.ColumnFirst = 1;
            moveFromRangeStart.ColumnLast = 2;
            Assert.Null(constraint.Validate(context));

            moveFromRangeStart.RemoveAttribute("colFirst", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            moveFromRangeStart.ColumnLast = 2;
            Assert.NotNull(constraint.Validate(context));

            moveFromRangeStart.ColumnFirst = 1;
            moveFromRangeStart.RemoveAttribute("colLast", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            Assert.NotNull(constraint.Validate(context));

            moveFromRangeStart.ColumnFirst = null;
            moveFromRangeStart.ColumnLast = null;
            Assert.Null(constraint.Validate(context));
        }
    }
}
