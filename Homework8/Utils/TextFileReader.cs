using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Utils
{
    /// <summary>
    /// Static class that manages the json files in the Directory.
    /// </summary>
    internal static class TextFilereader
    {
        /// <summary>
        /// Directory name.
        /// </summary>
        public static string DirectoryName { get; set; } = "StudentsData";

        /// <summary>
        /// Gets the file text content lines.
        /// </summary>
        /// <param name="fileName">The name of the file (including the extension.</param>
        public static string[] GetFileTextContentLines(string fileName) => File.ReadAllLines(GetFileAbsolutePath(fileName));

        /// <summary>
        /// Gets the file text content.
        /// </summary>
        /// <param name="fileName">The name of the file (including the extension.</param>
        public static string GetFileTextContent(string fileName) => File.ReadAllText(GetFileAbsolutePath(fileName));

        private static string GetFileAbsolutePath(string fileName)
        {
            string directoryPath = GetDirectoryPath(DirectoryName);
            string filePath = $"{directoryPath}\\{fileName}";
            return filePath;
        }

        private static string GetDirectoryPath(string directoryName)
        {
            string relativePath = $"\\{directoryName}";
            string baseDirPath = AppDomain.CurrentDomain.BaseDirectory;
            baseDirPath = baseDirPath.Replace("\\bin\\Debug\\net5.0\\", "");
            string absolutePath = baseDirPath + relativePath;
            return absolutePath;
        }
    }
}
