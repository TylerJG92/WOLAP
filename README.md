# West of Loathing AP Mod (WOLAP)

A client mod for [West of Loathing](https://store.steampowered.com/app/597220/West_of_Loathing/) that integrates the game with the [Archipelago multiworld multi-game randomizer](https://archipelago.gg/).

## Current Release

**WOLAP Client:** v0.3.1  
**West of Loathing AP World:** v0.3.0

WOLAP is currently considered stable and playable, though development is ongoing and additional features and randomization options are planned.

Bug reports and feedback are welcome through the West of Loathing thread in the Archipelago Discord or through the GitHub issue tracker.

## Download

The latest WOLAP release mod files, YAML Template and/or AP World can be found on the [GitHub Releases page](https://github.com/TylerJG92/WOLAP/releases).

WOLAP is also available through Thunderstore for players using Thunderstore Mod Manager or r2modman.

## Getting Started

WOLAP can be installed in several ways:

- **Thunderstore Mod Manager** — Windows
- **r2modman** — Windows / Linux
- **Manual Installation** — Windows / Linux / macOS

Choose your platform for full installation instructions:

- [Windows Installation](docs/installation-windows.md)
- [Linux Installation](docs/installation-linux.md)
- [macOS Installation](docs/installation-macos.md)

> **Important:** If you are switching from a manual installation to Thunderstore or r2modman, follow the [Manual Uninstall Instructions](uninstalling-manual.md) first.

Already have WOLAP installed?

- [Updating WOLAP](docs/updating.md)

Having problems?

- [Troubleshooting & FAQ](docs/troubleshooting.md)

## What Does WOLAP Randomize?

The majority of West of Loathing's unique items and pickup locations are randomized through Archipelago.

This includes progression items, equipment, quest rewards, shop items, unique combat drops, and hundreds of locations throughout the base game.

The **Reckonin' at Gun Manor** DLC is also supported and can optionally be included in the randomization.

Most non-unique loot, repeatable combat drops, unlimited shop inventory, and Foragin' plants are currently not randomized.

## Archipelago Options

### Enable Gun Manor DLC

YAML option:

`dlc_enabled`

Includes Gun Manor DLC items and locations in the randomization.

Requires ownership of **Reckonin' at Gun Manor**.

Enabled by default.

### Randomize Gun Manor Coach

YAML option:

`randomize_ghost_coach`

Randomizes the Ghost Coach required to access Gun Manor.

Enabled by default and only applies when Gun Manor randomization is enabled.

### Randomize Goblintongue

YAML option:

`randomize_goblintongue`

Randomizes the ability to speak Goblintongue.

Enabled by default. If disabled, Goblintongue is available from the beginning of the game.

### Unbreakable Tools

YAML option:

`unbreakable_tools`

Prevents several important tools, such as the shovel, pickaxe, and El Vibrato headband, from being permanently consumed or broken.

Disabled by default.

### Start Inventory From Pool

YAML option:

`start_inventory_from_pool`

Allows specified starting items to be removed from the randomized item pool instead of creating additional copies through normal Archipelago `start_inventory`.

## Gameplay Changes

West of Loathing was not originally designed around randomized progression, so WOLAP changes a number of vanilla mechanics to prevent progression problems and make the game work more naturally as an Archipelago world.

Some examples include:

- Missable checks can be recovered through Lloyd at The Jewel Saloon.
- Progression items appearing in randomized shops can generate Archipelago hints.
- Several quest sequences have protections against receiving items out of their normal vanilla order.
- Emperor Norton can be temporarily skipped if the player is not yet prepared to complete that progression.
- Certain normally missable or mutually-exclusive rewards have alternate ways to obtain their Archipelago checks.
- Several vanilla item and quest requirements have been adjusted where necessary for randomizer logic.

For the full list, see:

**[Mechanical and Logic Changes](docs/changelist.md)**

## Reporting Bugs

If you encounter a bug, please include as much information as possible about what you were doing when it occurred.

Bug reports can be submitted through the GitHub issue tracker or discussed in the West of Loathing thread on the Archipelago Discord.

For crashes, connection problems, or unexpected mod behavior, including your BepInEx `LogOutput.log` or Unity `Player.log` can be especially helpful.

## AI Usage Disclosure

- WOLAP is **not** vibe-coded.
- WOLAP does **not** contain AI-generated art.

### Xylen (Original Mod Dev)

In response to being asked on 8/4/26 if they used AI for the ap world: "Nope. In the interest of full, 100% honest disclosure, I used chatgpt exactly twice through development to try asking it about a couple of weird bugs that had me stuck. It basically just confirmed for me both times that the code I was looking at was fine so I went and manually found the bug elsewhere. None of the code (in the main games mod) is AI-generated" (https://discord.com/channels/731205301247803413/1273856413327822950/1534239231168479242)

### TylerJG92 (Current Active Mod Dev)

I use ChatGPT as a development assistant to help keep track of tasks, issues, long questlines and flags, explain code, and troubleshoot problems when I get stuck.

I use strict working rules so it acts as a tutor and debugging assistant rather than writing the mod for me.

ChatGPT is not used to generate WOLAP gameplay or mod code.

A small amount of AI-generated code has been used in internal packaging tools only. These tools are not part of the code that runs in-game.

## Documentation

- [Windows Installation](docs/installation-windows.md)
- [Linux Installation](docs/installation-linux.md)
- [macOS Installation](docs/installation-macos.md)
- [Manual Uninstall Instructions](uninstalling-manual.md)
- [Updating WOLAP](docs/updating.md)
- [Troubleshooting](docs/troubleshooting.md)
- [Mechanical and Logic Changes](docs/changelist.md)
- [Full Changelog](docs/CHANGELOG.md)
