using HarmonyLib;
using System.Linq;
using Timberborn.ToolSystem;

namespace ToolShortcuts
{
    class ToolManagerPatch
    {
        [HarmonyPatch(typeof(ToolManager), "ProcessInput")]
        public static class PatchProcessInput
        {
            private static void Postfix(ref bool? __result, ToolManager __instance)
            {
                if (Plugin.ExtendedInputService.SwitchTool.HasValue)
                {
                    if (SwitchTool(Plugin.ExtendedInputService.SwitchTool.Value, __instance))
                    {
                        __result = true;
                    }
                }
            }

            private static bool SwitchTool(int toolIndex, ToolManager instance)
            {
                if (Plugin.ActiveToolGroupButtons != null && toolIndex < Plugin.ActiveToolGroupButtons.Count())
                {
                    Tool tool = Plugin.ActiveToolGroupButtons.ElementAt(toolIndex).Tool;
                    instance.SwitchTool(tool);
                    return true;
                }
                return false;
            }
        }
    }
}