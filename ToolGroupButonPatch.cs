using HarmonyLib;
using System.Collections.Generic;
using Timberborn.ToolSystem;
using UnityEngine;
using UnityEngine.UIElements;

namespace ToolShortcuts
{
    class ToolGroupButtonPatch
    {
        [HarmonyPatch(typeof(ToolGroupButton), "PostLoad")]
        public static class PatchPostLoad
        {
            private static void Postfix(List<ToolButton> ____toolButtons)
            {
                for (int i = 0; i < ____toolButtons.Count && i < 10; i++)
                {
                    Label keyBindingLabel = new Label(KeyBindings.Tools[i].name);
                    keyBindingLabel.style.position = Position.Absolute;
                    keyBindingLabel.style.top = 4;
                    keyBindingLabel.style.left = 0;
                    keyBindingLabel.style.width = 20;
                    keyBindingLabel.style.backgroundColor = new Color(0f, 0f, 0f, 0f);
                    keyBindingLabel.style.color = new Color(0.75f, 0.65f, 0.44f);
                    keyBindingLabel.style.fontSize = 10;

                    ____toolButtons[i].Root.Add(keyBindingLabel);
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