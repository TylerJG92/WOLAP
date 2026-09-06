# Changelog for v0.2.4 to v0.2.5
This is the list of the changes that I have added for the next version update

## Bug Fixes:
* Warning was showing in AP server admin logs whenever a player logged into a WOLAP game `Notice ($Slot_Name in team 1): Warning: your client does not support compressed websocket connectins! It may stop working in the future. If you are a player, please report this to the client's developer.`
    - Resolved issue by creating my own version of the `websocket-sharp.dll` that fixes a bug in that libraries code then updating it in `Archipelago.MultiClient.Net.dll` and changing the framework routing to allow for the use of the websocket extention with netstandard2.0
        - If further testing of my "fix" to both libraries allows for all frameworks that didnt use to have compression able to be reliably activated (netstandard2.0, .NET35, .NET40 and .NET45) proves to work for them as well, the devs of the `Archipelago.MultiClient.Net.dll` may merge my fix into their code and distribute it. at which point we will be switching back from my own version of their code to the official souce again.
* 