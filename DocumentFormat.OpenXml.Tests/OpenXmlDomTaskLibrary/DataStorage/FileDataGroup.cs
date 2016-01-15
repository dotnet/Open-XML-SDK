// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage
{
    public class FileDataGroup : ITestDataGroup
    {
        private string id = string.Empty;
        private string description = string.Empty;
        
        private string rootFolder = string.Empty;

        public FileDataGroup(string id, string description, string rootFolder)
        {
            this.id = id;
            this.description = description;
            this.rootFolder = rootFolder;
        }

        public string ID
        {
            get { return this.id; }
        }

        public string Description
        {
            get { return this.description; }
        }

        public List<ITestData> GetEntries()
        {
            string TARGET_FILE_EXTENSIONS = @"*.docx;*.docm;*.dotx;*.dotm;*.xlsx;*.xlsm;*.xltx;*.xltm;*.pptx;*.pptm;*.potx;*.potm;*.ppsx;*.ppsm";
            string[] extensions = TARGET_FILE_EXTENSIONS.Split(new char[] { ';' });
            
            List<ITestData> results = new List<ITestData>();

            foreach (FileInfo fileInfo in this.GetFiles(this.rootFolder, extensions))
            {
                if ((fileInfo.Attributes & FileAttributes.Hidden) == 0)
                {
                    try
                    {
                        results.Add(new FileEntry(fileInfo.FullName));
                    }
                    catch (PathTooLongException)
                    {
                    }
                }
            }

            return results;
        }

        // Search Files in a Single Extension
        private List<FileInfo> GetFiles(string dirPath, string searchFileExtension)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            return Enumerable.ToList(dirInfo.GetFiles(searchFileExtension, SearchOption.AllDirectories));
        }

        // Search Files in Multiple Extensions
        private List<FileInfo> GetFiles(string dirPath, string[] searchFileExtensions)
        {
            List<FileInfo> fileInfos = new List<FileInfo>();

            foreach (string extension in searchFileExtensions)
            {
                fileInfos.AddRange(GetFiles(dirPath, extension).ToArray<FileInfo>());
            }

            return fileInfos;
        }
    }

    public class FileEntry : ITestData
    {
        private string filePath = string.Empty;
        private FileType type = FileType.Unknown;
        private string description = string.Empty;

        public FileEntry(string path)
        {
            try
            {
                this.filePath = path;

                string extension = System.IO.Path.GetExtension(path).ToLowerInvariant();
                switch (extension)
                {
                    case ".docx":
                    case ".docm":
                    case ".dotx":
                    case ".dotm":
                        this.type = FileType.Word;
                        break;
                    case ".xlsx":
                    case ".xlsm":
                    case ".xltx":
                    case ".xltm":
                        this.type = FileType.Excel;
                        break;
                    case ".pptx":
                    case ".pptm":
                    case ".potx":
                    case ".potm":
                    case ".ppsx":
                    case ".ppsm":
                        this.type = FileType.PowerPoint;
                        break;
                }
                
                this.description = this.filePath;
            }
            catch
            {
                this.filePath = string.Empty;
            }
        }

        public FileType Type
        {
            get { return this.type; }
        }

        public string FilePath
        {
            get
            {
                return this.filePath;
            }
        }

        public Stream GetStream()
        {
            throw new NotImplementedException();
        }

        public string Description
        {
            get { return this.description; }
        }
    }
}
