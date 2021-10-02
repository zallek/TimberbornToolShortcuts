using HarmonyLib;
using System.Collections.Generic;
using System.Reflection;
using Timberborn.InputSystem;
using Timberborn.ToolSystem;

namespace ToolShortcuts
{
    class ToolGroupManagerPatch
    {
        [HarmonyPatch(typeof(ToolGroupManager), "Load")]
        public static class PatchLoad
        {
            private static void Postfix(ToolGroupManager __instance, InputService ____inputService)
            {
                ____inputService.AddInputProcessor(__instance);
            }
        }

        [HarmonyPatch(typeof(ToolGroupManager), "SwitchToolGroup")]
        public static class PatchSwitchToolGroup
        {
            private static void Postfix(ToolGroup toolGroup, ToolGroupManager __instance, InputService ____inputService)
            {
                if (toolGroup == null) {
                    ____inputService.AddInputProcessor(__instance);
                }
            }
        }

        [HarmonyPatch(typeof(ToolGroupManager), "ProcessInput")]
        public static class PatchProcessInput
        {
            private static void Postfix(ref bool? __result, ToolGroupManager __instance, ToolManager ____toolManager)
            {
                if (Plugin.ExtendedInputService.SwitchToolGroup.HasValue)
                {
                    SwitchToolGroup(Plugin.ExtendedInputService.SwitchToolGroup.Value, __instance, ____toolManager);
                    __result = true;
                }
            }

            private static void SwitchToolGroup(ToolGroupName toolGroupName, ToolGroupManager instance, ToolManager toolManager)
            {
                ToolButtonService toolButtonService = (ToolButtonService) typeof(ToolManager).GetField("_toolButtonService", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(toolManager);
                List<ToolGroupButton> toolGroupButtons = (List<ToolGroupButton>) typeof(ToolButtonService).GetField("_toolGroupButtons", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(toolButtonService);

                foreach (ToolGroupButton groupBtn in toolGroupButtons) {
                    ToolGroup toolGroup = (ToolGroup) typeof(ToolGroupButton).GetField("_toolGroup", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(groupBtn);

                    if (ToolGroupNameHelper.FromNameLockey(toolGroup.DisplayNameLocKey) == toolGroupName) {
                        instance.SwitchToolGroup(toolGroup);
                        break;
                    }
                }
            }
        }
    }
}