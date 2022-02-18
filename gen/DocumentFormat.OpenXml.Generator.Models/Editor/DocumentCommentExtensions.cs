// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Editor;

internal static class DocumentCommentExtensions
{
    public static void WriteInheritDoc(this TextWriter writer)
        => writer.WriteLine("/// <inheritdoc/>");

    public static void WriteDocumentationComment(this TextWriter writer, string summary)
        => writer.WriteDocumentationComment(new DocumentCommentOptions { Summary = summary });

    public static void WriteDocumentationComment(this TextWriter writer, DocumentCommentOptions option)
    {
        AddParagraphs("summary", writer, option.Summary);
        AddParagraphs("remark", writer, option.Remarks);

        foreach (var parameter in option.Parameters)
        {
            writer.Write("/// <param name=\"");
            writer.Write(parameter.ParamName);
            writer.Write("\">");
            writer.Write(parameter.Message);
            writer.WriteLine("</param>");
        }

        if (!string.IsNullOrEmpty(option.Return))
        {
            writer.Write("/// <return>");
            writer.Write(option.Return);
            writer.WriteLine("</return>");
        }
    }

    private static void AddParagraphs(string prefix, TextWriter writer, Paragraphs? paragraphs)
    {
        if (paragraphs is null || paragraphs.Count == 0)
        {
            return;
        }

        writer.Write("/// <");
        writer.Write(prefix);
        writer.WriteLine(">");

        var count = 0;

        foreach (var summary in paragraphs)
        {
            var includePara = paragraphs.Count > 1;

            if (count == 0 && !paragraphs.WriteParaTagOnFirstItem)
            {
                includePara = false;
            }

            count++;

            writer.Write("/// ");

            if (summary is string str)
            {
                if (includePara)
                {
                    writer.Write("<para>");
                    writer.Write(str);
                    writer.WriteLine("</para>");
                }
                else
                {
                    writer.WriteLine(str);
                }
            }
            else if (summary is IEnumerable<object> list)
            {
                writer.WriteLine("<list type=\"bullet\">");

                foreach (var item in list)
                {
                    writer.Write("///   <item>");
                    writer.Write(item);
                    writer.WriteLine("</item>");
                }

                writer.WriteLine("/// </list>");
            }
        }

        writer.Write("/// </");
        writer.Write(prefix);
        writer.WriteLine(">");
    }
}
