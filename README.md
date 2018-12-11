# PSClassicEdit
Small utility to create a usb drive to add custom games to the ps classic.
This does not edit the PS Classic content instead mounts the content of the USB drive, to switch back to normal simply cicle the PS Classic without the USB drive inserted.
**Based on the work done by https://github.com/pathartl/BleemSync**

## Prerequesites
1. the flash drive has to be formatted in FAT32.
1. Name your flash drive `SONY`.

## Disclaimer
This work is still in progress, use at your own risk

## Game Configuration
example folder structure (the pcsx.cfg file is contained in the release inside: Application Files/Config)
```
Games/
    1/
        GameData
            {disk-ID}.bin
            {disk-ID}.cue
            {disk-ID}.png
            Game.ini
            pcsx.cfg
    2/
        ...
    3/
        ...
```
For the menu to work the Game.ini file must be edited for each game (for multi-disk games add them in the Discs property separated by a ','), Example:
```
[Game]
Discs=SLUS-00067 (name of the .cue)
Title=Castlevania - Symphony Of The Night
Publisher=Konami
Players=1
Year=1997
```
