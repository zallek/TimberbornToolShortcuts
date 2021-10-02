using BepInEx.Configuration;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace ToolShortcuts
{
    class KeyBindingsConfigurator
    {
        public static void ConfigureKeyBindings()
        {
            KeyBindings.GroupTools = new Dictionary<ToolGroupName, KeyControl> {
                { ToolGroupName.TreeCutting, ConfigEntryToKeyControl(KeyBindingsConfig.treeCuttingGroupTool) },
                { ToolGroupName.FieldsPlanting, ConfigEntryToKeyControl(KeyBindingsConfig.fieldsPlantingGroupTool) },
                { ToolGroupName.ForestryPlanting, ConfigEntryToKeyControl(KeyBindingsConfig.forestryPlantingGroupTool) },
                { ToolGroupName.Demolishing, ConfigEntryToKeyControl(KeyBindingsConfig.demolishingGroupTool) },
                { ToolGroupName.Priority, ConfigEntryToKeyControl(KeyBindingsConfig.priorityGroupTool) },
                { ToolGroupName.Paths, ConfigEntryToKeyControl(KeyBindingsConfig.pathsGroupTool) },
                { ToolGroupName.Landscaping, ConfigEntryToKeyControl(KeyBindingsConfig.landscapingGroupTool) },
                { ToolGroupName.Storage, ConfigEntryToKeyControl(KeyBindingsConfig.storageGroupTool) },
                { ToolGroupName.Labor, ConfigEntryToKeyControl(KeyBindingsConfig.laborGroupTool) },
                { ToolGroupName.Housing, ConfigEntryToKeyControl(KeyBindingsConfig.housingGroupTool) },
                { ToolGroupName.Water, ConfigEntryToKeyControl(KeyBindingsConfig.waterGroupTool) },
                { ToolGroupName.Food, ConfigEntryToKeyControl(KeyBindingsConfig.foodGroupTool) },
                { ToolGroupName.Wood, ConfigEntryToKeyControl(KeyBindingsConfig.woodGroupTool) },
                { ToolGroupName.Metal, ConfigEntryToKeyControl(KeyBindingsConfig.metalGroupTool) },
                { ToolGroupName.Power, ConfigEntryToKeyControl(KeyBindingsConfig.powerGroupTool) },
                { ToolGroupName.Science, ConfigEntryToKeyControl(KeyBindingsConfig.scienceGroupTool) },
                { ToolGroupName.Leisure, ConfigEntryToKeyControl(KeyBindingsConfig.leisureGroupTool) },
                { ToolGroupName.Decoration, ConfigEntryToKeyControl(KeyBindingsConfig.decorationGroupTool) },
                { ToolGroupName.Monuments, ConfigEntryToKeyControl(KeyBindingsConfig.monumentsGroupTool) },
                { ToolGroupName.MapEditor, ConfigEntryToKeyControl(KeyBindingsConfig.mapEditorGroupTool) },
                { ToolGroupName.Ruins, ConfigEntryToKeyControl(KeyBindingsConfig.ruinsGroupTool) },
            };
            KeyBindings.Tools = new List<KeyControl> {
                ConfigEntryToKeyControl(KeyBindingsConfig.tool1),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool2),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool3),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool4),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool5),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool6),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool7),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool8),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool9),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool10),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool11),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool12),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool13),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool14),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool15),
                ConfigEntryToKeyControl(KeyBindingsConfig.tool16),
            };
        }

        private static KeyControl ConfigEntryToKeyControl(ConfigEntry<string> configEntry)
        {
            string value = configEntry.Value.ToLower();
            return value != "" ? (KeyControl)Keyboard.current[value] : null;
        }
    }

}