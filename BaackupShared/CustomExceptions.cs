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

# endregion
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaackupShared
{
    [Serializable]
    public class ConfigNonexistentException : Exception
    {
        public ConfigNonexistentException() { }
        public ConfigNonexistentException(string message) : base(message) { }
        public ConfigNonexistentException(string message, Exception inner) : base(message, inner) { }
        protected ConfigNonexistentException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }

    [Serializable]
    public class ConfigInvalidException : Exception
    {
        public ConfigInvalidException() { }
        public ConfigInvalidException(string message) : base(message) { }
        public ConfigInvalidException(string message, Exception inner) : base(message, inner) { }
        protected ConfigInvalidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }

    [Serializable]
    public class ConfigResetException : Exception
    {
        public ConfigResetException() { }
        public ConfigResetException(string message) : base(message) { }
        public ConfigResetException(string message, Exception inner) : base(message, inner) { }
        protected ConfigResetException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }

    [Serializable]
    public class ConfigNotInitializedException : Exception
    {
        public ConfigNotInitializedException() { }
        public ConfigNotInitializedException(string message) : base(message) { }
        public ConfigNotInitializedException(string message, Exception inner) : base(message, inner) { }
        protected ConfigNotInitializedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
