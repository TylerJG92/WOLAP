# Changelog for v0.4.0

## Client Changes:

* Added popup dialog to lock check `Fort Cowardice - Pie Safe` behind a selection to avoid accidental check not sending
* Shortened the `El Vibrato Cylinder` location names to abbriviations to avoid truncation
* Fixed a bug where if the `Letter to Roy` is given to Roy before going to the postal station, it locks the player out of the first paperstack's check
* Added a fallback in one of the ghostwood quests for if the player is at logging quest progression 2 and dosent have the visitor permit.

## AP World Changes:

* Fixed Dirtwater shops logic to include indirect conditions so they realize they are in logic on time
* Fixed `Ghostwood Office Supply - Stapler` Logic to now ALSO check for `Ghostwood Visitor's ID`
* Added logic to `Gustavson Gulch Destroyed - Dynamite Crate` to include an `or player has Gustavson Gulch Treasure Cave Key` since it will be forwarded to the missed shop when the player goes to collect the treasure from the cave.
* Removed Item `PotempkinRemains Of The Potemkin Gang` from item pool as the reason it was there in the first place was proven wrong.
* Updated `El Vibrato Fluid x5` to progressive and made the vending machine checks require them to be given to the player to become in logic.
* Reverted access rule for `Tony's Boots` to no longer look at the mushroom map to see if it is in logic.