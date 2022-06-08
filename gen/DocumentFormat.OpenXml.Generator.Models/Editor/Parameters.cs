// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Collections;

namespace DocumentFormat.OpenXml.Generator.Editor;

internal class Parameters : IEnumerable<(string ParamName, string Message)>
{
    private readonly List<(string, string)> _parameters = new();

    public void Add(string name, string message) => _parameters.Add((name, message));

    public int Count => _parameters.Count;

    public IEnumerator<(string ParamName, string Message)> GetEnumerator() => _parameters.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
