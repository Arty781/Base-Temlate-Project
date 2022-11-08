using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Base_Temlate.Helpers
{

    public class OS
    {
        public static dynamic FileExtention()
        {
            string extention = null;

            if (OperatingSystem.IsWindows())
            {
               extention = ".bat";
            }else if (OperatingSystem.IsLinux())
            {
               extention = ".sh";
            }else if (OperatingSystem.IsMacOS())
            {
               extention = ".sh";
            };

            return extention;
        }
    }
    public class Endpoints
    {
        public const string BASE_URL = "http://test-url.com";
    }
}
