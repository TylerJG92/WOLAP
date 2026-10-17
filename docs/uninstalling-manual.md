# Uninstalling a Manual WOLAP Installation

[← Back to the WOLAP README](../README.md)

These instructions are for users who installed WOLAP **manually**.

If WOLAP was installed through Thunderstore Mod Manager or r2modman, uninstall the mod through the same mod manager instead.

This guide covers:

- Removing WOLAP while keeping BepInEx installed
- Restoring the original `Newtonsoft.Json.dll` if it was manually replaced
- Completely removing BepInEx
- Preparing the game to switch from a manual installation to Thunderstore Mod Manager or r2modman

---

# Removing WOLAP While Keeping BepInEx

## 1. Remove the WOLAP plugin

Delete the `WOLAP` folder from:

```text
BepInEx/plugins
```

This folder should contain:

```text
WOLAP.dll
Archipelago.MultiClient.Net.dll
```

---

# If You Used the Recommended Dependency Patcher Method

If you installed WOLAP by placing the dependency files into:

```text
BepInEx/patchers
```

delete:

```text
WOLAP.DependencyPatcher.dll
Newtonsoft.Json.dll
```

from:

```text
BepInEx/patchers
```

The MonoMod dependency files may also be removed from:

```text
BepInEx/core
```

The WOLAP package installs:

```text
MonoMod.Backports.dll
MonoMod.ILHelpers.dll
```

> **Note:** If another installed mod also requires these MonoMod files, leave them installed.

---

# If You Manually Replaced Newtonsoft.Json.dll

Windows and macOS manual installations may instead have replaced the copy of `Newtonsoft.Json.dll` included with West of Loathing.

The newer version should not negatively affect normal gameplay, so restoring the original file is optional unless you want to completely return the game to its original state.

## Windows

The replaced file is located in:

```text
West of Loathing_Data\Managed
```

To restore the original:

1. Delete the replacement `Newtonsoft.Json.dll`.
2. In Steam, open:

   `West of Loathing` → `Properties` → `Installed Files`

3. Select:

   `Verify integrity of game files`

Steam should restore the original version.

## macOS

On macOS, the game files are stored inside the West of Loathing application bundle.

1. Right-click or Cmd-click the West of Loathing application.
2. Select `Show Package Contents`.
3. Navigate to:

```text
Contents/Resources/Data
```

4. Delete the replacement `Newtonsoft.Json.dll`.
5. Verify West of Loathing's files through Steam.

Steam should restore the original version.

---

# Completely Removing BepInEx

If you no longer want to use BepInEx for West of Loathing, you can remove the manual BepInEx installation as well.

## Windows

Delete the BepInEx files and folders that were added to the West of Loathing installation directory.

Afterward, verify West of Loathing's files through Steam:

`West of Loathing` → `Properties` → `Installed Files` → `Verify integrity of game files`

This is especially recommended if you previously replaced the game's `Newtonsoft.Json.dll`.

---

## Linux

Delete the BepInEx files and folders that were added to the West of Loathing installation directory.

Then remove the BepInEx launch command from Steam.

Open:

`West of Loathing` → `Properties`

Remove:

```text
./run_bepinex.sh %command%
```

from the game's **Launch Options**.

Verify West of Loathing's files through Steam if necessary.

---

## macOS

Remove the BepInEx files and folders that were added during the manual installation.

If you manually replaced `Newtonsoft.Json.dll`, restore the original file using Steam's file verification.

Verify West of Loathing's files through Steam if necessary.

---

# Switching From Manual Installation to Thunderstore or r2modman

If you are switching from a manual WOLAP installation to Thunderstore Mod Manager or r2modman, it is recommended that you completely clean up the manual installation first.

## Windows

1. Delete the manually installed `BepInEx` folder from the West of Loathing directory.
2. Verify West of Loathing's files through Steam.
3. Install WOLAP through your chosen mod manager.

This prevents manually installed BepInEx files from interfering with the mod manager's separate installation.

---

## Linux

1. Delete the manually installed BepInEx files and folders.
2. Remove:

```text
./run_bepinex.sh %command%
```

from Steam's **Launch Options**.
3. Verify West of Loathing's files through Steam.
4. Install WOLAP through r2modman.

This prevents the old manual BepInEx setup from interfering with r2modman.

---

# Need Help?

If WOLAP still appears to load after uninstalling, or the game fails to start afterward, verify West of Loathing's files through Steam.

For additional help, see the [Troubleshooting Guide](troubleshooting.md), report the problem through the WOLAP GitHub issue tracker or ping @TylerJG92 in the [West of Loathing AP Thread](https://discord.com/channels/731205301247803413/1273856413327822950).