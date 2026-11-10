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
* Changed all items for Curly's Meat Quest into a single `Progressive Curly's Meat` item so player gets them in order
* Changed all Jellybean items (excluding the Honey Jellybean) into a single `Progressive Jellybean` Item so player gets them in order
* Added the code nessecary for the player to be granted the 3 new currency items `5,000 Meat`, `1,000 Meat` and `100 Meat`
* Added Shop Warning for when the player is about to sell an item that is used for progression or needed for checks

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
* Changed all items for Curly's Meat Quest into a single `Progressive Curly's Meat` item so player gets them in order
* Changed all Jellybean items (excluding the Honey Jellybean) into a single `Progressive Jellybean` Item so player gets them in order
* Added 3 new currency items to the pool:
    * `5,000 Meat` is a Deprioritized Progression item, there will be 2 in the pool.
    * `1,000 Meat` is a Useful item, there will always be 3 in the pool
    * `100 Meat` is a filler item, there will always be 5 in the pool but can randomize extras if there is space to do so.