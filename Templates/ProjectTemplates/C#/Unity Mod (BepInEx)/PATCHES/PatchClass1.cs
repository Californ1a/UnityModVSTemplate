using HarmonyLib;

namespace $safeprojectname$.Patches
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    /// <summary>
    /// Sample Harmony Patch class. Suggestion is to use one file per patched class
    /// though you can include multiple patch classes in one file.
    /// Below is included as an example, and should be replaced by classes and methods
    /// for your mod.
    /// </summary>
    [HarmonyPatch(typeof(PlayerManager))]
    internal class PlayerManagerPatches
    {
        /// <summary>
        /// Patches the PlayerManager Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("Awake")]
        [HarmonyPrefix]
        public static bool Awake_Prefix(PlayerManager __instance)
        {
            $safeprojectname$Plugin.Log.LogInfo("In PlayerManager Awake method Prefix.");
            return true;
        }

        /// <summary>
        /// Patches the PlayerManager Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("Awake")]
        [HarmonyPostfix]
        public static void Awake_Postfix(PlayerManager __instance)
        {
            $safeprojectname$Plugin.Log.LogInfo("In PlayerManager Awake method Postfix.");
        }
    }
}
