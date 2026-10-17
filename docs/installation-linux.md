# WOLAP Installation — Linux

[← Back to the WOLAP README](../README.md)

WOLAP can currently be installed on Linux using one of two methods:

1. **r2modman** — easiest for most users
2. **Manual Installation**

These instructions are intended for the **native Linux version of West of Loathing running through Steam**.

> **Important:** If you previously installed WOLAP manually and want to switch to r2modman, follow the [Manual Uninstall Instructions](uninstalling-manual.md) first.

---

# r2modman

r2modman is a lightweight mod manager that downloads packages from Thunderstore without requiring Overwolf.

> **Testing Note:** r2modman support for WOLAP on Linux has not yet been thoroughly tested.
>
> If you encounter problems, please report them and include your BepInEx log if possible.

## Installation

1. Download [r2modman](https://thunderstore.io/c/riskofrain2/p/ebkr/r2modman/) and follow its Linux installation instructions.

2. Open r2modman.

3. Search for `West of Loathing`.

4. Hover over West of Loathing and select `Select Game`.

5. Select an existing mod profile or create a new one.

6. Select `Online` from the menu on the left.

7. Search for `WOLAP`.

8. Select WOLAP and choose `Download`.

9. Download the most recent version **with dependencies**.

10. Once installation finishes, you should see both `BepInEx` and `WOLAP` under `Installed`.

11. Select `Start modded`.

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

Download the latest stable Linux/macOS release of [BepInEx](https://github.com/BepInEx/BepInEx/releases).

Download the archive marked:

```text
nix
```

The `nix` package supports both 32-bit and 64-bit executables.

Extract the contents of the BepInEx archive directly into the West of Loathing directory.

## 3. Make the BepInEx launcher executable

Open a terminal in the West of Loathing directory and run:

```bash
chmod u+x run_bepinex.sh
```

## 4. Configure Steam

In Steam:

`West of Loathing` → `Properties`

Enter the following under **Launch Options**:

```text
./run_bepinex.sh %command%
```

## 5. Run the game once (**Very Important**)

Launch West of Loathing normally through Steam.

Once the game reaches the title screen, close it.

This allows BepInEx to complete its initial setup and create its folders.

> ***Important*** If this step is not done, you will not see the files within `BepInEx` that you need to place the mod files into.

## 6. Download WOLAP

Download the latest `WOLAP_Mod.zip` from the [WOLAP Releases page](https://github.com/TylerJG92/WOLAP/releases).

Extract the archive.

It contains three folders:

```text
MonoMod
Patchers
WOLAP
```

## 7. Install the MonoMod dependencies

Open the `MonoMod` folder.

Copy:

```text
MonoMod.Backports.dll
MonoMod.ILHelpers.dll
```

into:

```text
BepInEx/core
```

## 8. Install the dependency patcher

Open the `Patchers` folder.

Copy:

```text
WOLAP.DependencyPatcher.dll
Newtonsoft.Json.dll
```

into:

```text
BepInEx/patchers
```

> ***Testing Note*** The dependency patcher installation has not yet been thoroughly tested on Linux.
>
> If WOLAP fails to load or produces unexpected errors, please include your BepInEx log when reporting the problem.

## 9. Install WOLAP

Copy the entire `WOLAP` folder into:

```text
BepInEx/plugins
```

The resulting folder should contain:

```text
BepInEx/plugins/WOLAP/WOLAP.dll
BepInEx/plugins/WOLAP/Archipelago.MultiClient.Net.dll
```

## 10. Launch the game

Launch West of Loathing normally through Steam.

Steam should now start West of Loathing through the BepInEx launcher and load WOLAP.

---

# Uninstalling a Manual Installation

See the [Manual Uninstall Instructions](uninstalling-manual.md).

---

# Need Help?

Linux support is currently less tested than the Windows installation.

If WOLAP fails to load or produces unexpected errors, please include your BepInEx log when reporting the problem.

See the [Troubleshooting Guide](troubleshooting.md) for additional information.