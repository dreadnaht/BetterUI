# BetterUI V1.0.0 - LessonLethal | CLIENT SIDE 🎈

[![Latest Version](https://img.shields.io/thunderstore/v/LessonLethal/BetterUI?logo=thunderstore&logoColor=white)](https://thunderstore.io/c/lethal-company/p/LessonLethal/BetterUI)
[![Total Downloads](https://img.shields.io/thunderstore/dt/LessonLethal/BetterUI?logo=thunderstore&logoColor=white)](https://thunderstore.io/c/lethal-company/p/LessonLethal/BetterUI)

![Icon](https://i.imgur.com/5q7PhSA.png)

Makes several improvements to the UI and an addition performance boost. Set hotkeys to toggle on and off the HUD, FPS, or Clock. Chat will fade out when not being used. View the clock while inside a building or the ship.

# FEATURES 📃

### 👉 UI/HUD
You can toggle on and off the visibility of all UI elements on the screen, with the push of a hotkey that you can set.

```Default Hotkey: Keypad7```

### 👉 FPS
  Adds a FPS monitor/counter to the top right corner of the screen that is simple and small. You can toggle it on and off with the push of a hotkey that you can set. It's off by default.
  
```Default Hotkey: Keypad8```

### 👉 CLOCK
By default, a player can only see the time of day when outside on a moon. With the push of a key, this toggles the clocks visibility when you're inside a facility, mansion, or ship between 0% visibility (vanilla) and 30% visibility. *By default it's 0% visibility (vanilla) until you turn it on with hotkey.*

```Default Hotkey: Keypad9```

### 👉 CHAT
Changes the chat area to fade out when not being used. It will appear again if you recieve or want to send a message. *The chat area is affect when you toggle the hotkey for UI/HUD visibility.*

### 👉 PERFORMANCE
Turns off vSync and sets max FPS to 500. (I'm working on adding these as options in the config)

# CONFIGURATION ⚙
### Run the game once after installing this mod for it to create the config file.
#### Open ```BepInEx/config/LessonLethal.BetterUI.cfg``` with a text editor.

```
HUDKeybind - Hotkey to toggle the visibility of all UI elements on your screen.
Default value: Keypad7
```

```
FPSKeybind - Hotkey to toggle the visibility of a simple FPS monitor located top right.
(FPS monitor/counter hidden by default)
Default value: Keypad8
```

```
ClockKeybind - Hotkey to toggle the visibility of the clock when you're inside the facility, mansion, or ship. 
(Clock hidden by default inside the facility, mansion, or ship)
Default value: Keypad9
```

# Installation 🛠

## R2ModMan or Thunderstore Manager (highly recommended)

### R2ModMan
1. Go to the [thunderstore page](https://thunderstore.io/c/lethal-company/p/LessonLethal/BetterUI/)
2. Click `Install with Mod Manager`

### Thunderstore Manager
(if the above doesn't work for you, open up the Thunderstore App to do the following)
1. Click `Get mods`/`Online` (whatever it happens to be called)
2. Search for BetterUI
3. Download it

## Manual
1. Go to the [thunderstore page](https://thunderstore.io/c/lethal-company/p/LessonLethal/BetterUI/)
2. Click `Manual Download`
3. Unzip files
4. Navigate to `LessonLethal-BetterUI-VERSION/BepinEx/plugins` and copy the contents
5. Find your BepinEx installation's plugin folder, by default it would be in steamapps: `steamapps\common\Lethal Company\BepInEx\plugins`
6. Create a folder titled `LessonLethal-BetterUI`
7. Paste the contents into that folder

If you did all of this correctly, it should load properly.

The resulting file structure should look like this:
```
BepinEx
├───cache
├───config
├───core
├───patchers
└───plugins
    └───LessonLethal-BetterUI
        └───BetterUI.dll
```

# TODO 📝
- Add a list to this readme of all keyboard shortcuts that can be used when setting hotkeys.
  - Make the mod do a check for those inputs.
- Add addition performance boosts.
  - More to come on that...
- Add support for [InputUtils](https://thunderstore.io/c/lethal-company/p/Rune580/LethalCompany_InputUtils/)


# Contact
Discord: @[tyleroutcast](https://discord.com/users/235518194612305920)

# Credits
Thanks to the following who inspired this project:
- [BlueAmulet](https://thunderstore.io/c/lethal-company/p/BlueAmulet/)
- [Cookies](https://thunderstore.io/c/lethal-company/p/Cookies/)
- [Monkeytype](https://thunderstore.io/c/lethal-company/p/Monkeytype/)
- [Solar32](https://thunderstore.io/c/lethal-company/p/Solar32/)
