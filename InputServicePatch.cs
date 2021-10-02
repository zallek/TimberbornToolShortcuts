using HarmonyLib;
using Timberborn.InputSystem;

namespace ToolShortcuts
{
    class InputServicePatch
    {
        [HarmonyPatch(typeof(InputService), "InjectDependencies")]
        public static class PatchInjectDependencies
        {
            private static void Postfix(KeyboardController keyboardController)
            {
                Plugin.ExtendedInputService = new ExtendedInputService(keyboardController);
            }
        }

        [HarmonyPatch(typeof(InputService), "ChangeGameSpeed", MethodType.Getter)]
        public static class PatchChangeGameSpeed
        {
            private static void Postfix(ref int? __result, InputService __instance)
            {
                if (__result > 0 && !__instance.IsAltHeld)
                {
                    __result = null;
                }
            }
        }
    }
}