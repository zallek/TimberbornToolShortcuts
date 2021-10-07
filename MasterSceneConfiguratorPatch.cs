using Bindito.Core;
using HarmonyLib;
using Timberborn.MasterScene;

namespace ToolShortcuts
{
    class MasterSceneConfiguratorPatch
    {
        [HarmonyPatch(typeof(MasterSceneConfigurator), "Configure")]
        public static class ConfigurePatch
        {
            private static void Postfix(IContainerDefinition containerDefinition)
            {
                containerDefinition.Bind<KeyBindings>().AsSingleton();
                containerDefinition.Bind<ExtendedInputService>().AsSingleton();
            }
        }
    }
}