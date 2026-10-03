# WOLAP Troubleshooting

[← Back to the WOLAP README](../README.md)

This guide covers common installation, startup, Archipelago connection, generation, and gameplay problems with WOLAP.

Before troubleshooting anything complicated, check the basics first.

---

# FAQ / Quick Links

## Quick Troubleshooting Checklist

Before reporting a bug, confirm:

- You are using the WOLAP Client version you intended to install.
- You are using the correct West of Loathing AP World version.
- Your seed was generated using a compatible AP World.
- You are connecting to the correct Archipelago room.
- Your slot name is correct.
- Your server address and port are correct.
- You do not have both a manual WOLAP installation and a Mod Manager installation active at the same time.
- If you manually installed BepInEx, you launched the game once before installing the WOLAP files.

## Links To Questions & Answers

- [WOLAP does not load](#wolap-does-not-load)
    - [Basic Troubleshooting](#1-check-that-bepinex-is-loading)
    - [WOLAP Works in a Mod Manager but Not When Launched Through Steam](#wolap-works-in-a-mod-manager-but-not-when-launched-through-steam)
    - [WOLAP not loading after switching from manual install to a Mod Manager](#wolap-not-loading-after-switching-from-manual-installation-to-a-mod-manager)
- [Cannot connect to Archipelago](#cannot-connect-to-archipelago)
    - [Basic Troubleshooting](#cannot-connect-to-archipelago)
    - [ArchipelagoSocketClosedException present in BepInEx log](#archipelagosocketclosedexception)
- [Item Sent & Receiving issues](#item-sentreceived-issues)
    - [I received Items from the Wrong Game or an Old Seed](#i-received-items-from-the-wrong-game-or-old-seed)
    - [I Accidentally Opened A Different WOLAP Game's Save and Received All Its Checks in the Wrong Save File](#i-accidentally-opened-a-different-wolap-games-save-and-received-all-its-checks-in-the-wrong-save-file)
    - [Items, Checks, or Logic Seem Wrong After Updating](#items-checks-or-logic-seem-wrong-after-updating)
    - [A Check Was Missed or Became Unavailable](#a-check-was-missed-or-became-unavailable)
    
- [Seed generation fails](#seed-generation-fails)
- [Shop Hints Are Missing](#shop-hints-are-missing)
- [Linux and macOS Problems](#linux-and-macos-problems)

## Useful Information To Help Me Help You
- [Finding Log Files](#finding-log-files)
    - [BepInEx Log Files](#bepinex-log)
    - [Unity Player.log Files](#unity-playerlog)
        - [Windows](#windows)
        - [Linux](#linux)
        - [macOS](#macos)
- [What to Include in a Bug Report](#what-to-include-in-a-bug-report)
    - [Reporting a Bug to the Developers](#reporting-a-bug)

## Other Useful Links

- [Reinstalling From a Clean State](#reinstalling-from-a-clean-state)

---

# WOLAP Does Not Load

### 1. Check That BepInEx Is Loading

Start West of Loathing.

If BepInEx is installed correctly, it should initialize when the game launches and create its normal folders and log files.

For a manual installation, the following folders should exist:

```text
BepInEx/core
BepInEx/patchers
BepInEx/plugins
```

If these folders do not exist, make sure you completed the first BepInEx launch.

> ***Important*** BepInEx needs to be allowed to launch West of Loathing once before the WOLAP files are installed into its folders.
> 
>**NOTE**: Do ***NOT*** create those folders manually.

### 2. Check the WOLAP Files

For a manual installation, the WOLAP plugin folder should contain:

```text
BepInEx/plugins/WOLAP/WOLAP.dll
BepInEx/plugins/WOLAP/Archipelago.MultiClient.Net.dll
```

The recommended dependency-patcher installation should contain:

```text
BepInEx/patchers/WOLAP.DependencyPatcher.dll
BepInEx/patchers/Newtonsoft.Json.dll
```

And the MonoMod dependencies should exist in:

```text
BepInEx/core/MonoMod.Backports.dll
BepInEx/core/MonoMod.ILHelpers.dll
```

If any of these files are missing, reinstall the latest WOLAP manual package.

### 3. Newtonsoft.Json or Dependency Errors

WOLAP requires a newer Newtonsoft.Json version than the version normally included with West of Loathing.

Manual installations support two methods.

#### Recommended Method:

The recommended setup uses:

```text
BepInEx/patchers/WOLAP.DependencyPatcher.dll
BepInEx/patchers/Newtonsoft.Json.dll
```

#### Alternate Method

The alternate setup replaces the game's original `Newtonsoft.Json.dll`.

> ***Important*** Do not accidentally mix incomplete parts of both installation methods.

If you are unsure what state your installation is in, follow the [Manual Uninstall Instructions](uninstalling-manual.md), verify your game files through Steam, and perform a [clean installation](#reinstalling-from-a-clean-state).

## WOLAP Works in a Mod Manager but Not When Launched Through Steam

Thunderstore Mod Manager and r2modman use separate modded launch environments.

If you installed WOLAP through one of these programs, launch the game using:

```text
Modded
```

or:

```text
Start modded
```

from the Mod Manager.

Launching the game directly through Steam **will** start the normal unmodded version instead.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

## WOLAP Not Loading After Switching From Manual Installation to a Mod Manager

A manually installed copy of BepInEx can interfere with the copy managed by Thunderstore or r2modman.

If you are switching installation methods:

1. Follow the [Manual Uninstall Instructions](uninstalling-manual.md).
2. Double check that the BepInEx files are removed properly.
3. Verify West of Loathing's files through Steam.
4. Reinstall WOLAP through your chosen Mod Manager.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

---

# Cannot Connect to Archipelago

Check the connection information carefully.

Confirm:

- Server address
- Server port
- Slot name
- Password, if the room uses one

The server port is especially important.

Connecting with the correct slot name but the wrong port can connect you to a completely different room or an older session.

If the connection previously worked but suddenly closes, confirm that:

- The Archipelago room is still running.
- Your internet connection is active.
- The host has not restarted or replaced the room.
- The server address and port have not changed.

>**Note**: There is currently a limitation in the `Archipelago.MultiClient.Net.dll` file we use within WOLAP where if the connection handshake doesn't happen within 5 seconds it will time out. If your information is all correct, give it a few seconds then try submitting again. 
>
>If this is still causing a problem and ALL information is entered correctly, restart your internet router.
>
>**Additional Note**: If your Multiworld has a lot of players joining or sending checks all at once this can also cause the handshake to delay. Let it settle for a bit and try again.

If it is still causing you issues, [create a report](#what-to-include-in-a-bug-report) or ping @TylerJG92 in the West of Loathing AP Discord thread and include your [BepInEx log](#bepinex-log) and a screenshot if possible.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

## ArchipelagoSocketClosedException

An error containing:

```text
ArchipelagoSocketClosedException
```

means the Archipelago socket was closed while the client was attempting to communicate with the server.

This error by itself does not prove what caused the connection to close.

Possible causes include:

- The server closing the connection
- The room being restarted
- A temporary network interruption
- Connecting to an invalid or unavailable room
- A client/network compatibility problem

If this occurs repeatedly, save both your [BepInEx log](#bepinex-log) and [Unity `Player.log`](#unity-playerlog) and include them with the [bug report](#what-to-include-in-a-bug-report).

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

---

# Item Sent/Received Issues

## I Received Items From the Wrong Game or Old Seed

Before assuming the save is corrupted, verify the Archipelago connection information.

Check:

```text
Host
Port
Slot Name
```

Using the same slot name on a different Archipelago room does not mean it is the same game.

If you recently generated a new test seed, confirm that WOLAP connected to the **new room's port** rather than an older room. 

(@TylerJG92: "I did this myself while testing and thought it was a bug and spent like 3 hours trying to find it")

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

## I Accidentally Opened A Different WOLAP Game's Save and Received All Its Checks in the Wrong Save File

Unfortunately there is no save slot protection for this implemented yet. If you close your game out **WITHOUT** going to the main menu (Click on the `X` in the upper corner of the game or `Alt+F4`) it may not save that mistake to the save. However if you log into the save and continue getting items from the wrong slot, consider that save *Corrupted* and you will need to restart the *Corrupted* save.

>**Note**: Starting a New Game will give the player all the items the *Slot* has received.

(@TylerJG92: "I have *also* done this and it feels bad, it is on my list of things to add.")

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

## Items, Checks, or Logic Seem Wrong After Updating

Check whether the AP World used to generate the seed matches the version expected by the WOLAP release.

A generation-breaking update may change:

- Items
- Locations
- Location IDs
- Item IDs
- Logic
- Options

Do not use a newly updated generation-breaking AP World with an older generated seed unless the release notes specifically state that it is compatible.

See the [Updating Guide](updating.md) for more information.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

## A Check Was Missed or Became Unavailable

WOLAP includes a missed-check recovery system for a number of vanilla situations where a location can become permanently unavailable.

Recovered checks may become available through Lloyd, The Bartender, at **The Jewel Saloon** in Dirtwater.

If you believe a check has become permanently unavailable and was **not** forwarded to the missed-check system, [send a report](#what-to-include-in-a-bug-report) that includes:

- The check name
- What action caused it to become unavailable
- Whether the check appears at Lloyd
- Whether the check was already completed according to Archipelago

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)



---

# Seed Generation Fails

If Archipelago fails while generating a West of Loathing seed, first check the YAML.

Common things to verify:

- The YAML uses `West of Loathing` as the game.
- The YAML was created for the AP World version you are using.
- Option names have not changed.
- Option values are valid.
- No unintended YAML files are sitting in the `Players` folder.

If you are unsure whether your YAML is outdated, use the Archipelago Launcher and select:

```text
Generate Template Options
```

A new West of Loathing template will be generated under:

```text
Players/Templates
```

Compare your existing settings against the new template rather than blindly replacing your customized YAML.

If you are still unsure, feel free to ping @TylerJG92 in the West of Loathing AP Thread, or you can [make a report](#what-to-include-in-a-bug-report) or me to look at if generation is not urgent or I'm not immediately available. Please include:
* A copy of your .YAML file
* A screenshot or copy of the generation error that is showing at the time of generation
* What version of your APWorld you are using at the time of generation (if you are not the one generating the world, have the host manually remove the AP world and give them the newest version of the APWorld [here](https://github.com/TylerJG92/WOLAP/releases/latest))

>**Note**: I (@TylerJG92) am not always available to help with this type of issue but I do know this issue is pressing when it comes up. If I am available I will usually respond fairly quickly, If I'm not, I may be busy at work, asleep, or may not have noticed the notification. 
>
>Please also be courteous and patient with me as well, 1 ping will be enough to get my attention when this happens. I volunteer my time to help and do have a job outside of this. I will not tolerate more than 1 ping about the same issue *IF* I have not acknowledged it, per day.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

---

# Shop Hints Are Missing

WOLAP can send Archipelago hints for progression items appearing in supported randomized shops.

If a shop hint does not appear:

1. Confirm the item is actually classified as progression.
2. Confirm the shop inventory has reached the visit/state where that item is available.
3. Check the BepInEx log for WOLAP warnings.
4. Confirm the hint was not already sent earlier.

If the problem is reproducible, [Submit a report](#what-to-include-in-a-bug-report) or ping @TylerJG92 in the West of Loathing AP Discord Thread, include the shop name and the [BepInEx log file](#bepinex-log) and a screenshot of your game with the item selected and a screenshot of your tracker not showing the hint (if possible).

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

---

# Linux and macOS Problems

Linux and macOS support currently has less testing than Windows.

If WOLAP fails to load on either platform, include:

- Operating system
- Installation method
- BepInEx version
- WOLAP version
- BepInEx log
- Unity `Player.log`, if available

For Linux manual installations, also verify that:

```text
./run_bepinex.sh %command%
```

is still present in Steam's Launch Options.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

---

# Finding Log Files

Logs are extremely useful when reporting crashes, startup failures, or Archipelago connection problems.

## BepInEx Log

The main BepInEx log is normally located inside the game's BepInEx folder:

```text
BepInEx/LogOutput.log
```

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

## Unity Player.log

Unity also creates a `Player.log`.

### Windows

Unity normally stores player logs under:

```text
%USERPROFILE%\AppData\LocalLow\CompanyName\ProductName\Player.log
```

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

### Linux

Unity normally stores player logs under:

```text
~/.config/unity3d/CompanyName/ProductName/Player.log
```

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

### macOS

Unity normally stores player logs under:

```text
~/Library/Logs/Company Name/Product Name/Player.log
```

The exact `CompanyName` and `ProductName` folder names are determined by the game.

If you cannot find the file, search your system for:

```text
Player.log
```

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

---

# What to Include in a Bug Report

When reporting a WOLAP problem, include as much of the following information as possible:

- WOLAP Client version
- West of Loathing AP World version
- Archipelago version
- Operating system
- Installation method
  - Thunderstore Mod Manager
  - r2modman
  - Manual Installation
- Whether the seed was generated before or after your most recent update
- The check, item, quest, or location involved
- What you expected to happen
- What actually happened
- Steps that reproduce the problem
- Relevant screenshots
- `LogOutput.log`
- `Player.log`, when relevant

For connection issues, include the server address and port if appropriate, but **do not post private passwords**.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

## Reporting a Bug

Bugs can be reported through the WOLAP GitHub issue tracker or discussed in the West of Loathing Archipelago community.

Before submitting a new issue, check whether the problem has already been reported.

If you can reproduce the bug consistently, include the shortest set of steps you know that causes it.

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)

---

# Reinstalling From a Clean State

If you cannot determine what is wrong with a manual installation:

1. Follow the [Manual Uninstall Instructions](uninstalling-manual.md).
2. Verify West of Loathing's files through Steam.
3. Launch the vanilla game once.
4. Reinstall BepInEx.
5. Launch the game once to allow BepInEx to initialize.
6. Install the newest WOLAP files using the appropriate OS installation guide.

Installation guides:

- [Windows Installation](installation-windows.md)
- [Linux Installation](installation-linux.md)
- [macOS Installation](installation-macos.md)

[↑ Back to FAQ / Quick Links](#links-to-questions--answers)