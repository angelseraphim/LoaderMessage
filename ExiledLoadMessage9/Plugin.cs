using Exiled.API.Features;
using HarmonyLib;

namespace ExiledLoadMessage
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "angelseraphim.";
        public override string Name => "ExiledLoadMessage";
        public override string Prefix => "ExiledLoadMessage";

        public static Plugin plugin;
        public static Harmony harmony;
        public override void OnEnabled()
        {
            plugin = this;
            harmony = new Harmony("ExiledLoadMessage");
            harmony.PatchAll();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            plugin = null;
            harmony.UnpatchAll();
            base.OnDisabled();
        }
    }
}
