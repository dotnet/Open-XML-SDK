﻿using System;
using System.IO;

namespace Common
{
    public class Utilities
    {
        public static void ShowHelp(string[] helpMessages) { 
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