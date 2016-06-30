# Overwatch Counterpicker #

Automatically generate counterpicks against the enemy team in Overwatch.

This code is licensed under the MIT License.

## About

## Requirements

This project requires the installation of:

 - Windows with [.NET Framework v4.0+](https://www.microsoft.com/en-ca/download/details.aspx?id=17851)

## Editing the Data

The counterpick data can be edited by editing the included data.json file.

The data.json file include is a two-dimensional array *(aka table)* where the rows and columns correspond to the Overwatch heroes in the following order:

 - Genji
 - McCree
 - Pharah
 - Reaper
 - Soldier: 76
 - Tracer
 - Bastion
 - Hanzo
 - Junkrat
 - Mei
 - Torbjorn
 - Widowmaker
 - D.Va
 - Reinhardt
 - Roadhog
 - Winston
 - Zarya
 - Lucio
 - Mercy
 - Symmetra
 - Zenyatta

#### The only accepted values are:
 - -1 (Weak against this hero)
 - 0 (Neutral against this hero)
 - 1 (Strong against this hero)

#### For example...

In the data.json file, line #2:

 - The Player plays as Genji
 - The values correspond to how well the player will do against the other heroes playing as Genji

For line #3, the player now plays McCree.
For line #4, the player plays Pharah instead, etc.

## Downloads
**Latest Version:** ***[vX.X.X.X][Dld_Latest]***

**Release Archive:**

 - [Download Here][Dld_Archive]

## Changelog
[See CHANGELOG.md][CLog.md]

  [CLog.md]: https://github.com/Wassup789/Overwatch-Counterpicker/blob/master/CHANGELOG.md
  [Dld_Archive]: https://goo.gl/ISrSy6
  [Dld_Latest]: https://github.com/Wassup789/Overwatch-Counterpicker/releases