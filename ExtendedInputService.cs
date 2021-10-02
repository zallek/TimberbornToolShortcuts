using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using Timberborn.InputSystem;

namespace ToolShortcuts
{
    class ExtendedInputService
    {
        private KeyboardController _keyboard;

        public ExtendedInputService(KeyboardController keyboardController)
        {
            _keyboard = keyboardController;
            KeyBindingsConfigurator.ConfigureKeyBindings();
        }

        public int? SwitchTool
        {
            get
            {
                if (!_keyboard.IsKeyHeld(Key.LeftShift))
                {
                    for (int i = 0; i < KeyBindings.Tools.Count; i++)
                    {
                        if (KeyBindings.Tools[i] != null && _keyboard.IsKeyDown(KeyBindings.Tools[i].keyCode))
                        {
                            return i;
                        }
                    }
                }
                return null;
            }
        }

        public ToolGroupName? SwitchToolGroup
        {
            get
            {
                if (!_keyboard.IsKeyHeld(Key.LeftShift))
                {
                    foreach (KeyValuePair<ToolGroupName, KeyControl> entry in KeyBindings.GroupTools)
                    {
                        if (entry.Value != null && _keyboard.IsKeyDown(entry.Value.keyCode))
                        {
                            return entry.Key;
                        }
                    }
                }
                return null;
            }
        }
    }
}