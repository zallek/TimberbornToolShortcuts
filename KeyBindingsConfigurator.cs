using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace ToolShortcuts {
    class KeyBindingsConfigurator {
        public static void ConfigureKeyBindings() {
            KeyBindings.GroupTools = new Dictionary<ToolGroupName, KeyControl> {
                { ToolGroupName.TreeCutting, KeyNameToKeyControl("g") },
                { ToolGroupName.FieldsPlanting, KeyNameToKeyControl("f") },
                { ToolGroupName.ForestryPlanting, KeyNameToKeyControl("t") },
                { ToolGroupName.Demolishing, KeyNameToKeyControl("x") },
            };
            KeyBindings.Tools = new List<KeyControl> {
                KeyNameToKeyControl("1"),
                KeyNameToKeyControl("2"),
                KeyNameToKeyControl("3"),
                KeyNameToKeyControl("4"),
                KeyNameToKeyControl("5"),
                KeyNameToKeyControl("6"),
                KeyNameToKeyControl("7"),
                KeyNameToKeyControl("8"),
                KeyNameToKeyControl("8"),
                KeyNameToKeyControl("9"),
            };
        }

        private static KeyControl KeyNameToKeyControl(string keyName) {
            return (KeyControl) Keyboard.current[keyName];
        }
    }
    
}