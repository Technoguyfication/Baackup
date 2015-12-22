using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaackupShared
{
    public class BaackupIO
    {
        // IOStatus isn't static because we need some sort of root for things

        private string ServerDirectory;

        public BaackupIO(string _ServerDirectory)
        {
            ServerDirectory = _ServerDirectory; // Set the server directory
        }

        /// <summary>
        /// Whether or not a file exists within the server files.
        /// </summary>
        /// <param name="file">File in question</param>
        /// <returns>Whether or not the file was found</returns>
        public bool ServerFileExists(string file)
        {
            return File.Exists(string.Format("{0}\\{1}", ServerDirectory, file));
        }

        /// <summary>
        /// Whether or not a folder exists within the server files
        /// </summary>
        /// <param name="folder">Folder in question</param>
        /// <returns>Whether or not the folder was found</returns>
        public bool ServerFolderExists(string folder)
        {
            return Directory.Exists(string.Format("{0}\\{1}", ServerDirectory, folder));
        }
    }
}
