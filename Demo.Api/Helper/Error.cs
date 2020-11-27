using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Demo.Api.Helper
{
    public  static class Error
    {
        private static string AppDrive = HttpRuntime.AppDomainAppPath;
        public static void ErrorLog(string fileName, string message)
        {
            string path = AppDrive+"Log/" + fileName + ".txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(message);
                }
            }
        }
    }
}