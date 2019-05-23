using System;
using System.IO;

namespace ReflectionAppUI.Core
{
    public class ApplicationPath
    {
        public static string GetPath(string FolderName)
        {
            return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "../../", FolderName));
        }
    }
}
