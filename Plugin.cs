using BepInEx;
using HarmonyLib;

namespace BetterShotgun
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        readonly Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            ShotgunConfig.LoadConfig(Config);
            Logger.LogInfo("Config loaded");
            harmony.PatchAll(typeof(ShotgunPatch));
            harmony.PatchAll(typeof(ShotgunConfig));
        }
    }
}
