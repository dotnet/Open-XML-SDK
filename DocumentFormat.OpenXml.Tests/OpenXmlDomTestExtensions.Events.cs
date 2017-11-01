// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace DocumentFormat.OpenXml.Tests
{
    public static partial class OpenXmlDomTestExtensions
    {
        /// <summary> Set event handler on pass-in element's OpenXmlElementContext.</summary>
        /// <param name="e">current element</param>
        /// <param name="handler">event handler to be hooked on</param>
        /// <returns>current element with event handlers hooked</returns>
        public static OpenXmlElement SetEventHandler(this OpenXmlElement e, Func<OpenXmlElement, OpenXmlElement> attachHandlerTo)
        {
            if (null == e) return e;

            return attachHandlerTo(e);
        }
    }
}
