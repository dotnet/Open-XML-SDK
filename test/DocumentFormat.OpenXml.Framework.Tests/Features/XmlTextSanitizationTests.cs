// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Text;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests;

public partial class XmlTextSanitizationTests
{
    [Fact]
    public void SanitizeIfNeeded_Null_ReturnsNull()
    {
        Assert.Null(XmlCharacterSanitizer.SanitizeIfNeeded(null));
    }

    [Fact]
    public void SanitizeIfNeeded_Empty_ReturnsEmpty()
    {
        Assert.Same(string.Empty, XmlCharacterSanitizer.SanitizeIfNeeded(string.Empty));
    }

    [Fact]
    public void SanitizeIfNeeded_AllValid_ReturnsSameReference()
    {
        var input = "Hello, world! Tabs\tnewlines\nand returns\r are fine.";
        Assert.Same(input, XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_SingleControlChar_IsStripped()
    {
        var input = "valid\u0002text";
        Assert.Equal("validtext", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_LeadingControlChar_IsStripped()
    {
        Assert.Equal("abc", XmlCharacterSanitizer.SanitizeIfNeeded("\u0001abc"));
    }

    [Fact]
    public void SanitizeIfNeeded_TrailingControlChar_IsStripped()
    {
        Assert.Equal("abc", XmlCharacterSanitizer.SanitizeIfNeeded("abc\u001f"));
    }

    [Fact]
    public void SanitizeIfNeeded_MultipleControlChars_AllStripped()
    {
        var input = "a\u0001b\u0002c\u001fd";
        Assert.Equal("abcd", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_TabNewlineCarriageReturn_Preserved()
    {
        var input = "a\tb\nc\rd";
        Assert.Same(input, XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_ValidSurrogatePair_Preserved()
    {
        // U+1F600 grinning face emoji
        var input = "hi\uD83D\uDE00!";
        Assert.Same(input, XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_OrphanedHighSurrogate_Stripped()
    {
        var input = "start\uD83Dend";
        Assert.Equal("startend", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_OrphanedLowSurrogate_Stripped()
    {
        var input = "start\uDE00end";
        Assert.Equal("startend", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_NonCharacterFFFE_Stripped()
    {
        var input = "a\uFFFEb";
        Assert.Equal("ab", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_NonCharacterFFFF_Stripped()
    {
        var input = "a\uFFFFb";
        Assert.Equal("ab", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void IsValidXmlChar_KnownValid_ReturnsTrue()
    {
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\t'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\n'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\r'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar(' '));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('A'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\uD7FF'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\uE000'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\uFFFD'));
    }

    [Fact]
    public void IsValidXmlChar_KnownInvalid_ReturnsFalse()
    {
        for (var c = '\u0000'; c < '\u0020'; c++)
        {
            if (c == '\t' || c == '\n' || c == '\r')
            {
                continue;
            }

            Assert.False(XmlCharacterSanitizer.IsValidXmlChar(c), $"Expected 0x{(int)c:X4} to be invalid");
        }

        Assert.False(XmlCharacterSanitizer.IsValidXmlChar('\uFFFE'));
        Assert.False(XmlCharacterSanitizer.IsValidXmlChar('\uFFFF'));
    }

    [Fact]
    public void UseXmlTextSanitization_NullPackage_Throws()
    {
        OpenXmlPackage? package = null;
        Assert.Throws<ArgumentNullException>(() => package!.UseXmlTextSanitization());
    }

    [Fact]
    public void SanitizingWriter_WriteString_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteString("a\u0002b");
            writer.WriteEndElement();
        });

        Assert.Contains("<r>ab</r>", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteAttributeString_StripsInvalidCharsInValue()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteAttributeString("name", "bad\u0003value");
            writer.WriteEndElement();
        });

        Assert.Contains("name=\"badvalue\"", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteCData_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteCData("data\u0002more");
            writer.WriteEndElement();
        });

        Assert.Contains("<![CDATA[datamore]]>", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteComment_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteComment("hello\u0004world");
            writer.WriteEndElement();
        });

        Assert.Contains("<!--helloworld-->", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteChars_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            var chars = "a\u0002b".ToCharArray();
            writer.WriteChars(chars, 0, chars.Length);
            writer.WriteEndElement();
        });

        Assert.Contains("<r>ab</r>", xml);
    }

    [Fact]
    public void SanitizingWriter_Raw_IsNotSanitized()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteRaw("<child>valid</child>");
            writer.WriteEndElement();
        });

        Assert.Contains("<r><child>valid</child></r>", xml);
    }

    [Fact]
    public void SanitizingWriter_ElementNameWithInvalidChar_StillThrows()
    {
        // Element names are structural and must still reject invalid chars.
        Assert.ThrowsAny<Exception>(() =>
        {
            WriteTestXml(writer =>
            {
                writer.WriteStartElement("bad\u0002name");
                writer.WriteEndElement();
            });
        });
    }

    private static string WriteTestXml(Action<XmlWriter> action)
    {
        var output = new MemoryStream();
        var factory = SanitizingXmlWriterFactoryFeature.Instance;
        var settings = new XmlWriterSettings
        {
            Encoding = Encoding.UTF8,
            OmitXmlDeclaration = true,
            CloseOutput = false,
        };

        using (var writer = factory.Create(output, settings))
        {
            action(writer);
            writer.Flush();
        }

        return Encoding.UTF8.GetString(output.ToArray());
    }
}
