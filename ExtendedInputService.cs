using UnityEngine.InputSystem;
using Timberborn.InputSystem;

namespace ToolShortcuts
{
    class ExtendedInputService
    {
        private KeyboardController _keyboard;

        public ExtendedInputService(KeyboardController keyboardController) {
            _keyboard = keyboardController;
            KeyBindingsConfigurator.ConfigureKeyBindings();
        }

        public int? SwitchTool
        {
            get
            {
                if (!_keyboard.IsKeyHeld(Key.LeftShift))
                {
                    for (int i = 0; i < KeyBindings.Tools.Count; i++) {
                        if (_keyboard.IsKeyDown(KeyBindings.Tools[i].keyCode))
                        {
                            return i;
                        }
                    }
                }
                return null;
            }
        }
    }
}