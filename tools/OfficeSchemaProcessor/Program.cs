// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Linq;

namespace OfficeSchemaProcessor
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: OfficeSchemaProcessor.exe [path to packages.xsd]");
                return;
            }

            var packageProcessor = new PackageProcessor(args[0]);

            packageProcessor.Process(FindDirectory());
        }

        private static string FindDirectory()
        {
            string CheckParent(string directory)
            {
                if (directory == null)
                {
                    throw new DirectoryNotFoundException("Could not find SDK directory");
                }

                const string SdkPath = "DocumentFormat.OpenXml";

                var hasDocumentFormat = Directory.EnumerateDirectories(directory, SdkPath, SearchOption.TopDirectoryOnly).Any();
                var hasGit = Directory.EnumerateDirectories(directory, ".git", SearchOption.TopDirectoryOnly).Any();

                if (hasDocumentFormat && hasGit)
                {
                    return Path.Combine(directory, SdkPath);
                }

                return CheckParent(Path.GetDirectoryName(directory));
            }

            var path = Path.GetDirectoryName(typeof(Program).Assembly.Location);

            return Path.Combine(CheckParent(path), "GeneratedCode", "Packaging");
        }
    }
}
