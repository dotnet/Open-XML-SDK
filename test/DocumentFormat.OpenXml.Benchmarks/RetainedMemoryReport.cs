// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace DocumentFormat.OpenXml.Benchmarks;

/// <summary>
/// Measures how much managed memory a loaded worksheet DOM retains, which BenchmarkDotNet's
/// <c>MemoryDiagnoser</c> does not report. Run with: <c>retained [rows...] [--wait]</c>.
/// <c>--wait</c> pauses with the DOM alive so a heap snapshot can be taken (e.g. <c>dotnet-gcdump</c>).
/// </summary>
internal static class RetainedMemoryReport
{
    public static void Run(string[] args)
    {
        var wait = Array.IndexOf(args, "--wait") >= 0;
        var rows = new System.Collections.Generic.List<int>();

        foreach (var arg in args)
        {
            if (int.TryParse(arg, NumberStyles.Integer, CultureInfo.InvariantCulture, out var r))
            {
                rows.Add(r);
            }
        }

        if (rows.Count == 0)
        {
            rows.AddRange(new[] { 5_000, 20_000, 50_000 });
        }

        Console.WriteLine("| Rows | Worksheet XML (MB) | Retained (MB) | Retained / XML | Elements | Bytes / element |");
        Console.WriteLine("|-----:|-------------------:|--------------:|---------------:|---------:|----------------:|");

        foreach (var count in rows)
        {
            Measure(count, wait);
        }
    }

    private static void Measure(int rows, bool wait)
    {
        var package = LargeWorksheetBenchmarks.CreatePackage(rows);

        using var stream = new MemoryStream(package, writable: false);
        using var document = SpreadsheetDocument.Open(stream, false);
        var part = LargeWorksheetBenchmarks.GetWorksheetPart(document);

        long xmlBytes;
        using (var partStream = part.GetStream())
        {
            xmlBytes = CountBytes(partStream);
        }

        var before = GC.GetTotalMemory(forceFullCollection: true);
        var worksheet = part.Worksheet;
        var after = GC.GetTotalMemory(forceFullCollection: true);

        var elements = 0L;
        foreach (var unused in worksheet.Descendants())
        {
            elements++;
        }

        var retained = after - before;

        Console.WriteLine(string.Format(
            CultureInfo.InvariantCulture,
            "| {0:N0} | {1:F1} | {2:F1} | {3:F1}x | {4:N0} | {5:F0} |",
            rows,
            xmlBytes / 1048576.0,
            retained / 1048576.0,
            (double)retained / xmlBytes,
            elements,
            (double)retained / elements));

        if (wait)
        {
            Console.WriteLine($"PID {Process.GetCurrentProcess().Id}: DOM for {rows:N0} rows is alive. Press Enter to continue.");
            Console.ReadLine();
        }

        GC.KeepAlive(worksheet);
    }

    private static long CountBytes(Stream stream)
    {
        var buffer = new byte[81920];
        long total = 0;
        int read;

        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            total += read;
        }

        return total;
    }
}
