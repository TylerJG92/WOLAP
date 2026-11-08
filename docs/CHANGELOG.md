# Changelog for v0.4.0

## Client Changes:

* Added popup dialog to lock check `Fort Cowardice - Pie Safe` behind a selection to avoid accidental check not sending
* Shortened the `El Vibrato Cylinder` location names to abbriviations to avoid truncation
* Fixed a bug where if the `Letter to Roy` is given to Roy before going to the postal station, it locks the player out of the first paperstack's check
* Added a fallback in one of the ghostwood quests for if the player is at logging quest progression 2 and dosent have the visitor permit.
* Added missed shop price Variety that is based now on AP Item flags.
* Added Can of Kerosene to Dirtwater Mercantile
* Added ability to find `Lost Dutch Oven Mine` from Wandering Region C
* Fixed a bug that still allowed pete (and also random map unlock's sometimes) to override the `Region D - 3rd encounter` check location
* Changed `Strange Stone Arrow`, `El Vibrato Transponder` and `El Vibrato Device` to new `Progressive El Vibrato Device`
* Changed all 3 `El Vibrato Cylinder` items into a single `Progressive El Vibrato Cylinder` item

## AP World Changes:

* Fixed Dirtwater shops logic to include indirect conditions so they realize they are in logic on time
* Fixed `Ghostwood Office Supply - Stapler` Logic to now ALSO check for `Ghostwood Visitor's ID`
* Added logic to `Gustavson Gulch Destroyed - Dynamite Crate` to include an `or player has Gustavson Gulch Treasure Cave Key` since it will be forwarded to the missed shop when the player goes to collect the treasure from the cave.
* Removed Item `PotempkinRemains Of The Potemkin Gang` from item pool as the reason it was there in the first place was proven wrong.
* Updated `El Vibrato Fluid x5` to progressive and made the vending machine checks require them to be given to the player to become in logic.
* Reverted access rule for `Tony's Boots` to no longer look at the mushroom map to see if it is in logic.
* Removed Logic requirement for `Deepest Delve Mine` that requires `Can of Kerosene`
* Changed `Can of Kerosene` from a progression item to filler
* Updated `Cheap Cigar` to `Cheap Cigar X3` for extra stench resistance/quest progressions
* Updated `Lost Dutch Oven Mine`'s Region access for better logic
* Fixed a bug where the helper `can_get_breadwood_lumber` was looking for `Overdue Breadwood Book x5` when it should have been looking for `Breadwood Bread Bowl x5`
* Updated all mention of `Strange Stone Arrow`, `El Vibrato Transponder` and `El Vibrato Device` with the new `Progressive El Vibrato Device` items
* Changed all 3 `El Vibrato Cylinder` items into a single `Progressive El Vibrato Cylinder` item for smoother logic.