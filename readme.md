# Marvel's Avengers Tools

This toolkit is meant to simplify the life of Marvel's Avengers players considering all the game-breaking bugs that are occurring, hoping this won't be needed in the future.

### Backup Tool

The backup tool is meant to create backup ZIP archives of your local save directory. It does the following:

* Checks if the folder °c:\MarvelAvengersBackup" exists and if not it creates it.
* Creates a ZIP archive of your game save folder into the backup folder.
* The ZIP created is named after the day/time you created it, so every time it creates a new archive without deleting the old ones.

### Restore Tool

The restore tool works only if you have created at least one backup using the backup tool. It does the following:

* Checks if there's at least one backup.
* If multiple backups are present, it will pick the most recent one.
* It asks you, through a console window, if you're sure to overwrite your local saves with the contents of the backup.
* Pressing "y" will perform the restore. Any other key will close the application without doing nothing.

### Ease of use

To simplify usage, drag both the backup (Iron Man Icon) and the restore (Thor Icon) executables to your windows task bar.
It is recommended, due to the unstable state of the game, to click the "backup icon" every time you close the game.
Use the restore icon only if you get a corrupt save. If you backed up the corrupt save, you can just delete the latest backup and run the restore tool, or just manually open the desired ZIP backup and restore it manually. The game saves are located under c:\users\[your-username]\documents\Marvel's Avengers\[random-number] where random-number is your profile code, the folder that contains all the save files.

Under the release tab there are 4 ZIP archives with the releases:

* Backup and Restore for x-64 Windows versions.
* Backup and Restore for x-86 (32 bit) Windows versions.

No installation is required, just extract the zips in two different folders and run the executables.

If you encounter any problem, be sure to open an issue here detailing the problem so I can fix it.

Enjoy!