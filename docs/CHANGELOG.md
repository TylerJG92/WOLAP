# Item Routing fixes and features
* Added hinting behavior to all shops to hint `Progressive` items to the ap server
* Changed the missed check shop to the Dirtwater Bartender instead of Dirtwater Mercantile
    * Added price randomization for items sent to the Missed item shop, they can now show up priced anywhere from 250 meat to 1250 meat.
* Fixed location check forwarding for both `General Gob's hat` and `General Gob's Pistole` check locations if General Gob is convinced to leave without using a persuadin' feature to have him leave these items with you
* Fixed location check forwarding for `Blood Alter` at sterns ranch if you throw the goblet of blood in the jumbleneck mine's void before talking to the doll
* Fixed location check forwarding for `circus slide whistle - reward` if you happen to take all items out of the Lost and Found before placing the slide whistle in, thus locking you out of getting the reward
* Fixed location check forwarding for `cowsbane harvest` when you give the cowsbane seeds to barnaby bob instead of the guy at Lazy-A-dude Ranch
* Fixed a missed check that can occure when you collect the `x marks the spot` location without talking to halloway about his half of the map first
* Added a prevention from being able to eat the Honeyed Jellybean unless you currently have the `AntEyeVirus` flag (and thus have a need to eat it)
* Fixed a bug where the Purchase of the Honeyed Jellybean can become unpurchasable if you eat the Jellybean or progress the main quest too far, it should now be available from the point you talk to Norton and he gives you the `AntEyeVirus` or if you give him a crown.