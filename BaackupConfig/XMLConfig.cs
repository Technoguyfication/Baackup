using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace BaackupConfig
{
    public class XMLConfig
    {
        // Config path
        public static string configfile = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\baackupconfig.xml");

        public static void GenerateDefaultConfig()
        {

        }

        public static bool DoesConfigExist()
        {
            if (File.Exists(configfile))
                return true;
            else
                return false;
        }
    }
}
