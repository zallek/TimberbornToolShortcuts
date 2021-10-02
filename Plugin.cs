using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections.Generic;
using System.Reflection;
using Timberborn.InputSystem;
using Timberborn.ToolSystem;

namespace ToolShortcuts
{
    [BepInPlugin("com.zallek.Timberborn.ToolShortcuts", "Tool Shortcuts", "0.2.1")]
    public class Plugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log;
        internal static ExtendedInputService ExtendedInputService;
        internal static List<ToolButton> ActiveToolGroupButtons;

        private void Awake()
        {
            Log = base.Logger;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
