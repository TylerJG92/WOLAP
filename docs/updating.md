# Updating WOLAP

[← Back to the WOLAP README](../README.md)

WOLAP has two separate parts that may receive updates:

1. The **WOLAP Client Mod**, which runs inside West of Loathing.
2. The **West of Loathing AP World**, which Archipelago uses when generating a multiworld.

These two parts do **not always use the same version number**.

Before updating, check the release notes to see whether the release is:

- A **Client-only update**
- An **AP World update**
- A **Generation-breaking AP World update**

> ***Important*** Do not assume that every WOLAP update requires a new seed.
>
> The release notes will state when a new AP World or newly generated multiworld is required.

---

# Recommended Update Order

When a new WOLAP release becomes available:

1. Read the release notes.
2. Check whether the update is Client-only, AP World, or generation-breaking.
3. Update the WOLAP Client if required.
4. Update the AP World if required.
5. Generate a new template YAML
6. Generate a new seed **only if the release requires one**.
7. Launch West of Loathing and verify WOLAP loads normally.

---

# Client-Only Updates

A Client-only update changes the mod that runs inside West of Loathing without changing the Archipelago world used to generate the seed.

Examples may include:

- Bug fixes
- Dialogue fixes
- Client-side handling changes
- Connection fixes
- Installation or dependency updates

For these releases, existing seeds can usually continue to be used unless the release notes state otherwise.

You only need to update the **WOLAP Client Mod**.

---

# AP World Updates

An AP World update changes the world data used by Archipelago when generating West of Loathing.

This may include:

- New checks
- New items
- New Archipelago options
- Logic changes
- Item classification changes
- Location or item renames

Some AP World updates may remain compatible with existing generated games, while others may not.

Always follow the compatibility information included with the release.

---

# Generation-Breaking Updates

Some updates change the AP World enough that an existing generated multiworld is no longer compatible with the new version.

Examples include:

- Adding or removing locations
- Adding or removing randomized items
- Changing item identities
- Major logic changes that affect generation
- Significant changes to Archipelago options

When a release is marked as **generation-breaking**, you must:

1. Install the new AP World.
2. Generate a new YAML
3. Generate a **new multiworld/seed**.

> ***Important*** Do not install a generation-breaking AP World and attempt to use it with an older generated seed.
>
> The world data used when a seed is generated should match the version expected by that seed.

---

# Updating Client Mod Through Thunderstore Mod Manager and r2modman

If WOLAP was installed through Thunderstore Mod Manager:

1. Open Thunderstore Mod Manager or r2modman.

2. Select `West of Loathing`.

3. Select the profile you normally use for WOLAP.

4. Check for updates to `WOLAP`.

5. Install the newest version along with any updated dependencies.

6. Launch the game using its normal launch button.

Thunderstore or r2modman will manage the WOLAP package files and dependencies for you.

---

# Updating a Manual Installation

> ***Important*** When manually updating WOLAP, replace ***ALL*** the files included in the new release instead of replacing only `WOLAP.dll`.
>
> WOLAP's dependencies may also change between versions.

## 1. Download the newest release

Download the newest `WOLAP_Mod.zip` from the WOLAP GitHub Releases page.

Extract the archive.

The package contains:

```text
MonoMod
Patchers
WOLAP
```

## 2. Update the MonoMod dependencies

From the new `MonoMod` folder, copy:

```text
MonoMod.Backports.dll
MonoMod.ILHelpers.dll
```

into:

```text
BepInEx/core
```

Replace the existing copies if prompted.

## 3. Update the dependency patcher

> ***Important***: This set of directions refers to how you installed the `Newtonsoft.Json` file when first installing. Please follow the *Correct* direction for how you installed it previously
>
>**Note**: You can change installation methods by removing the files in 1 location and following the alternate install method from the other on your systems install page.

### Recommended Newtonsoft.Json Installation Replacement

If you use the recommended dependency-patcher installation method, copy:

```text
WOLAP.DependencyPatcher.dll
Newtonsoft.Json.dll
```

from the new `Patchers` folder into:

```text
BepInEx/patchers
```

Replace the existing copies if prompted.

### Alternate Newtonsoft.Json Installation Replacement

If you previously chose to replace the game's `Newtonsoft.Json.dll` manually instead of using the dependency patcher, replace that file with the version included in the new WOLAP release.

See your operating system's installation guide for the correct location.

## 4. Update the WOLAP plugin

Copy the new `WOLAP` folder into:

```text
BepInEx/plugins
```

Replace the existing WOLAP files.

The folder should contain:

```text
WOLAP.dll
Archipelago.MultiClient.Net.dll
```

---

# Updating the AP World

Only update the AP World when instructed by the release notes or when preparing to generate using a newer WOLAP AP World version.

>**Special Note**: As of West of Loathing v0.3.0, The APWorld was uploaded to a different Github Repository and as such APLauncher addons like `Install/Update APWorlds` wont recognize the new West of Loathing AP World. 
>
>As an extra precaution, When installing a new APWorld of 0.3.0 or higher, please make sure to manually uninstall the APWorld from before before installing the new APWorld

## 1. Download the new AP World

Download:

```text
westofloathing.apworld
```

from the appropriate WOLAP release.

## 2. Open the Archipelago Launcher

Select:

```text
Install APWorld
```

and choose the new:

```text
westofloathing.apworld
```

Archipelago will install the custom world into your Archipelago installation.

## 3. Update your YAML

Generate a fresh template.

Open the Archipelago Launcher and select:

```text
Generate Template Options
```

The generated templates can be found under:

```text
Players/Templates
```

You can then copy your desired settings into the new West of Loathing template.

> ***Important*** Do not blindly replace an existing customized YAML without first comparing your settings.

---

# Continuing Older Async Games

If you are currently playing an older asynchronous multiworld, check the release compatibility notes before updating the client or AP World used for that game.

If an older game requires an older WOLAP setup, it may be useful to keep that environment separate until the async is finished.

For Mod Manager users, a separate profile can help keep different WOLAP setups isolated.

If the update was a **Breaking** update, do noy update your APWorld until after all games in the older version are completed.

Do not regenerate an existing async game just because a newer WOLAP version has been released.

---

# Problems After Updating?

See the [Troubleshooting Guide](troubleshooting.md).

If you need to completely remove a manual installation before reinstalling, see the [Manual Uninstall Instructions](uninstalling-manual.md).