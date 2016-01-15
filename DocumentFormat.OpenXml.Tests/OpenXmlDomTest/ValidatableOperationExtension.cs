// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Tests
{
    static class ValidatableOperationExtension
    {
        #region Extensions for Operations
        /// <summary> Extension to actions on specified element with log functionality. </summary>
        /// <param name="root">current element.</param>
        /// <param name="Log">VerifiableLog instance</param>
        /// <param name="action">delegate to actions to be performed on current element</param>
        public static void ValidOperation(this OpenXmlElement root, LogUtil.VerifiableLog Log, ValidAction action)
        {
            Log.Comment("Executing specified actions on current element...");
            action(root);
            Log.Comment("Executed specified actions on current element.");
            Log.Comment("Saving changes...");
            root.PartRootElement().Save();
            Log.Comment("Saved changes successfully.");
            Log.Pass("Specified actions executed without any exceptions.");
        }
        public delegate void ValidAction(OpenXmlElement e);

        /// <summary> Extension to invalid actions on specified element with log functionality.</summary>
        /// <typeparam name="ExpectedException">Expected exception that is supposed to throw on specified action</typeparam>
        /// <param name="root">current element</param>
        /// <param name="Log">VerifiableLog instance</param>
        /// <param name="exAction">delegate to invalid actions to be performed on current element</param>
        public static void InvalidOperation<ExpectedException>(this OpenXmlElement root, LogUtil.VerifiableLog Log, InvalidAction exAction)
             where ExpectedException : Exception
        {
            try
            {
                Log.Comment("Executing specified actions on current element...");
                exAction(root);
                Log.Comment("Executed specified actions on current element.");
                Log.Comment("Saving changes...");
                root.PartRootElement().Save();
                Log.Comment("Saved changes successfully.");
                Log.Fail("No {0} happened as expected.", typeof(ExpectedException).Name);
            }
            catch (ExpectedException e)
            {
                Log.Pass("Expected {0} caught.", e.GetType().Name);
                Log.Comment(e.ToString());
            }
        }
        public delegate void InvalidAction(OpenXmlElement e);
        #endregion Extensions for Operations
    }
}
