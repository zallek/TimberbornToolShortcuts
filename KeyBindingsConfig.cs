using BepInEx.Configuration;

namespace ToolShortcuts
{
    static class KeyBindingsConfig
    {
        public static ConfigEntry<string> treeCuttingGroupTool;
        public static ConfigEntry<string> fieldsPlantingGroupTool;
        public static ConfigEntry<string> forestryPlantingGroupTool;
        public static ConfigEntry<string> demolishingGroupTool;
        public static ConfigEntry<string> priorityGroupTool;
        public static ConfigEntry<string> pathsGroupTool;
        public static ConfigEntry<string> landscapingGroupTool;
        public static ConfigEntry<string> storageGroupTool;
        public static ConfigEntry<string> laborGroupTool;
        public static ConfigEntry<string> housingGroupTool;
        public static ConfigEntry<string> waterGroupTool;
        public static ConfigEntry<string> foodGroupTool;
        public static ConfigEntry<string> woodGroupTool;
        public static ConfigEntry<string> metalGroupTool;
        public static ConfigEntry<string> powerGroupTool;
        public static ConfigEntry<string> scienceGroupTool;
        public static ConfigEntry<string> leisureGroupTool;
        public static ConfigEntry<string> decorationGroupTool;
        public static ConfigEntry<string> monumentsGroupTool;
        public static ConfigEntry<string> mapEditorGroupTool;
        public static ConfigEntry<string> ruinsGroupTool;

        public static ConfigEntry<string> tool1;
        public static ConfigEntry<string> tool2;
        public static ConfigEntry<string> tool3;
        public static ConfigEntry<string> tool4;
        public static ConfigEntry<string> tool5;
        public static ConfigEntry<string> tool6;
        public static ConfigEntry<string> tool7;
        public static ConfigEntry<string> tool8;
        public static ConfigEntry<string> tool9;
        public static ConfigEntry<string> tool10;
        public static ConfigEntry<string> tool11;
        public static ConfigEntry<string> tool12;
        public static ConfigEntry<string> tool13;
        public static ConfigEntry<string> tool14;
        public static ConfigEntry<string> tool15;
        public static ConfigEntry<string> tool16;

        public static void Bind(ConfigFile configFile)
        {
            treeCuttingGroupTool = configFile.Bind("Key bindings", "treeCuttingGroupTool", "G");
            fieldsPlantingGroupTool = configFile.Bind("Key bindings", "fieldsPlantingGroupTool", "F");
            forestryPlantingGroupTool = configFile.Bind("Key bindings", "forestryPlantingGroupTool", "T");
            demolishingGroupTool = configFile.Bind("Key bindings", "demolishingGroupTool", "X");
            priorityGroupTool = configFile.Bind("Key bindings", "priorityGroupTool", "");
            pathsGroupTool = configFile.Bind("Key bindings", "pathsGroupTool", "");
            landscapingGroupTool = configFile.Bind("Key bindings", "landscapingGroupTool", "");
            storageGroupTool = configFile.Bind("Key bindings", "storageGroupTool", "");
            laborGroupTool = configFile.Bind("Key bindings", "laborGroupTool", "");
            housingGroupTool = configFile.Bind("Key bindings", "housingGroupTool", "");
            waterGroupTool = configFile.Bind("Key bindings", "waterGroupTool", "");
            foodGroupTool = configFile.Bind("Key bindings", "foodGroupTool", "");
            woodGroupTool = configFile.Bind("Key bindings", "woodGroupTool", "");
            metalGroupTool = configFile.Bind("Key bindings", "metalGroupTool", "");
            powerGroupTool = configFile.Bind("Key bindings", "powerGroupTool", "");
            scienceGroupTool = configFile.Bind("Key bindings", "scienceGroupTool", "");
            leisureGroupTool = configFile.Bind("Key bindings", "leisureGroupTool", "");
            decorationGroupTool = configFile.Bind("Key bindings", "decorationGroupTool", "");
            monumentsGroupTool = configFile.Bind("Key bindings", "monumentsGroupTool", "");
            mapEditorGroupTool = configFile.Bind("Key bindings", "mapEditorGroupTool", "");
            ruinsGroupTool = configFile.Bind("Key bindings", "ruinsGroupTool", "");

            tool1 = configFile.Bind("Key bindings", "tool1", "1");
            tool2 = configFile.Bind("Key bindings", "tool2", "2");
            tool3 = configFile.Bind("Key bindings", "tool3", "3");
            tool4 = configFile.Bind("Key bindings", "tool4", "4");
            tool5 = configFile.Bind("Key bindings", "tool5", "5");
            tool6 = configFile.Bind("Key bindings", "tool6", "6");
            tool7 = configFile.Bind("Key bindings", "tool7", "7");
            tool8 = configFile.Bind("Key bindings", "tool8", "8");
            tool9 = configFile.Bind("Key bindings", "tool9", "9");
            tool10 = configFile.Bind("Key bindings", "tool10", "0");
            tool11 = configFile.Bind("Key bindings", "tool11", "");
            tool12 = configFile.Bind("Key bindings", "tool12", "");
            tool13 = configFile.Bind("Key bindings", "tool13", "");
            tool14 = configFile.Bind("Key bindings", "tool14", "");
            tool15 = configFile.Bind("Key bindings", "tool15", "");
            tool16 = configFile.Bind("Key bindings", "tool16", "");
        }
    }
}