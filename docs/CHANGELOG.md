# Changelog for v0.4.0

## Client Changes:

* Added popup dialog to lock check `Fort Cowardice - Pie Safe` behind a selection to avoid accidental check not sending
* Shortened the `El Vibrato Cylinder` location names to abbriviations to avoid truncation

## AP World Changes:

* Fixed Dirtwater shops logic to include indirect conditions so they realize they are in logic on time
* Fixed `Ghostwood Office Supply - Stapler` Logic to now ALSO check for `Ghostwood Visitor's ID`
* Added logic to `Gustavson Gulch Destroyed - Dynamite Crate` to include an `or player has Gustavson Gulch Treasure Cave Key` since it will be forwarded to the missed shop when the player goes to collect the treasure from the cave.
* Removed Item `PotempkinRemains Of The Potemkin Gang` from item pool as the reason it was there in the first place was proven wrong.
