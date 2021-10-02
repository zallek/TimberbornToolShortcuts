using UnityEngine.InputSystem;
using Timberborn.InputSystem;

namespace ToolShortcuts
{
    class ExtendedInputService
    {
        public int? SwitchTool
        {
            get
            {
                KeyboardController _keyboard = Plugin.KeyboardController;

                if (!_keyboard.IsKeyHeld(Key.LeftShift))
                {
                    if (_keyboard.IsKeyDown(Key.Digit1))
                    {
                        return 1;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit2))
                    {
                        return 2;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit3))
                    {
                        return 3;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit4))
                    {
                        return 4;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit5))
                    {
                        return 5;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit6))
                    {
                        return 6;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit7))
                    {
                        return 7;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit8))
                    {
                        return 8;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit9))
                    {
                        return 9;
                    }
                    if (_keyboard.IsKeyDown(Key.Digit0))
                    {
                        return 10;
                    }
                }
                return null;
            }
        }
    }
}