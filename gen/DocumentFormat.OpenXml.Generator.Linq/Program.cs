// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using CommandLine;

#nullable enable

namespace DocumentFormat.OpenXml.Generator.Linq;

public static class Program
{
    /// <summary>
    /// Main entry point for the LINQ to XML generator.
    /// </summary>
    /// <remarks>
    /// The generator produces C# code by default. You can use the <code>--ts</code> option
    /// to produce TypeScript code instead. In any case, you must specify the output directory,
    /// using the required <code>--outDir</code> option.
    /// </remarks>
    /// <example>
    /// <para>The following command generates C# classes in the <code>.\cs</code> directory:</para>
    /// <code>.\DocumentFormat.OpenXml.Generator.Linq.exe --outDir .\cs</code>
    /// <para>The following command generates TypeScript classes in the <code>.\ts</code> directory:</para>
    /// <code>.\DocumentFormat.OpenXml.Generator.Linq.exe --outDir .\ts --ts</code>
    /// </example>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                if (options.IsTypeScript)
                {
                    TypeScriptGenerator.Generate(options.DirectoryName);
                }
                else
                {
                    CSharpGenerator.Generate(options.DirectoryName);
                }
            });
    }

    /// <summary>
    /// Command line options.
    /// </summary>
    public class Options
    {
        [Option("outDir", Required = true, HelpText = "Specifies the output directory.")]
        public string DirectoryName { get; set; } = null!;

        [Option("ts", Default = false, Required = false, HelpText = "Selects TypeScript instead of C# as the output language.")]
        public bool IsTypeScript { get; set; }
    }
}
