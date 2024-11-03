using HarmonyLib;
using Exiled.Loader.Features;

namespace ExiledLoadMessage.Patches
{
    [HarmonyPatch(typeof(LoaderMessages), nameof(LoaderMessages.GetMessage))]
    internal class LoadMessage
    {
        static void Postfix(ref string __result) => __result = Plugin.plugin.Config.LoadText;
    }
}
