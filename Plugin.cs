using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections.Generic;
using System.Reflection;
using Timberborn.ToolSystem;

namespace ToolShortcuts
{
    [BepInPlugin("Timberborn.ToolShortcuts", "Tool Shortcuts", "0.3.1")]
    public class Plugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log;
        internal static KeyBindings KeyBindings;
        internal static ExtendedInputService ExtendedInputService;
        internal static List<ToolButton> ActiveToolGroupButtons;

        private void Awake()
        {
            Log = base.Logger;

            KeyBindingsConfig.Bind(Config);

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    }
}