// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;

namespace DocumentFormat.OpenXml
{
    internal static class SR
    {
        public static string Format(string str, params object[] args)
        {
            return string.Format(CultureInfo.CurrentUICulture, str, args);
        }

        public static string Format(string str, object arg0)
        {
            return string.Format(CultureInfo.CurrentUICulture, str, arg0);
        }

        public static string Format(string str, object arg0, object arg1)
        {
            return string.Format(CultureInfo.CurrentUICulture, str, arg0, arg1);
        }

        public static string Format(string str, object arg0, object arg1, object arg2)
        {
            return string.Format(CultureInfo.CurrentUICulture, str, arg0, arg1, arg2);
        }
    }
}
