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
                int? toolNum = Plugin.ExtendedInputService.SwitchTool;
                if (toolNum.HasValue && Plugin.ActiveToolGroupButtons != null && toolNum.Value < Plugin.ActiveToolGroupButtons.Count())
                {
                    ToolButton btn = Plugin.ActiveToolGroupButtons.ElementAt(toolNum.Value);
                    __instance.SwitchTool(btn.Tool);
                    __result = true;
                } 
            }
        }
    }
}