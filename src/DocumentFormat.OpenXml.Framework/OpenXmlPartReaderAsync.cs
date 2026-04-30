// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
#if TASKS_SUPPORTED
using System.Threading.Tasks;
#endif
using System.Xml;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Represents the Open XML part reader class.
/// </summary>
public partial class OpenXmlPartReader : OpenXmlReader
{
    /// <summary>
    /// Gets the type of the current node in the XML document being read.
    /// </summary>
    /// <remarks>
    /// The <see cref="XmlNodeType"/> indicates the type of the current node, such as
    /// <c>Element</c>, <c>Attribute</c>, <c>Text</c>, <c>CDATA</c>, <c>Comment</c>, or others.
    /// This property provides information about the structure of the XML document
    /// and is useful for determining how to process the current node.
    /// </remarks>
    public override XmlNodeType NodeType
    {
        get
        {
            return _xmlReader.NodeType;
        }
    }

#if TASKS_SUPPORTED
    /// <summary>
    /// Asynchronously reads the next element in the Open XML document.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous read operation. The task result is <c>true</c> if the next element
    /// was read successfully; <c>false</c> if there are no more elements to read.
    /// </returns>
    public async override Task<bool> ReadAsync()
    {
        ThrowIfObjectDisposed();

        bool result = await MoveToNextElementAsync().ConfigureAwait(false);

        if (result && !ReadMiscNodes)
        {
            // skip miscellaneous node
            while (result && IsMiscNode)
            {
                result = await MoveToNextElementAsync().ConfigureAwait(false);
            }
        }

        return result;
    }

    public async override Task<bool> ReadFirstChildAsync()
    {
        //ThrowIfObjectDisposed();

        //bool result = await MoveToFirstChildAsync().ConfigureAwait(true);

        //if (result && !ReadMiscNodes)
        //{
        //    // skip miscellaneous node
        //    while (result && IsMiscNode)
        //    {
        //        result = MoveToNextSibling();
        //    }
        //}

        //return result;
        return true;
    }

    private async Task<bool> MoveToNextElementAsync()
    {
        if (_elementState == ElementState.Null)
        {
            return await ReadRootAsync().ConfigureAwait(false);
        }

        return MoveToNextElementHelper();
    }

    private async Task<bool> ReadRootAsync()
    {
        Debug.Assert(_elementState == ElementState.Null);
        Debug.Assert(_elementStack.Count == 0);

        // TODO: should we take care of entity? <!DOCTYPE page [ <!ENTITY company "Microsoft"> ]>
        // TODO: is it OK that we skip all prologue ( DOCTYPE, Comment, PT ) ?
        await _xmlReader.MoveToContentAsync().ConfigureAwait(false);

        while (!_xmlReader.EOF && _xmlReader.NodeType != XmlNodeType.Element)
        {
            await _xmlReader.SkipAsync().ConfigureAwait(false);
        }

        return ReadRootHelper();
    }
#endif
}
