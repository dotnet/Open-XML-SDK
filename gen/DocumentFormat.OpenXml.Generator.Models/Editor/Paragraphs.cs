// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections;

namespace DocumentFormat.OpenXml.Generator.Editor;

internal class Paragraphs : IEnumerable<object>
{
    private readonly List<object> _paragraphs = new();

    public Paragraphs(bool includeTagOnFirstItem = true)
    {
        WriteParaTagOnFirstItem = includeTagOnFirstItem;
    }

    public bool WriteParaTagOnFirstItem { get; }

    public void Add(string? paragraph)
    {
        if (!string.IsNullOrEmpty(paragraph))
        {
            _paragraphs.Add(paragraph!);
        }
    }

    public void Add(List<string> list)
    {
        if (list.Count > 0)
        {
            _paragraphs.Add(list);
        }
    }

    public int Count => _paragraphs.Count;

    public IEnumerator<object> GetEnumerator() => _paragraphs.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _paragraphs.GetEnumerator();

    public static implicit operator Paragraphs(string? summary) => new() { summary };
}
