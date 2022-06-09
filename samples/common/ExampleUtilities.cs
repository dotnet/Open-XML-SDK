// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace Common
{
    public class ExampleUtilities
    {
        public static void ShowHelp(string[] helpMessages)
        {
            foreach (string message in helpMessages)
            {
                Console.WriteLine(message);
            }
        }

        public static bool CheckIfFilesExist(string[] files)
        {
            bool exist = true;

            foreach (string file in files)
            {
                if (!File.Exists(file))
                {
                    Console.Error.WriteLine($"file not found: {file}");
                    exist = false;
                }
            }

            return exist;
        }
    }
}
