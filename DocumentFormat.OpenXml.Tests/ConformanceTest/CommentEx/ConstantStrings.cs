// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    /// <summary>
    /// Element Comment attribute "ID"
    /// </summary>
    public static class CommentIDs
    {
        public static string CommentID1 { get { return "1"; } }
        public static string CommentID2 { get { return "2"; } }
        public static string CommentID3 { get { return "3"; } }
        public static string CommentID4 { get { return "4"; } }
        public static string CommentID5 { get { return "5"; } }
    }

    /// <summary>
    /// Word document body text
    /// </summary>
    public static class CommentBodyStrings
    {
        public static string Comment1 { get { return "Test1"; } }
        public static string Comment2 { get { return "Test2"; } }
    }

    /// <summary>
    /// Element Comment attribute "Initial"
    /// </summary>
    public static class CommentInitials
    {
        public static string Initial1 { get { return "M.T"; } }
        public static string Initial2 { get { return "D.I"; } }
    }

    /// <summary>
    /// Element Comment attribute "Author"
    /// </summary>
    public static class CommentAuthors
    {
        public static string Author1 { get { return "Masaki Tamura (Pasona Tech)"; } }
        public static string Author2 { get { return "Dan Ito"; } }
    }

    /// <summary>
    /// Comment text
    /// </summary>
    public static class CommentStrings
    {
        public static string CommentString1 { get { return "Comment1"; } }
        public static string CommentString2 { get { return "Comment2"; } }
        public static string CommentString3 { get { return "Comment3"; } }
        public static string CommentChangeString1 { get { return "Changed comment1"; } }
        public static string CommentAppendString1 { get { return "Appended comment1"; } }
        public static string CommentAppendString2 { get { return "Appended comment2"; } }
    }

    /// <summary>
    /// Element CommentEx in paraId attribute
    /// </summary>
    public static class AppendCommentExIDs
    {
        public static string AppendCommentID1 { get { return "11111111"; } }
        public static string AppendCommentID2 { get { return "22222222"; } }
    }
}
