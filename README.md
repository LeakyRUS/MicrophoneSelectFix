# MicrophoneSelectFix
![FixScreen](https://user-images.githubusercontent.com/20557088/182310596-76a531dc-a8e8-4b79-a2ae-5a334abe459a.png)
A simple ChilloutVR mod that allow you to select 'Default' microphone input setting.

In the current implementation of the game you can change the input device, but you cannot reset the setting.

To reset the setting without installing the mod, follow these steps:
* Close the game;
* Follow the path `%USERPROFILE%\Appdata\LocalLow\Alpha Blend Interactive\ChilloutVR`;
* Open `game.config` with a text editor;
* Find and erase this part of JSON: `{"name":"AudioInputDevice","value":"<YOUR DEVICE>","type":3}`;
* Save.

## Installation
* Install [latest MelonLoader](https://github.com/LavaGang/MelonLoader).
* Download mod from [release page](https://github.com/LeakyRUS/MicrophoneSelectFix/releases).
* Put the MicrophoneSelectFix.dll into `<GameFolder>\Mods`.

## Build
* Install [latest MelonLoader](https://github.com/LavaGang/MelonLoader).
* Fix references in MicrophoneSelectFix.csproj.
* Build.
