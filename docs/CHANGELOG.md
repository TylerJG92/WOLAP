# Changelog for v1.0.0

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
* Added feature where items sold to Lloyd at the Missed shop in his bar get forwarded to the `Dirtwater Mercantile`store to keep the missed item shop decluttered. 
* Added DeathLink features:
    * Added toggle to options to be able to turn on or off DeathLink from within the game
    * If DeathLink is turned on, Player passes a Death to the AP Server whenever they lose a combat or choose to give up a combat.
        * In special events (ie blowing up your dough at Kellog Ranch or Summoning Duke Bovicus in the wrong condition) you will also send a deathlink.
    * When a DeathLink is recieved from the server, the players Anger will rise by 1 as if they lost a combat. If it gets too high the player will pass out and end back up in front of the Dirtwater Jewel.
* Added Misspoint for `Danny's Tannery (St. Rage Shed) - Grady's Cowsbane Seeds` if you send Grady to Dirtwater without asking him about Cowsbane.
* Added Check Locations and Misspoints for new check location `El Vibrato Chamber (Curious False Mountain) - TIMESQUEEZE Cowsbane Seeds`
* Fixed flag routine bug that locked the player out of getting `Jeweler's Cabin - Spectacles` after giving the specticals to the blind soldier in Fort Unnecessary.
* Added `Stardust` as an item in the item pool to be used for the `Dave B Defeated` check location.
    * Added a fallback to use if Dave B has not been defeated yet, it will now ask if you really want to use the item.
* Added support for new `Gun Manor Boiler Room - Wishing Well Token` check.
* Added support for new check locations `Gun Manor Hedge Maze - Tea Leaf Bush` and `Gun Manor Boiler Room - Boiler Spout` to introduce the entire line of Tea Service to the randomize pool.
* Fixed a bug that skips over `Region D - 3rd encounter` even without pete (skip chance)
* Added workaround for check `Kellogg Ranch (Kitchen) - Dough Baked`, once complete if the player does the steps again they will get the `Kellogg Flakes` item like they would in vanilla.
* Added `Wander Sanity` Support in the code. When toggled off, the code will instead give you its vanilla items in *most* places, with the exception of still randomized tools like the shovel, skill books and the varmit skinning knife.
* Added support for 2 new items in the item pool `Kellogg Ranch Brochure` and `Goblin Flapjacks x2`
* Added `Crate Sanity` Support in the code. When toggled off the code will instead give you its vanilla items in *most* places, with the exception of still randomized 1 item `Perfumed Pocket Square` due to it being a `Stench Resistance` item and crate sanity can unlock all its items from the very beginning if the player is *very* determined, so to avoid having Stench Resistance open too early in logic, the item will remain randomized.
* Added `Haystack Sanity` Support in the code. Only change is when toggled on, haystacks in addition to their needle will also give a check.
* Added an extra bit of script for the halves of Curly's map, now it forces the player to read the first half so they can get the other half check from Hallow way. The script will also require that both maps be in the inventory to combine regardless of which map half is being used.

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
* Added DeathLink to the yaml options as a toggle, player can also turn it on or off from within the options in game.
* Added New check location for `El Vibrato Chamber (Curious False Mountain) - TIMESQUEEZE Cowsbane Seeds`
    * Added logic rules that allow this check to show up if the player can get to and activate the Time Squeezer before they get all required items to grow them at Lazy-A-Dude ranch
    * Added misspoints and proper logic to bring this into logic if the player is able to grow the item at Lazy-A-Dude ranch instead.
* Added Logic rule for `Mr. Gun's Manliness Room- Booze Cart` to require the `Shower Curtain` to convince the person to leave the cart and thus allowing the checks to be gotten off the cart.
* Added `Stardust` to item pool and updated `Dave B Defeated` check to include Stardust or pickaxe as logic requirements to do this check.
* Added `Gun Manor Boiler Room - Wishing Well Token` as a new check location in the Gun Manor DLC.
* Added Check Location `Gun Manor Hedge Maze - Tea Leaf Bush`
    * Added rule logic to require `Tea Service` to be able to get this check
* Added Check Location `Gun Manor Boiler Room - Boiler Spout`
    * Added rule logic to require `Tea Service (With Tea Leaves)` to be able to get this check
* Added new region `Gun Manor Boiler Room` to place checks grouped together into the boiler room.
* Fixed a logic bug that can show `Gun Manor Visitor's Center - Photo` too early in logic.
* Renamed all checks for `Random Event` into `Wander Sanity`
* Added `Wander Sanity` as a toggleable option in the yaml. Toggling off will cause the game to no longer generate checks, and instead replace the items there with their vanilla item.
    * Dissabling will change `Bottle of Ghost Whisky` from a Progressive item to a Useful item as it is no longer required for any checks, but is still required to get the ghost ring which is a really nice and useful item in the game.
* Added 2 new items to the item pool `Kellogg Ranch Brochure` and `Goblin Flapjacks x2`, both are considered filler, and the kellogg brochure toggles off with the `Wander Sanity`.
* Added `Crate Sanity`, Replaced `Progressive Loot` as its logic names. This is a toggleable yaml option that will cause the items to either randomize or be placed back in their vanilla location. (see client update for exception)
* Added 16 new check locations under a toggleable YAML option called `Haystack Sanity`, this only adds more checks to the pool on each haystack that is currently accessable within the game as it is.
* Restructured the YAML file within options creators to include option groups
    * Sanity Options added that include `Wander Sanity`, `Crate Sanity` and `Haystack Sanity`, all 3 options are toggled on by default
    * DLC Options added that now includes `Gun Manor DLC Enabled` and `Randomize Gun Manor Coach`, both are also now disabled by default, so players who dont have the DLC and are trying a blind randomizer with default settings wont accidentally keep these options on.
