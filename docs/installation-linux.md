# WOLAP Installation — Linux

[← Back to the WOLAP README](../README.md)

WOLAP can be installed on Linux using one of two methods:

1. **r2modman (recommended)** — uses the **Windows version of West of Loathing through Steam Proton**. This method has been tested successfully.
2. **Manual Installation** — uses the **native Linux version of West of Loathing** with BepInEx. This method has not yet been fully verified.

> **Important:** These methods use different game versions and BepInEx setups. Follow the instructions for the method you choose rather than combining them.
>
> If you previously installed WOLAP manually and want to switch to r2modman, follow the [Manual Uninstall Instructions](uninstalling-manual.md) first.

---

# r2modman (Proton)

r2modman is a mod manager that downloads packages from Thunderstore without requiring Overwolf.

**Verified setup:** Ubuntu 24.04 LTS, Steam installed from the standard `.deb` package, r2modman 3.2.20, and West of Loathing running through Proton Stable or Proton Experimental. WOLAP was confirmed to launch and run with this setup without manually changing its installed mod files.

Other Linux distributions and Steam packaging formats may work, but they have not been verified through this test.

## 1. Install Steam and West of Loathing

Install Steam using the package appropriate for your Linux distribution, then install West of Loathing.

For Ubuntu and other Debian-based distributions, the tested setup used Steam's standard `.deb` installer, available from [Steam for Linux](https://repo.steampowered.com/steam/).

> **Steam Snap note:** During Ubuntu testing, the Snap installation of Steam launched the game normally but failed when r2modman attempted to start it, showing a missing `libc.so.6` warning. Replacing Snap Steam with the standard `.deb` installation resolved that launch blocker in the tested environment. This does not establish that every Snap installation will fail.

## 2. Enable Proton for West of Loathing

West of Loathing has a native Linux build, but **r2modman 3.2.20 expects the Windows executable** (`West of Loathing.exe`) when configuring this game.

In Steam:

1. Right-click **West of Loathing** and open **Properties**.
2. Open **Compatibility**.
3. Select **Proton Stable** or **Proton Experimental**. Both were tested successfully.
4. Allow Steam to download or update the Windows version of the game.
5. Launch West of Loathing **normally through Steam at least once**, confirm that it reaches the game, then close it. This also allows Steam to initialize the Proton environment.

> **IMPORTANT** You ***MUST*** Launch West of Loathing at least once after changing to Proton or else you will get an error later in the installation.

To confirm that Steam installed the Windows build, open **Properties → Installed Files → Browse** and look for:

```text
West of Loathing.exe
```

For this installation method, do **not** select the native executable `West of Loathing.x86_64` in r2modman.

## 3. Install r2modman

Download [r2modman](https://thunderstore.io/c/riskofrain2/p/ebkr/r2modman/) and follow its Linux installation instructions. Distribution-specific packages are also available from the [r2modman GitHub releases](https://github.com/ebkr/r2modmanPlus/releases).

Open r2modman, search for **West of Loathing**, choose **Select Game**, then select or create a mod profile.

## 4. Configure the Steam and game locations

If r2modman asks for the Steam or West of Loathing location, configure them separately under its **Settings → Locations/Directories** options.

**Steam location:** Browse to and select the `steam.sh` launcher in your Steam installation. Typical locations for a standard Steam installation include:

```text
~/.local/share/Steam/steam.sh
~/.steam/steam/steam.sh
```

**West of Loathing location:** In Steam, use **West of Loathing → Properties → Installed Files → Browse** to locate the game's installed files. When r2modman asks you to choose an executable, select:

```text
West of Loathing.exe
```

If r2modman says the selected executable must be `West of Loathing.exe`, return to Step 2 and confirm Proton downloaded the Windows version.

## 5. Install WOLAP

1. In r2modman, open the West of Loathing profile.
2. Select **Online**.
3. Search for **WOLAP**.
4. Select **Download** and install the latest version **with dependencies**.
5. Under **Installed**, confirm that WOLAP and its BepInEx dependency are present and enabled.
6. Select **Start modded**.

WOLAP should load when West of Loathing starts. No manual copying of WOLAP DLLs is required for this method.

## Playing Vanilla West of Loathing

Installing WOLAP through r2modman should not require modifying the game's normal installation files.

Launch West of Loathing normally through Steam to play without the r2modman profile, or use the **Start vanilla** option in r2modman.

## r2modman Troubleshooting

- **Only `West of Loathing.exe` is accepted:** The native Linux executable is not accepted by the tested r2modman version. Enable Proton as described above and select the Windows executable.
- **Missing `libc.so.6` when selecting Start modded:** This occurred with Snap Steam in the tested Ubuntu VM, even though launching from Steam worked. Using the standard `.deb` Steam installation resolved it in that test.
- **Missing file under `steamapps/compatdata/`:** Confirm the game launches normally through Steam using Proton before attempting Start modded; the Proton environment must be initialized.
- **Steam folder is rejected:** Browse to the `steam.sh` launcher instead of choosing `/usr/bin` or the game directory.
- **The game starts without WOLAP:** Confirm that the correct profile is selected and that WOLAP and BepInEx are enabled. If necessary, consult the [r2modman Linux troubleshooting guide](https://github.com/ebkr/r2modmanPlus/wiki/Modding-on-a-Steam-Deck-and-Linux).

If r2modman incorrectly treats a Proton installation as a native Linux game, its official Linux documentation describes an optional `.forceproton` workaround. **This was not required during WOLAP's successful Ubuntu test.**

---

# Manual Installation (Native Linux)

Manual installation uses the native Linux version of West of Loathing and the Linux/macOS BepInEx launcher. The instructions below retain the existing manual setup procedure, but the full WOLAP startup and dependency-patcher behavior have **not yet been verified on native Linux**.

> **Important:** If you previously enabled Proton for r2modman, revert back to the default setting in the game's Steam Compatibility settings before following this native Linux method. Verify that Steam is using the Linux game executable rather than `West of Loathing.exe`.

## 1. Locate West of Loathing

In Steam:

**West of Loathing → Properties → Installed Files → Browse**

This opens the West of Loathing installation directory.

For the native Linux installation, the game's executable is typically:

```text
West of Loathing.x86_64
```

## 2. Install BepInEx

Download the latest stable Linux/macOS release of [BepInEx](https://github.com/BepInEx/BepInEx/releases).

Choose the archive marked:

```text
nix
```

The `nix` package supports both 32-bit and 64-bit executables.

Extract its contents directly into the West of Loathing installation directory.

## 3. Make the BepInEx launcher executable

Open a terminal in the West of Loathing directory and run:

```bash
chmod u+x run_bepinex.sh
```

## 4. Configure Steam

In Steam, open **West of Loathing → Properties** and enter the following under **Launch Options**:

```text
./run_bepinex.sh %command%
```

## 5. Run the game once

Launch West of Loathing normally through Steam. Once it reaches the title screen, close it.

This allows BepInEx to perform its initial setup and create its directories.

> **Important:** Complete this step before trying to place WOLAP files into the BepInEx directories.

## 6. Download and extract WOLAP

Download the latest `WOLAP_Mod.zip` from the [WOLAP Releases page](https://github.com/TylerJG92/WOLAP/releases) and extract it.

The archive should contain three actual directories:

```text
MonoMod/
Patchers/
WOLAP/
```

**ZIP compatibility note:** An earlier v0.3.5 archive stored Windows-style backslashes in its ZIP entry names. Some Linux extraction tools treated those as part of each filename instead of creating folders. The corrected packaging process uses forward slashes. If you get files literally named like `WOLAP\WOLAP.dll`, obtain the updated archive rather than treating those filenames as the intended layout.

## 7. Copy WOLAP files into specific BepInEX folders

> **Note:** If you do not see the listed BepInEx folder to copy the mod files into, please redo step 5 again. 
>
> **DO NOT** create your own folders within BepInEx, these will not work.

### Install the MonoMod dependencies

Open the extracted `MonoMod` directory and copy:

```text
MonoMod.Backports.dll
MonoMod.ILHelpers.dll
```

into:

```text
BepInEx/core
```

### Install the dependency patcher

Open the extracted `Patchers` directory and copy:

```text
WOLAP.DependencyPatcher.dll
Newtonsoft.Json.dll
```

into:

```text
BepInEx/patchers
```


### Install WOLAP

Copy the entire extracted `WOLAP` directory into:

```text
BepInEx/plugins
```

The resulting paths should include:

```text
BepInEx/plugins/WOLAP/WOLAP.dll
BepInEx/plugins/WOLAP/Archipelago.MultiClient.Net.dll
```

## 8. Launch the game

Launch West of Loathing normally through Steam.

Steam should start the native Linux game through `run_bepinex.sh` and attempt to load WOLAP. **This complete manual-install workflow still needs native Linux verification.**

---

# Uninstalling a Manual Installation

See the [Manual Uninstall Instructions](uninstalling-manual.md).

---

# Need Help?

If WOLAP fails to load or behaves unexpectedly, please report the Linux distribution, Steam installation method, whether you use Proton or the native Linux game, and the method used to install WOLAP.

Include the BepInEx log if one was generated. If no log file was created, mention that as well.

See the [Troubleshooting Guide](troubleshooting.md) for additional information.