# Baackup
A backup script for our Minecraft server, sponsored by sheep

<sub>It's sponsored by sheep because it's called **baa**ckup :wink:</sub>


<img src="http://orig10.deviantart.net/8887/f/2013/346/f/1/disco_sheep_by_lockrikard-d6xo4oa.gif" alt="Disco Sheep" />


##How 2 use lè baackup script

1. Either clone the repo to your client, download the zip, or download the latest release if stability is your thing
2. Add the script to the root folder of your server (the one with your JAR file and such)
3. If you use Essentials, just set the ```command``` value of the ```backup``` section in your ```config.yml``` to 'baackup.bat', otherwise, just set it up to run automatically using Task Scheduler or something.
5. The first time it runs it will ask your to input your configuration settings. You can safely run this by simply right clicking it the first time you install it.
6. Please note: If you have RCON disabled, this script will not automatically ```save-all``` and toggle ```save-off```, ```save-on``` for you. Essentials will automatically do this but you should check either with your plugin details or edit the batch file to do it for you.
7. Now just run the script on a timer or whatnot, please note that server sizes can be very big and it is up to you how often you want it to back up. Depending on your server size and hardware, it may take a long time to do the backup, especially if you have compression enabled.
