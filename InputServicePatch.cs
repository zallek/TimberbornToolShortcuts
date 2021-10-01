using HarmonyLib;
using Timberborn.InputSystem;

namespace ToolShortcuts
{
    class InputServicePatch
    {
        [HarmonyPatch(typeof(InputService), "ChangeGameSpeed")]
        public static class PatchChangeGameSpeed
        {
            private static void Postfix(ref int? __result, InputService __instance)
            {
                if (!__instance.IsAltHeld)
                {
                    __result = null;
                }
            }
        }
    }
}