namespace ToolShortcuts
{
    public enum ToolGroupName
    {
        TreeCutting,
        FieldsPlanting,
        ForestryPlanting,
        Demolishing,
        Priority,
        Paths,
        Landscaping,
        Storage,
        Labor,
        Housing,
        Water,
        Food,
        Wood,
        Metal,
        Power,
        Science,
        Leisure,
        Decoration,
        Monuments,
        MapEditor,
        Ruins,
    }


    class ToolGroupNameHelper
    {
        public static ToolGroupName? FromNameLockey(string nameLockey)
        {
            switch (nameLockey)
            {
                case "ToolGroups.TreeCutting": return ToolGroupName.TreeCutting;
                case "ToolGroups.FieldsPlanting": return ToolGroupName.FieldsPlanting;
                case "ToolGroups.ForestryPlanting": return ToolGroupName.ForestryPlanting;
                case "ToolGroups.Demolishing": return ToolGroupName.Demolishing;
                case "ToolGroups.Priority": return ToolGroupName.Priority;
                case "ToolGroups.Paths": return ToolGroupName.Paths;
                case "ToolGroups.Landscaping": return ToolGroupName.Landscaping;
                case "ToolGroups.Storage": return ToolGroupName.Storage;
                case "ToolGroups.Labor": return ToolGroupName.Labor;
                case "ToolGroups.Housing": return ToolGroupName.Housing;
                case "ToolGroups.Water": return ToolGroupName.Water;
                case "ToolGroups.Food": return ToolGroupName.Food;
                case "ToolGroups.Wood": return ToolGroupName.Wood;
                case "ToolGroups.Metal": return ToolGroupName.Metal;
                case "ToolGroups.Power": return ToolGroupName.Power;
                case "ToolGroups.Science": return ToolGroupName.Science;
                case "ToolGroups.Leisure": return ToolGroupName.Leisure;
                case "ToolGroups.Decoration": return ToolGroupName.Decoration;
                case "ToolGroups.Monuments": return ToolGroupName.Monuments;
                case "ToolGroups.MapEditor": return ToolGroupName.MapEditor;
                case "ToolGroups.Ruins": return ToolGroupName.Ruins;
                default: return null;
            }
        }
    }
}