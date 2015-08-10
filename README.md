# Baackup
A backup program for Minecraft servers, sponsored by sheep.

<sub>It's sponsored by sheep because it's called **baa**ckup :wink:</sub>


<img src="http://orig10.deviantart.net/8887/f/2013/346/f/1/disco_sheep_by_lockrikard-d6xo4oa.gif" alt="Disco Sheep" />


## How does I use?

1. Download one of the releases or you can build the software with Visual Studio and .NET 4.5
2. Put the "Baackup.exe" and "Baackup.bat" into your server's root directory. (With the server.properties, etc.)
3. Run the "Baackup Config.exe" that was included with the program. (This does not need to be in the server directory.)
4. Using the configuration tool, customize your settings as much as you like. We support Spigot, CraftBukkit, and Vanilla. If you are using a modded server such as Forge we DO NOT backup the "Mods" folder but, depending on your server and the mods on it, we may back up the mod config.
5. Set it to run whenever you want. The plugin *Essentials* has an auto-backup feature. You can find info about that [here](http://wiki.ess3.net/wiki/Backup). (Please note: unless you have the RCON feature set up, we do not automatically ```save-all``` and toggle autosave on your server. **FIND SOMETHING TO DO THIS FOR YOU IF YOU DO NOT USE RCON OR ESSENTIALS, having autosave turned on while backing up can corrupt the backups!**
6. Now just let the program do the work. If you ever need to restore from a backup just open or decompress the files, then pop them back in your server. The backups are stored as (prefix)_yyyy-mm-dd.hh-mm-ss--backup.
