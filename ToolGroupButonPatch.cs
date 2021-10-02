using HarmonyLib;
using System.Collections.Generic;
using Timberborn.ToolSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

namespace ToolShortcuts
{
    class ToolGroupButtonPatch
    {
        [HarmonyPatch(typeof(ToolGroupButton), "PostLoad")]
        public static class PatchPostLoad
        {
            private static void Postfix(ToolGroupButton __instance, ToolGroup ____toolGroup, List<ToolButton> ____toolButtons)
            {
                DisplayGroupBindingLabel(__instance.Root, ____toolGroup);
                DisplayGroupButtonsLabels(____toolButtons);
            }

            private static void DisplayGroupBindingLabel(VisualElement root, ToolGroup toolGroup)
            {
                ToolGroupName? groupName = ToolGroupNameHelper.FromNameLockey(toolGroup.DisplayNameLocKey);
                if (!groupName.HasValue) return;

                KeyControl keyControl = KeyBindings.GroupTools.GetValueOrDefault(groupName.Value, null);
                if (keyControl == null) return;

                KeyBindingLabel label = new KeyBindingLabel(keyControl.displayName);
                label.style.left = 6;
                root.Add(label);
            }

            private static void DisplayGroupButtonsLabels(List<ToolButton> toolButtons)
            {
                for (int i = 0; i < toolButtons.Count && i < KeyBindings.Tools.Count; i++)
                {
                    toolButtons[i].Root.Add(new KeyBindingLabel(KeyBindings.Tools[i].displayName));
                }
            }
        }

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