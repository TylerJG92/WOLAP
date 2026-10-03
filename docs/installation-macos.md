# WOLAP Installation — macOS

[← Back to the WOLAP README](../README.md)

WOLAP currently uses a **Manual Installation** on macOS.

> **Testing Note:** WOLAP's BepInEx dependency-patcher installation method has not yet been thoroughly tested on macOS.
>
> If you encounter problems, please report them and include your BepInEx log if possible.

---

# Manual Installation

Manual installation requires installing BepInEx and placing the WOLAP files into the appropriate BepInEx folders.

## 1. Locate West of Loathing

Locate your West of Loathing installation through Steam.

## 2. Install BepInEx

Download the latest stable Linux/macOS release of [BepInEx](https://github.com/BepInEx/BepInEx/releases).

Use the archive intended for Unix-like systems.

Extract the BepInEx files into the appropriate West of Loathing installation location.

## 3. Run the game once (**Very Important**)

Launch West of Loathing normally.

Once the game reaches the title screen, close it.

This allows BepInEx to complete its initial setup and create its required folders.

> ***Important*** If this step is not done, you will not see the files within `BepInEx` that you need to place the mod files into.

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
BepInEx/core
```

## 6. Install Newtonsoft.Json

> ***Important*** Choose **1** of the following Newtonsoft.Json Installation Methods.

### Recommended Newtonsoft.Json Installation

The recommended method is to open the `Patchers` folder and copy:

```text
WOLAP.DependencyPatcher.dll
Newtonsoft.Json.dll
```

into:

```text
BepInEx/patchers
```

> ***Testing Note*** This method has not yet been thoroughly tested on macOS.
>
> If WOLAP fails to load or produces unexpected errors, please include your BepInEx log when reporting the problem.

### Alternate Newtonsoft.Json Installation

Instead of using the dependency patcher, you may replace the game's existing `Newtonsoft.Json.dll`.

Open the `Patchers` folder and copy:

```text
Newtonsoft.Json.dll
```

On macOS there is no normal Windows-style:

```text
West of Loathing_Data
```

folder.

Instead:

1. Right-click or Cmd-click the West of Loathing application.
2. Select `Show Package Contents`.
3. Navigate to:

```text
Contents/Resources/Data
```

4. Locate the existing `Newtonsoft.Json.dll`.
5. Replace it with the version included with WOLAP.

## 7. Install WOLAP

Copy the entire `WOLAP` folder into:

```text
BepInEx/plugins
```

The resulting folder should contain:

```text
BepInEx/plugins/WOLAP/WOLAP.dll
BepInEx/plugins/WOLAP/Archipelago.MultiClient.Net.dll
```

## 8. Launch the game

Launch West of Loathing normally.

BepInEx should start automatically and load WOLAP.

---

# Uninstalling a Manual Installation

See the [Manual Uninstall Instructions](uninstalling-manual.md).

---

# Need Help?

macOS support is currently less tested than Windows.

If WOLAP fails to load or produces unexpected errors, please include your BepInEx log when reporting the problem.

See the [Troubleshooting Guide](troubleshooting.md) for additional information.