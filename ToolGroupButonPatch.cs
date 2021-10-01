using HarmonyLib;
using System.Collections.Generic;
using Timberborn.ToolSystem;

namespace ToolShortcuts
{
    class ToolGroupButtonPatch
    {
        [HarmonyPatch(typeof(ToolGroupButton), "OnToolGroupEntered")]
        public static class PatchOnToolGroupEntered
        {
            private static void Postfix(ToolGroupEnteredEvent toolGroupEnteredEvent, ToolGroup ____toolGroup, List<ToolButton> ____toolButtons)
            {
                if (toolGroupEnteredEvent.ToolGroup == ____toolGroup)
                {
                    Plugin.ActiveToolGroupButtons = ____toolButtons;
                }
            }
        }

        [HarmonyPatch(typeof(ToolGroupButton), "OnToolGroupExited")]
        public static class PatchOnToolGroupExited
        {
            private static void Postfix(ToolGroupExitedEvent toolGroupExitedEvent, ToolGroup ____toolGroup, List<ToolButton> ____toolButtons)
            {
                if (toolGroupExitedEvent.ToolGroup == ____toolGroup)
                {
                    Plugin.ActiveToolGroupButtons = null;
                }
            }
        }
    }
}