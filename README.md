# Flyff Universe Launcher!
* Uses libraries:
  * [Microsoft WebView2](https://docs.microsoft.com/en-us/microsoft-edge/webview2/)
  * [TsadriuUtilities](https://github.com/Tsadriu/TsadriuUtilities)

##  Features 
* Ability to launch the game with different profiles! You no longer have to use different browsers!
* Each profile can be set a custom resolution.
* Pressing **F11** will enable full screen. The only way to remove the full screen is to press it again (*Escape users rejoice!*).
* Pressing **HOME** will show/hide a toolbar. Said toolbar provides shortcuts to the flyff's wikis, and other useful websites.

##  License
GPL-3.0

## Release 1.8.0
* Updated project `.NET` version from `.NET 6.0` to `.NET 8.0`
* Fixed flickering of the ``Profile Settings``, and ``Manage Profiles`` when hovering with the mouse.
* Removed news webpage.
  * Because of this, the size of the launcher is also smaller.
* Removed the `Flyffulator` shortcut since the website doesn't work anymore.
* Implemented a new way to make ``New profiles``, simplifying the process.
* Moved toolbar from the top to the left.
  * Toolbar now automatically hides after pressing a shortcut.
  * Implemented ``Flyff.Me`` shortcut, which has a madrigal map with all enemies info + where the player should farm to get the most experience.
* Button ``Delete this profile`` and ``Delete all profiles`` now properly delete the selected/all profiles, instead of launching an exception.
  * This also includes the "simulated" browser page, which also reduces the size occupied by the program.

## Release 1.7.1
* Fixed an issue where the *Manage profiles* tab could not save the new changes to a profile.

## Release 1.7.0
* Implemented *Manage profiles* tab to change stuff about a selected profile.
* Implemented *Full screen* in the *Window Settings* tab.

## Release 1.6.0
* Implemented button *Close news tab* to improve performance. Pressing this button will dispose the news section and can only be accessed again by closing and opening the program.
* Implemented button *Frozen game? Click here* in the utility toolbar. If your game got stuck loading into an area or just isn't responding, click this button.

## Release 1.5.0
* Changed utility toolbar key-binding from *F1* to *Home*.
* Fixed an issue where trying to top-up would result in a "Your browser is out of date!" error.

## Release 1.4.0
* Added utility toolbar to quickly access the wikis.

## Release 1.3.2
* Fixed an issue where the user's preferred resolution was not being correctly saved.

## Release 1.3.1
* Updates the location of the saved launcher data.

## Release 1.3.0
* Added icons to the program.
* Renamed the folder *Users* to *Profiles* to avoid users thinking that the program is storing the flyff's account information.
* Added random cycling background images to the launcher.
* Removed the resize window option from the launcher.
* Removed *Launch game* from the game's window and will now automatically launch after selecting a profile.
* Fixed bug where the game's window form would not update correctly the first time the game was launched.
* Both launcher and game window will now start at the center of the selected screen.

## Release 1.2.0
* Implemented full-screen by pressing *F11*.

## Release 1.1.0
* After pressing 'Launch game' the button will hide itself and the window will be maximized.

## Release 1.0.0
* Initial release of the client.