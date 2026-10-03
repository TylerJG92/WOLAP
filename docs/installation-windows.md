# WOLAP Installation — Windows

[← Back to the WOLAP README](../README.md)

WOLAP can be installed on Windows using one of three methods:

1. **Thunderstore Mod Manager** — easiest for most users
2. **r2modman** — lightweight mod manager without Overwolf
3. **Manual Installation**

> **Important:** If you previously installed WOLAP manually and want to switch to Thunderstore Mod Manager or r2modman, follow the [Manual Uninstall Instructions](uninstalling-manual.md) first.

---

# Thunderstore Mod Manager

Thunderstore Mod Manager installs WOLAP and its dependencies without requiring you to manually modify the West of Loathing game files.

Thunderstore Mod Manager requires **Overwolf**.

## Installation

1. Download and install [Thunderstore Mod Manager](https://www.overwolf.com/app/thunderstore-thunderstore_mod_manager).

2. Open Thunderstore Mod Manager.

3. Search for `West of Loathing`.

4. Hover over West of Loathing and select `Select Game`.

5. Select an existing mod profile or create a new one.

6. Select `Get Mods` from the menu on the left.

7. Search for `WOLAP`.

8. Open the WOLAP package and download the most recent version **with dependencies**.

9. Once installation finishes, you should see both `BepInEx` and `WOLAP` under `My Mods`.

10. Select `(play) Modded` near the top-right of Thunderstore Mod Manager.

WOLAP should now load when West of Loathing starts.

## Playing Vanilla West of Loathing

Installing WOLAP through Thunderstore Mod Manager should not interfere with your normal West of Loathing installation.

You can still launch the unmodded game normally through Steam or select `(play) Vanilla` from Thunderstore Mod Manager.

---

# r2modman

r2modman uses packages from Thunderstore but does **not** require Overwolf.

## Installation

1. Download [r2modman](https://thunderstore.io/c/riskofrain2/p/ebkr/r2modman/) and follow its installation instructions.

2. Open r2modman.

3. Search for `West of Loathing`.

4. Hover over West of Loathing and select `Select Game`.

5. Select an existing profile or create a new one.

6. Select `Online` from the menu on the left.

7. Search for `WOLAP`.

8. Select WOLAP and choose `Download`.

9. Download the most recent version **with dependencies**.

10. Once installation finishes, you should see `BepInEx` and `WOLAP` under `Installed`.

11. Select `Start modded` in the upper-left corner.

WOLAP should now load when West of Loathing starts.

## Playing Vanilla West of Loathing

Installing WOLAP through r2modman should not interfere with the normal game files.

You can continue launching West of Loathing normally through Steam, or use the dropdown next to `Start modded` and select `Start vanilla`.

---

# Manual Installation

Manual installation requires installing BepInEx and placing the WOLAP files into the appropriate BepInEx folders.

## 1. Locate West of Loathing

In Steam:

`West of Loathing` → `Properties` → `Installed Files` → `Browse`

This opens the West of Loathing installation directory.

## 2. Install BepInEx

Download the latest stable x64 release of [BepInEx](https://github.com/BepInEx/BepInEx/releases).

Extract the contents of the BepInEx archive directly into the West of Loathing directory.

## 3. Run the game once (**Very Important**)

Launch West of Loathing normally.

Once the game reaches the title screen, close it.

This allows BepInEx to complete its initial setup and create its folders.

> ***Important*** If this step is not done, You will not see the files within `BepInEx` that you need to place the mod files into.

## 4. Download WOLAP

Download the latest `WOLAP_Mod.zip` from the [WOLAP Releases page](https://github.com/TylerJG92/WOLAP/releases).

Extract the archive.

It contains three folders:

```text
MonoMod
Patchers
WOLAP
```

## 5. Install the MonoMod dependencies

Open the `MonoMod` folder.

Copy:

```text
MonoMod.Backports.dll
MonoMod.ILHelpers.dll
```

into:

```text
BepInEx\core
```

## 6. Install the dependency patcher

> ***Important*** Choose **1** of the following Newtonsoft.Json Installation Methods

### Recommended Newtonsoft.Json Installation

The recommended method is to open the `Patchers` folder and copy:

```text
WOLAP.DependencyPatcher.dll
Newtonsoft.Json.dll
```

into:

```text
BepInEx\patchers
```

### Alternate Newtonsoft.Json installation

Instead of using the dependency patcher, you may copy:

```text
Newtonsoft.Json.dll
```

into:

```text
West of Loathing_Data\Managed
```

and overwrite the existing `Newtonsoft.Json.dll`.

## 7. Install WOLAP

Copy the entire `WOLAP` folder into:

```text
BepInEx\plugins
```

The resulting folder should contain:

```text
BepInEx\plugins\WOLAP\WOLAP.dll
BepInEx\plugins\WOLAP\Archipelago.MultiClient.Net.dll
```

## 8. Launch the game

Launch West of Loathing normally through Steam.

BepInEx should start automatically and load WOLAP.

---

## Uninstalling a Manual Installation

See the [Manual Uninstall Instructions](uninstalling-manual.md).

---

# Need Help?

See the [Troubleshooting Guide](troubleshooting.md), report the problem through the WOLAP GitHub issue tracker or ping @TylerJG92 in the [West of Loathing AP Thread](https://discord.com/channels/731205301247803413/1273856413327822950).