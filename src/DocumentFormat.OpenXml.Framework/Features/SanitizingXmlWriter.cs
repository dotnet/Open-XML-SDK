// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;
#if FEATURE_ASYNC_SAX_XML
using System.Threading.Tasks;
#endif

namespace DocumentFormat.OpenXml.Features;

internal sealed class SanitizingXmlWriter : XmlWriter
{
    private readonly XmlWriter _inner;

    public SanitizingXmlWriter(XmlWriter inner)
    {
        _inner = inner;
    }

    public override WriteState WriteState => _inner.WriteState;

    public override XmlWriterSettings? Settings => _inner.Settings;

    public override string? XmlLang => _inner.XmlLang;

    public override XmlSpace XmlSpace => _inner.XmlSpace;

    public override void Flush() => _inner.Flush();

    public override string? LookupPrefix(string ns) => _inner.LookupPrefix(ns);

    public override void WriteStartDocument() => _inner.WriteStartDocument();

    public override void WriteStartDocument(bool standalone) => _inner.WriteStartDocument(standalone);

    public override void WriteEndDocument() => _inner.WriteEndDocument();

    public override void WriteDocType(string name, string? pubid, string? sysid, string? subset)
        => _inner.WriteDocType(name, pubid, sysid, subset);

    public override void WriteStartElement(string? prefix, string localName, string? ns)
        => _inner.WriteStartElement(prefix, localName, ns);

    public override void WriteEndElement() => _inner.WriteEndElement();

    public override void WriteFullEndElement() => _inner.WriteFullEndElement();

    public override void WriteStartAttribute(string? prefix, string localName, string? ns)
        => _inner.WriteStartAttribute(prefix, localName, ns);

    public override void WriteEndAttribute() => _inner.WriteEndAttribute();

    public override void WriteEntityRef(string name) => _inner.WriteEntityRef(name);

    public override void WriteBase64(byte[] buffer, int index, int count)
        => _inner.WriteBase64(buffer, index, count);

    public override void WriteRaw(string data) => _inner.WriteRaw(data);

    public override void WriteRaw(char[] buffer, int index, int count)
        => _inner.WriteRaw(buffer, index, count);

    public override void WriteString(string? text)
        => _inner.WriteString(XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override void WriteCData(string? text)
        => _inner.WriteCData(XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override void WriteComment(string? text)
        => _inner.WriteComment(XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override void WriteProcessingInstruction(string name, string? text)
        => _inner.WriteProcessingInstruction(name, XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override void WriteWhitespace(string? ws)
        => _inner.WriteWhitespace(XmlCharacterSanitizer.SanitizeIfNeeded(ws));

    public override void WriteCharEntity(char ch)
    {
        if (XmlCharacterSanitizer.IsValidXmlChar(ch))
        {
            _inner.WriteCharEntity(ch);
        }
    }

    public override void WriteSurrogateCharEntity(char lowChar, char highChar)
    {
        if (char.IsHighSurrogate(highChar) && char.IsLowSurrogate(lowChar))
        {
            _inner.WriteSurrogateCharEntity(lowChar, highChar);
        }
    }

    public override void WriteChars(char[] buffer, int index, int count)
    {
        if (buffer is null)
        {
            throw new ArgumentNullException(nameof(buffer));
        }

        if (XmlCharacterSanitizer.TrySanitizeSpan(buffer, index, count, out var resultBuffer, out var resultCount))
        {
            if (resultCount > 0)
            {
                _inner.WriteChars(resultBuffer, 0, resultCount);
            }
        }
        else
        {
            _inner.WriteChars(buffer, index, count);
        }
    }

    public override void WriteName(string name) => _inner.WriteName(name);

    public override void WriteNmToken(string name) => _inner.WriteNmToken(name);

    public override void WriteQualifiedName(string localName, string? ns) => _inner.WriteQualifiedName(localName, ns);

    public override void Close() => _inner.Close();

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (disposing)
        {
#if NET35 || NET40
            ((IDisposable)_inner).Dispose();
#else
            _inner.Dispose();
#endif
        }
    }

#if FEATURE_ASYNC_SAX_XML
    public override Task FlushAsync() => _inner.FlushAsync();

    public override Task WriteStartDocumentAsync() => _inner.WriteStartDocumentAsync();

    public override Task WriteStartDocumentAsync(bool standalone) => _inner.WriteStartDocumentAsync(standalone);

    public override Task WriteEndDocumentAsync() => _inner.WriteEndDocumentAsync();

    public override Task WriteDocTypeAsync(string name, string? pubid, string? sysid, string? subset)
        => _inner.WriteDocTypeAsync(name, pubid, sysid, subset);

    public override Task WriteStartElementAsync(string? prefix, string localName, string? ns)
        => _inner.WriteStartElementAsync(prefix, localName, ns);

    public override Task WriteEndElementAsync() => _inner.WriteEndElementAsync();

    public override Task WriteFullEndElementAsync() => _inner.WriteFullEndElementAsync();

    protected override Task WriteStartAttributeAsync(string? prefix, string localName, string? ns)
    {
        // WriteStartAttributeAsync is protected internal, so it cannot be called on a base
        // XmlWriter reference. The sync equivalent only updates the writer's state machine
        // (no I/O), so it's safe to invoke here.
        _inner.WriteStartAttribute(prefix, localName, ns);
        return Task.CompletedTask;
    }

    protected override Task WriteEndAttributeAsync()
    {
        _inner.WriteEndAttribute();
        return Task.CompletedTask;
    }

    public override Task WriteStringAsync(string? text)
        => _inner.WriteStringAsync(XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override Task WriteCDataAsync(string? text)
        => _inner.WriteCDataAsync(XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override Task WriteCommentAsync(string? text)
        => _inner.WriteCommentAsync(XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override Task WriteProcessingInstructionAsync(string name, string? text)
        => _inner.WriteProcessingInstructionAsync(name, XmlCharacterSanitizer.SanitizeIfNeeded(text));

    public override Task WriteWhitespaceAsync(string? ws)
        => _inner.WriteWhitespaceAsync(XmlCharacterSanitizer.SanitizeIfNeeded(ws));

    public override Task WriteCharEntityAsync(char ch)
        => XmlCharacterSanitizer.IsValidXmlChar(ch) ? _inner.WriteCharEntityAsync(ch) : Task.CompletedTask;

    public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
    {
        if (char.IsHighSurrogate(highChar) && char.IsLowSurrogate(lowChar))
        {
            return _inner.WriteSurrogateCharEntityAsync(lowChar, highChar);
        }

        return Task.CompletedTask;
    }

    public override Task WriteCharsAsync(char[] buffer, int index, int count)
    {
        if (buffer is null)
        {
            throw new ArgumentNullException(nameof(buffer));
        }

        if (XmlCharacterSanitizer.TrySanitizeSpan(buffer, index, count, out var resultBuffer, out var resultCount))
        {
            return resultCount > 0 ? _inner.WriteCharsAsync(resultBuffer, 0, resultCount) : Task.CompletedTask;
        }

        return _inner.WriteCharsAsync(buffer, index, count);
    }

    public override Task WriteRawAsync(string data) => _inner.WriteRawAsync(data);

    public override Task WriteRawAsync(char[] buffer, int index, int count)
        => _inner.WriteRawAsync(buffer, index, count);

    public override Task WriteBase64Async(byte[] buffer, int index, int count)
        => _inner.WriteBase64Async(buffer, index, count);

    public override Task WriteEntityRefAsync(string name) => _inner.WriteEntityRefAsync(name);

    public override Task WriteNameAsync(string name) => _inner.WriteNameAsync(name);

    public override Task WriteNmTokenAsync(string name) => _inner.WriteNmTokenAsync(name);

    public override Task WriteQualifiedNameAsync(string localName, string? ns) => _inner.WriteQualifiedNameAsync(localName, ns);
#endif
}
