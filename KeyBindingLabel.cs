using UnityEngine;
using UnityEngine.UIElements;

namespace ToolShortcuts {
    class KeyBindingLabel: Label {
        public KeyBindingLabel(string keyBindingText) {
            text = keyBindingText;
            style.position = Position.Absolute;
            style.top = 4;
            style.left = 0;
            style.width = 20;
            style.backgroundColor = new Color(0f, 0f, 0f, 0f);
            style.color = new Color(0.75f, 0.65f, 0.44f);
            style.fontSize = 10;
        }
    }
}