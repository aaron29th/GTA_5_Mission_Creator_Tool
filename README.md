# GTA_5_Mission_Creator_Tool
A tool that allows access to the original unreleased mission creator and the JSON files it creates, showcased here \
https://www.youtube.com/watch?v=TdGU2yg6sr8 \
https://www.youtube.com/watch?v=GUT1DTRTvhQ

## Requirements
- Jailbroken PS3
- GTA 5 - BLES01807

## Setup
The tool requires you play on the original, unupdated game
1. Connect to PS3 using FTP
1. Navigate to `/dev_hdd0/game` this is where all the game updates are stored
1. Rename the folder `BLES01807` to `BLES01807_GTA_5_1_27` this stops the PS3 finding the updates and allows you to switch back to 1.27 without having to reinstall the updates
1. Go to `/dev_hdd0/GAMES/BLES01807-[Grand Theft Auto V]/PS3_GAME/USRDIR` folder copy the `EBOOT.BIN` file to your computer and make the `EBOOT.BIN` a debug EBOOT by following [this video](https://www.youtube.com/watch?v=eXZN3o-l3JU)
1. Rename the existing EBOOT on the ps3 and copy the new debug EBOOT in its place
1. Start GTA, if you encounter infinite loading, try [clearing the cache](https://support.rockstargames.com/articles/115015433628/Clearing-the-Cache-on-your-PS3-console) or using a different game save

## Use
1. Once in story connect, attach and enable interception on the tool
2. Load the missiong creator
3. Create mission
4. Set title and description
5. Attempt to save the mission
6. In the tool click get JSON
