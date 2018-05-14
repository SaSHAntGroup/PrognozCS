using System;
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
            string filePathInApp = Application.StartupPath + @"\Cache\Data.gmdb";
            string filePathInOS = @"C:\Users\" + Environment.UserName
                + @"\AppData\Local\GMap.NET\TileDBv5\en\Data.gmdb";

            if (!CheckCache(filePathInOS))
                File.Copy(filePathInApp, filePathInOS, true);
        }
    }
}