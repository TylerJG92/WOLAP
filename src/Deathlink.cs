using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace WOLAP
{
    internal class Deathlink
    {
        public static void Test()
        {
            MCommand cmd = new MCommand(MCommand.Op.RUNSCRIPT, ["sleef"]);
            MScript script = new MScript("script_sleef", new Dictionary<string, string>());
            MScript.State state = script.NewState("state_sleef");
            state.AddCommand(cmd);
            WolapPlugin.Log.LogInfo("before execute");
            state.Execute();
            WolapPlugin.Log.LogInfo("After");
        }
    }
}