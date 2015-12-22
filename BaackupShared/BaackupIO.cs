#region GNU License

/*
 *  Baackup - The free and open source Minecraft server backup program.
 *  Copyright (C) 2016  Hayden (Technoguyfication) Andreyka
 *
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License along
 *  with this program; if not, write to the Free Software Foundation, Inc.,
 *  51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 */

#endregion

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
