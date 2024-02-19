# BetterUI v1.1.0 - [LessonLethal](https://linktr.ee/lessonlethal)

![Banner](https://i.imgur.com/hjSTjPn.png)

[![Latest Version](https://img.shields.io/thunderstore/v/LessonLethal/BetterUI?logo=thunderstore&logoColor=white)](https://thunderstore.io/c/lethal-company/p/LessonLethal/BetterUI)
[![Total Downloads](https://img.shields.io/thunderstore/dt/LessonLethal/BetterUI?logo=thunderstore&logoColor=white)](https://thunderstore.io/c/lethal-company/p/LessonLethal/BetterUI)

### Custom Settings & Hotkeys for the HUD, FPS, Clock, and Chat

> *Want to ask questions, provide feedback, or contribute? Contact me  [Discord](https://discord.com/users/235518194612305920) or [Github](https://github.com/LessonLethal/BetterUI/issues).*

___

# FEATURES 💡

**COMPATIBILITY:** To deal with mod conflict, every feature in this mod can be individually enabled or disabled.

## 👉 HUD TOGGLE
>  Use this to disable your HUD when you want to take screenshots, video, etc.
- Toggle your HUD ON and OFF with a hotkey.
- Hides the entire HUD, except the visor. Does NOT hide menus.
> ✔️ **ENABLED** by Default. [Visit **Configuration** Section Below](#configuration-)

```Default Hotkey: Keypad7```

## 👉 FPS COUNTER
> View your FPS in a simple and non-intrusive format. 
- Toggle the FPS counter ON and OFF with a hotkey. OFF by default.
- Located at the top right corner of the screen. *Small and white...*
- You can change both the font size and color of the counter.
> ✔️ **ENABLED** by Default. [Visit **Configuration** Section Below](#configuration-)

``` Default Hotkey: Keypad8 ```

## 👉 VIEW CLOCK INSIDE
> A convenient way to view the clock while you're inside a building or ship.
- Toggle the inside clock ON and OFF with a hotkey. OFF by default.
- Affects only the visibility of clock inside the ship or a building.
- Until you use the hotkey, the clock when inside will stay at the vanilla 0% visibility.
- You can change the visibility of the (toggled ON) inside clock. By default it's set to 30% (0.3) visibility.
> ✔️ **ENABLED** by Default. [Visit **Configuration** Section Below](#configuration-)

``` Default Hotkey: Keypad9```

## 👉 REAL TIME CLOCK
> Feature for those who want a smooth clock.
- Change the clock to update in real time, affects appearance only.
- The time shown on the clock will appear to flow smoother because it is being updated much faster.

> ❌ **DISABLED** by Default. [Visit **Configuration** Section Below](#configuration-)

## 👉 CHAT AUTO FADE
> Feature for those who don't want to see the chat box when not using it.
- Changes the chat area to fade out when not being used. 
- It will appear again if you receive or want to send a message.
- The chat area is affected when you toggle the hotkey for UI/HUD visibility.

> ✔️ **ENABLED** by Default. [Visit **Configuration** Section Below](#configuration-)

## 👉 INCREASE TARGET FRAME RATE 
> **Experimental:** Use to increase maximum FPS possible. Not recommended for slower computers. 
- Set Target Frame Rate to 500.
- Set vSync to OFF.
- Shows a wider range with the FPS counter enabled.
- Can affect performance, but not made for that.

> ❌ **DISABLED** by Default. [Visit **Configuration** Section Below](#configuration-)
___
> *Having issues with this mod? Contact me on [Discord](https://discord.com/users/235518194612305920) or [Github](https://github.com/LessonLethal/BetterUI/issues).*
___
___

# CONFIGURATION ⚙

> Having issues with the config file? Try deleting the config file, and then run the game again to create a new config file. 

## ⏭ HUD SETTINGS
- `Enable_HUD` -> Type: Boolean -> Default: `true`
  - `true` -> Enables `HUD_Hotkey`
  - `false` -> Disables `HUD_Hotkey`
- `HUD_Hotkey` -> Type: KeyboardShortcut -> Default: `Keypad7`
  - Visit the [**List of KeyboardShort Values**](#list-of-keyboardshortcut-values-) at bottom of page

## ⏭ FPS SETTINGS
- `Enable_FPS` -> Type: Boolean -> Default: `true`
  - `true` -> Enables `FPS_Hotkey`
  - `false` -> Disables `FPS_Hotkey`
- `FPS_Hotkey` -> Type: KeyboardShortcut -> Default: `Keypad8`
  - Visit the [**List of KeyboardShort Values**](#list-of-keyboardshortcut-values-) at bottom of page
- `FPS_Font_Size` -> Type: Int -> Default: `13`
  - Anywhere between `10` to `18` will work fine
  - Rounded numbers only
- `FPS_Font_Color` -> Type: String -> Default: `#FFFFFF`
  - Visit the [**Google HEX Color Picker**](https://g.co/kgs/Z3zb5f3) for help with color
  
## ⏭ CLOCK SETTINGS
- `Enable_Clock` -> Type: Boolean -> Default: `true`
  - `true` -> Enables `Clock_Hotkey`
  - `false` -> Disables `Clock_Hotkey`
- `Clock_Hotkey` -> Type: KeyboardShortcut -> Default: `Keypad9`
  - Visit the [**List of KeyboardShort Values**](#list-of-keyboardshortcut-values-) at bottom of page
- `Clock_Inside_Visibility` -> Type: Float -> Default: `0.3f`
  - `0f` = 0% Visibility of Inside Clock
  - `0.3f` = 30% Visibility of Inside Clock
  - `0.6f` = 60% Visibility of Inside Clock
  - `1f` = 100% Visibility of Inside Clock
  - You may use other values between `0` and `1` 
  - Be sure to append a `f` at the end of value
- `Real_Time_Clock` -> Type: Boolean -> Default: `false`
  - `true` -> Changes the clock to update faster
  - `false` -> Doesn't affect the clock
  
## ⏭ CHAT SETTINGS
- `Auto_Fade_Chat` -> Type: Boolean -> Default: `true`
  - `true` -> Enables the auto fading chat box
  - `false` -> Doesn't affect the chat box
  
## ⏭ EXPERIMENTAL SETTINGS
- `Frame_Rate_Override` -> Type: Boolean -> Default: `false`
  - `true` -> Sets target frame rate to 500 and turns off vSync
  - `false` -> Doesn't affect any display settings

___

### How To Edit Config File
1. Open the **R2ModMan** program
2. Load the profile with **the mod of the config you want to edit**
3. After profile loads, click `Config editor` in the left side menu
4. Search for `LessonLethal.BetterUI`
5. Click anywhere on the mod name to expand it
5. Click the `Edit Config` button

### How To Delete Config File
1. Complete steps **1 through 5** on the **How To Edit Config File** guide listed above.
2. Select the `Delete` button

**Important Note:** Sometimes after a large update the config file may no longer work correctly and needs to be deleted, and the guide I listed above is an easy way to that. *This is not necessary after every update.*

___
> *Want to ask questions, provide feedback, or contribute? Contact me  [Discord](https://discord.com/users/235518194612305920) or [Github](https://github.com/LessonLethal/BetterUI/issues).*
___
___

# Credits 👑
Thank you to those who have helped, tested, and/or contributed to this mod:
- @paradox75831004 - For testing and providing suggestions to make this mod better

Thank you to the developers who made the mods that inspired this mod:
- [BlueAmulet](https://thunderstore.io/c/lethal-company/p/BlueAmulet/) - LCBetterClock
- [Cookies](https://thunderstore.io/c/lethal-company/p/Cookies/) - NoHUD
- [Monkeytype](https://thunderstore.io/c/lethal-company/p/Monkeytype/) - HideChat
- [Solar32](https://thunderstore.io/c/lethal-company/p/Solar32/) - PerformanceEnhancer

> Please [contact me](https://github.com/LessonLethal) if you would like to update or remove your credit

___

# Contact 📞

**Discord:** [@tyleroutcast](https://discord.com/users/235518194612305920)

**Github:** [@LessonLethal](https://github.com/LessonLethal)

**[My Linktree](https://linktr.ee/lessonlethal)**

___
If you enjoy my mod and want to support future development, [buy me a coffee here.](https://linktr.ee/lessonlethal)
___
___

# TO DO LIST 📝

- ⌨ `Integrate InputUtils`: Add support for the popular mod [InputUtils](https://thunderstore.io/c/lethal-company/p/Rune580/LethalCompany_InputUtils/)
  - The mod adds an interface in the settings menu to change the hotkeys that mods like this create, which normally you can only change in the config.

- ⚡ `Conductivity Indication`: Add two separate ways that you can change the UI to indicate that you're conductive.
  - **HUD Conductivity**: A single indicator to the HUD that will only appear when you are holding a conductive item.
  - **Inventory Conductivity**: A indicator to the icon of any conductive items that are in your inventory.
  - The indicator used should likely be a lightning bolt. For icons the indicator will appear in a corner.
  - This feature would only run when on a moon that has lightning occurring. This would help performance.

- 💰 `Inventory Item Value`: Add the quota value to the items icons in your inventory. *(suggested by @paradox75831004)*
  - The quota value should likely be displayed near the top or the bottom of the icon.

- 🔧 `Custom Positioning`: Add the option to change the position of the HUD elements, in the config. *(suggested by @slashsgt)*
  - Changing a position could be changing the X and Y screen values and/or selecting from a list of predefined areas.

- 🎭 `HUD Styling`: Add the option to change the style of different HUD elements, in the config. 
  - Changing a style would be selecting from a list of predefined styles for each element.

- ❤ `Health Meter`: Add a health meter to the HUD, with custom positioning and alternative styles.
  - This could either be a bar meter or just a number value.

- 🧭 `Compass`: Add a compass, with custom positioning and alternative styles.
  - Fallout style compass. *(suggested by @slashsgt)*

- 😨 `Sanity Meter`: Add a sanity meter to the HUD, with custom positioning and alternative styles.
  - Knowing sanity is useful because a lower sanity you have, the more likely a girl or bracken will target you, and more.
  
***Note:** All features added will be Disabled by default.*
___
> *Want to ask questions, provide feedback, or contribute? Contact me  [Discord](https://discord.com/users/235518194612305920) or [Github](https://github.com/LessonLethal/BetterUI/issues).*
___
___

# Installation ⛓️

> ***Important:** Run the game once after installing this mod for it to create the config file*

## Installing From A Profile: (Option A)
1. **Open the R2ModMan program**
2. Select the profile you want to add this mod to and then click the `Select profile` button
3. On the left side under **MODS** category, click the `Online` option
4. After the mods load on the right, at the top search for `BetterUI`
5. Click anywhere in the  **BetterUI by LessonLethal** mod box to expand the box
6. Click on the `Download` button
7. Click on the `Download with dependencies` button

## Installing From Thunderstore Website: (Option B)
1. [Go to the Thunderstore page for this mod](https://thunderstore.io/c/lethal-company/p/LessonLethal/BetterUI/)
2. Click `Install with Mod Manager`
3. If there is a pop up asking you to *confirm opening a link with r2modman*, click the confirm button
    - In different browsers this pop up will look and be different including the buttons, so instruction may vary
    - If there is no pop up then your browser is preventing it, disable pop up blocker just for the Thunderstore website.
___
> *Having issues with this mod? Contact me on [Discord](https://discord.com/users/235518194612305920) or [Github](https://github.com/LessonLethal/BetterUI/issues).*
___
___

# List of KeyboardShortcut Values ⌨

> [Referenced From This Documentation Page by Unity](https://docs.unity3d.com/ScriptReference/KeyCode.html)

**Use the `Value` column to find the hotkey you want to use then copy and paste the value into the config**

| Value           | Value Description                                                               |
|---------------|---------------------------------------------------------------------------|
| None          | Not assigned (never returned as the result of a keystroke).               |
| Backspace     | The backspace key.                                                       |
| Delete        | The forward delete key.                                                  |
| Tab           | The tab key.                                                             |
| Clear         | The Clear key.                                                           |
| Return        | Return key.                                                              |
| Pause         | Pause on PC machines.                                                    |
| Escape        | Escape key.                                                              |
| Space         | Space key.                                                               |
| Keypad0       | Numeric keypad 0.                                                        |
| Keypad1       | Numeric keypad 1.                                                        |
| Keypad2       | Numeric keypad 2.                                                        |
| Keypad3       | Numeric keypad 3.                                                        |
| Keypad4       | Numeric keypad 4.                                                        |
| Keypad5       | Numeric keypad 5.                                                        |
| Keypad6       | Numeric keypad 6.                                                        |
| Keypad7       | Numeric keypad 7.                                                        |
| Keypad8       | Numeric keypad 8.                                                        |
| Keypad9       | Numeric keypad 9.                                                        |
| KeypadPeriod  | Numeric keypad '.'.                                                      |
| KeypadDivide  | Numeric keypad '/'.                                                      |
| KeypadMultiply| Numeric keypad '*'.                                                      |
| KeypadMinus   | Numeric keypad '-'.                                                      |
| KeypadPlus    | Numeric keypad '+'.                                                      |
| KeypadEnter   | Numeric keypad Enter.                                                    |
| KeypadEquals  | Numeric keypad '='.                                                      |
| UpArrow       | Up arrow key.                                                            |
| DownArrow     | Down arrow key.                                                          |
| RightArrow    | Right arrow key.                                                         |
| LeftArrow     | Left arrow key.                                                          |
| Insert        | Insert key key.                                                          |
| Home          | Home key.                                                                |
| End           | End key.                                                                 |
| PageUp        | Page up.                                                                 |
| PageDown      | Page down.                                                               |
| F1            | F1 function key.                                                         |
| F2            | F2 function key.                                                         |
| F3            | F3 function key.                                                         |
| F4            | F4 function key.                                                         |
| F5            | F5 function key.                                                         |
| F6            | F6 function key.                                                         |
| F7            | F7 function key.                                                         |
| F8            | F8 function key.                                                         |
| F9            | F9 function key.                                                         |
| F10           | F10 function key.                                                        |
| F11           | F11 function key.                                                        |
| F12           | F12 function key.                                                        |
| F13           | F13 function key.                                                        |
| F14           | F14 function key.                                                        |
| F15           | F15 function key.                                                        |
| Alpha0        | The '0' key on the top of the alphanumeric keyboard.                    |
| Alpha1        | The '1' key on the top of the alphanumeric keyboard.                    |
| Alpha2        | The '2' key on the top of the alphanumeric keyboard.                    |
| Alpha3        | The '3' key on the top of the alphanumeric keyboard.                    |
| Alpha4        | The '4' key on the top of the alphanumeric keyboard.                    |
| Alpha5        | The '5' key on the top of the alphanumeric keyboard.                    |
| Alpha6        | The '6' key on the top of the alphanumeric keyboard.                    |
| Alpha7        | The '7' key on the top of the alphanumeric keyboard.                    |
| Alpha8        | The '8' key on the top of the alphanumeric keyboard.                    |
| Alpha9        | The '9' key on the top of the alphanumeric keyboard.                    |
| Exclaim       | Exclamation mark key '!'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha1 instead. |
| DoubleQuote   | Double quote key '"'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Quote instead. |
| Hash          | Hash key '#'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha3 instead. |
| Dollar        | Dollar sign key '$'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha4 instead. |
| Percent       | Percent '%' key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha5 instead. |
| Ampersand     | Ampersand key '&'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha7 instead. |
| Quote         | Quote key '. |
| LeftParen     | Left Parenthesis key '('. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha9 instead. |
| RightParen    | Right Parenthesis key ')'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha0 instead. |
| Asterisk      | Asterisk key '*'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha8 instead. |
| Plus          | Plus key '+'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Equals instead. |
| Comma         | Comma ',' key.                                                           |
| Minus         | Minus '-' key.                                                          |
| Period        | Period '.' key.                                                         |
| Slash         | Slash '/' key.                                                          |
| Colon         | Colon ':' key.Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Semicolon instead. |
| Semicolon     | Semicolon ';' key.                                                      |
| Less          | Less than '<' key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Comma instead. |
| Equals        | Equals '=' key.                                                         |
| Greater       | Greater than '>' key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Period instead. |
| Question      | Question mark '?' key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Slash instead. |
| At            | At key '@'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha2 instead. |
| LeftBracket   | Left square bracket key '['.                                            |
| Backslash     | Backslash key '\'.                                                      |
| RightBracket  | Right square bracket key ']'.                                           |
| Caret         | Caret key '^'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Alpha6 instead. |
| Underscore    | Underscore '_' key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Minus instead. |
| BackQuote     | Back quote key '`'.                                                     |                                                             |
| A                 | 'a' key.                                                                                                                                      |
| B                 | 'b' key.                                                                                                                                      |
| C                 | 'c' key.                                                                                                                                      |
| D                 | 'd' key.                                                                                                                                      |
| E                 | 'e' key.                                                                                                                                      |
| F                 | 'f' key.                                                                                                                                      |
| G                 | 'g' key.                                                                                                                                      |
| H                 | 'h' key.                                                                                                                                      |
| I                 | 'i' key.                                                                                                                                      |
| J                 | 'j' key.                                                                                                                                      |
| K                 | 'k' key.                                                                                                                                      |
| L                 | 'l' key.                                                                                                                                      |
| M                 | 'm' key.                                                                                                                                      |
| N                 | 'n' key.                                                                                                                                      |
| O                 | 'o' key.                                                                                                                                      |
| P                 | 'p' key.                                                                                                                                      |
| Q                 | 'q' key.                                                                                                                                      |
| R                 | 'r' key.                                                                                                                                      |
| S                 | 's' key.                                                                                                                                      |
| T                 | 't' key.                                                                                                                                      |
| U                 | 'u' key.                                                                                                                                      |
| V                 | 'v' key.                                                                                                                                      |
| W                 | 'w' key.                                                                                                                                      |
| X                 | 'x' key.                                                                                                                                      |
| Y                 | 'y' key.                                                                                                                                      |
| Z                 | 'z' key.                                                                                                                                      |
| LeftCurlyBracket   | Left curly bracket key '{'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.LeftBracket instead.    |
| Pipe              | Pipe '|' key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.Backslash instead.                       |
| RightCurlyBracket  | Right curly bracket key '}'. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.RightBracket instead.  |
| Tilde              | Tilde '~' key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.BackQuote instead.                      |
| Numlock           | Numlock key.                                                                                                                                  |
| CapsLock          | Capslock key.                                                                                                                                 |
| ScrollLock        | Scroll lock key.                                                                                                                              |
| RightShift        | Right shift key.                                                                                                                              |
| LeftShift         | Left shift key.                                                                                                                               |
| RightControl      | Right Control key.                                                                                                                            |
| LeftControl       | Left Control key.                                                                                                                             |
| RightAlt          | Right Alt key.                                                                                                                                |
| LeftAlt           | Left Alt key.                                                                                                                                 |
| LeftMeta          | Maps to left Windows key or left Command key if physical keys are enabled in Input Manager settings, otherwise maps to left Command key only. |
| LeftCommand       | Left Command key.                                                                                                                             |
| LeftApple         | Left Command key.                                                                                                                             |
| LeftWindows       | Left Windows key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.LeftMeta instead.                        |
| RightMeta         | Maps to right Windows key or right Command key if physical keys are enabled in Input Manager settings, otherwise maps to right Command key only. |
| RightCommand      | Right Command key.                                                                                                                            |
| RightApple        | Right Command key.                                                                                                                            |
| RightWindows      | Right Windows key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.RightMeta instead.                       |
| AltGr             | Alt Gr key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, use KeyCode.RightAlt instead.                               |
| Help              | Help key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, doesn't map to any physical key.                              |
| Print             | Print key.                                                                                                                                    |
| SysReq            | Sys Req key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, doesn't map to any physical key.                          |
| Break             | Break key. Deprecated if "Use Physical Keys" is enabled in Input Manager settings, doesn't map to any physical key.                             |
| Menu              | Menu key.                                                                                                                                     |
| Mouse0            | The Left (or primary) mouse button.                                                                                                           |
| Mouse1            | Right mouse button (or secondary mouse button).                                                                                               |
| Mouse2            | Middle mouse button (or third button).                                                                                                        |
| Mouse3            | Additional (fourth) mouse button.                                                                                                             |
| Mouse4            | Additional (fifth) mouse button.                                                                                                              |
| Mouse5            | Additional (or sixth) mouse button.                                                                                                           |
| Mouse6            | Additional (or seventh) mouse button.                                                                                                         |
