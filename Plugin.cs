using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace ToolShortcuts
{
    [BepInPlugin("com.zallek.Timberborn.ToolShortcuts", "Tool Shortcuts", "0.0.1")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());

            Logger.LogInfo($"Plugin ToolShortcuts is loaded!");
        }
    }
}
