# Overwatch Counterpicker #

Automatically generate counterpicks against the enemy team in Overwatch.

This code is licensed under the MIT License.

## About

[![App Image](https://i.imgur.com/IteY1sY.png)](https://i.imgur.com/IteY1sY.png)

## Requirements

This project requires the installation of:

 - Windows with [.NET Framework v4.0+](https://www.microsoft.com/en-ca/download/details.aspx?id=17851)
 - Recommended, a 1920x1080 monitor (Other resolutions have not been tested yet)

## Regarding Getting Banned
This application simply screenshots the primary monitor (therefore why you have to play in borderless windowed) and separates the screenshot in six images and compares the likeliness of the images to the Overwatch heroes. **This application does not hook to the Overwatch game or the Battle.net client in any way, shape or form.**

## How To Use
1. Set your display mode to: **Borderless Windowed**
2. Launch "Overwatch Counterpicker"
3. Be in-game with the enemy heroes visible in the scoreboard.
4. Hold the scoreboard button.
5. Press the refresh key (Default: G).
6. Enemy heroes should appear in the list view.

(Note: Dead enemy heroes may appear as a different hero. Make sure all enemy heroes are alive)

#### Testing Without the Overwatch Game

1. Launch "Overwatch Counterpicker"
2. Open up an Overwatch screenshot with the scoreboard open and make sure it is in and fits your primary monitor. (Example: [i.imgur.com/iPLJJHS.jpg](https://i.imgur.com/iPLJJHS.jpg)).
3. Set it to fullscreen (F11)
3. Press the refresh key (Default: G).
4. Enemy heroes should appear in the list view.

## Editing the Data

The counterpick data can be edited by launching "Overwatch Picker", and going to: Tools->Edit Data.

The first column will correspond to the hero you will be playing. The other columns will determine how well this hero will do against other heroes.

#### The only accepted values are:
 - -1 (Weak against this hero)
 - 0 (Neutral against this hero)
 - 1 (Strong against this hero)

## Downloads
**Latest Version:** ***[vX.X.X.X][Dld_Latest]***

**Release Archive:**

 - [Download Here][Dld_Archive]

## Changelog
[See CHANGELOG.md][CLog.md]

  [CLog.md]: https://github.com/Wassup789/Overwatch-Counterpicker/blob/master/CHANGELOG.md
  [Dld_Archive]: https://goo.gl/ISrSy6
  [Dld_Latest]: https://github.com/Wassup789/Overwatch-Counterpicker/releases
