using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using Timberborn.InputSystem;

namespace ToolShortcuts
{
    class ExtendedInputService
    {
        private KeyboardController _keyboard;
        private KeyBindings _keyBindings;

        public ExtendedInputService(KeyboardController keyboardController, KeyBindings keyBindings)
        {
            _keyboard = keyboardController;
            _keyBindings = keyBindings;
            Plugin.ExtendedInputService = this;
        }

        public int? SwitchTool
        {
            get
            {
                if (!_keyboard.IsKeyHeld(Key.LeftShift))
                {
                    for (int i = 0; i < _keyBindings.Tools.Count; i++)
                    {
                        if (_keyBindings.Tools[i] != null && _keyboard.IsKeyDown(_keyBindings.Tools[i].keyCode))
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
                    foreach (KeyValuePair<ToolGroupName, KeyControl> entry in _keyBindings.GroupTools)
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