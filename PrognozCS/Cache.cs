using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PrognozCS
{
    class Cache
    {
        bool CheckCache(string filePath)
        {
            if (File.Exists(filePath)) return true;
            else return false;
        }

        public void CreateCache()
        {
            string filePathInApp = Application.StartupPath + @"\Cache\GMap.NET";
            string filePathInOS = @"C:\Users\" + Environment.UserName
                + @"\AppData\Local\GMap.NET";

            CreateProcess(filePathInApp, filePathInOS);
        }

        public void CreateProcess(string SourcePath, string DestinationPath)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = @"C:\WINDOWS\system32\xcopy.exe";
            proc.StartInfo.Arguments = $"{SourcePath}\\*.* {DestinationPath}\\*.* /E /I";
            proc.Start();
        }
    }
}