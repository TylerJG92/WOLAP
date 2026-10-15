# West of Loathing AP Mod (WOLAP)

WOLAP is a client mod for [West of Loathing](https://store.steampowered.com/app/597220/West_of_Loathing/) that integrates the game with the [Archipelago multiworld multi-game randomizer](https://archipelago.gg/).

WOLAP is currently considered stable and playable, although development is ongoing. Additional features and randomization options are planned.

## What Does WOLAP Randomize?

The majority of West of Loathing's unique items and pickup locations are randomized through Archipelago, including:

- Progression items and equipment
- Quest rewards and shop items
- Unique combat drops
- Hundreds of checks throughout the game

The **Reckonin' at Gun Manor** DLC is also supported and can optionally be included in the randomization.

Most non-unique loot, repeatable combat drops, unlimited shop inventory, and Foragin' plants are not currently randomized.

WOLAP also adjusts several vanilla game mechanics to support randomized progression, including protections against missable checks, altered quest requirements, and recovery options for checks that become unavailable.

**[Read the Full Mechanical and Logic Changes](https://github.com/TylerJG92/WOLAP/blob/main/docs/changelist.md)**

## Installation

WOLAP supports three installation methods:

- **Thunderstore Mod Manager** — Windows
- **r2modman** — Windows / Linux
- **Manual Installation** — Windows / Linux / macOS

For complete installation instructions, choose your operating system:

- [Windows Installation Guide](https://github.com/TylerJG92/WOLAP/blob/main/docs/installation-windows.md)
- [Linux Installation Guide](https://github.com/TylerJG92/WOLAP/blob/main/docs/installation-linux.md)
- [macOS Installation Guide](https://github.com/TylerJG92/WOLAP/blob/main/docs/installation-macos.md)

**Important:** If you're switching from a manual installation to Thunderstore Mod Manager or r2modman, follow the [Manual Uninstall Guide](https://github.com/TylerJG92/WOLAP/blob/main/docs/uninstalling-manual.md) first.

### Archipelago World and YAML Template

The latest WOLAP client files, West of Loathing APWorld, and YAML template are available through the GitHub releases.

**[WOLAP GitHub Releases](https://github.com/TylerJG92/WOLAP/releases)**

If you're hosting or generating an Archipelago multiworld, make sure you're using the appropriate APWorld version.

## Archipelago Options

WOLAP currently supports several configurable options, including:

- **Enable Gun Manor DLC** — Include DLC items and locations in the randomization
- **Randomize Gun Manor Coach** — Randomize the coach required to access Gun Manor
- **Randomize Goblintongue** — Randomize the ability to speak Goblintongue
- **Unbreakable Tools** — Prevent certain important tools from being permanently consumed or broken
- **Start Inventory From Pool** — Start with items removed from the randomized item pool

These options can be configured in your Archipelago YAML file.

## Updating and Troubleshooting

Already have WOLAP installed?

**[Updating WOLAP](https://github.com/TylerJG92/WOLAP/blob/main/docs/updating.md)**

Experiencing crashes, connection problems, or unexpected behavior?

**[Troubleshooting & FAQ](https://github.com/TylerJG92/WOLAP/blob/main/docs/troubleshooting.md)**

For bug reports, including your BepInEx `LogOutput.log` or Unity `Player.log` can be especially helpful.

## Bug Reports and Feedback

Bug reports, suggestions, and feedback are welcome!

- [WOLAP GitHub Issues](https://github.com/TylerJG92/WOLAP/issues)
- [West of Loathing Archipelago Discord Thread](https://discord.com/channels/731205301247803413/1273856413327822950)

## Development and AI Usage

WOLAP was originally developed by **Xylen**, with development currently maintained by **TylerJG92**.

WOLAP is not vibe-coded and does not contain AI-generated artwork or AI-generated gameplay/mod code.

ChatGPT is used as a development assistant for programming education, debugging, planning, and documentation. A small amount of AI-generated code has been used in internal packaging tools that are not part of the in-game mod.

For the full AI usage disclosure and additional project information, see the [GitHub README](https://github.com/TylerJG92/WOLAP).

## Project Documentation

- [WOLAP GitHub Repository](https://github.com/TylerJG92/WOLAP)
- [Mechanical and Logic Changes](https://github.com/TylerJG92/WOLAP/blob/main/docs/changelist.md)
- [Full Changelog](https://github.com/TylerJG92/WOLAP/blob/main/docs/CHANGELOG.md)
- [Latest Releases](https://github.com/TylerJG92/WOLAP/releases)