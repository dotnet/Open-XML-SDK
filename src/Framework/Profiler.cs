// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
#if PROFILE
using Microsoft.VisualStudio.Profiler;
#endif

namespace DocumentFormat.OpenXml
{
    internal static class Profiler
    {
        internal enum MarkId
        {
            OpenXmlPackage_Load_In = 100,
            OpenXmlPackage_Load_Out = 101,
            OpenXmlPartRootElement_LoadFromPart_In = 200,
            OpenXmlPartRootElement_LoadFromPart_Out = 201,
        }

        /// <summary>
        /// Call DataCollection.CommentMarkAtProfile if PROFILE is enabled.
        /// </summary>
        /// <param name="timestamp">A timestamp value</param>
        /// <param name="markId">A marker to insert</param>
        internal static void CommentMarkAtProfile(long timestamp, MarkId markId)
        {
#if PROFILE
            string markText = Enum.GetName(typeof(MarkId), (int)markId);

            // We ignore the return value because not all apps support profiling.
            DataCollection.CommentMarkAtProfile(timestamp, (int)markId, markText);
#else
            // Do nothing unless PROFILE is enabled.
#endif
        }

        /// <summary>
        /// Call DataCollection.CommentMarkAtProfile if PROFILE is enabled.
        /// </summary>
        /// <param name="markId">A marker to insert</param>
        internal static void CommentMarkProfile(MarkId markId)
        {
#if PROFILE
            string markText = Enum.GetName(typeof(MarkId), (int)markId);

            // We ignore the return value because not all apps support profiling.
            DataCollection.CommentMarkProfile((int)markId, markText);
#else
            // Do nothing unless PROFILE is enabled.
#endif
        }
    }
}
