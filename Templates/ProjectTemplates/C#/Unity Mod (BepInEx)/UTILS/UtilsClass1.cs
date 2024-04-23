using UnityEngine;

namespace $safeprojectname$.Utils
{
    /// <summary>
    /// Static utilities class for common functions and properties to be used within your mod code
    /// </summary>
    internal static class ModUtils
    {
        /// <summary>
        /// Example static method to return Players current medal count
        /// </summary>
        public static long GetPlayerMedalCount()
        {
            return G.Sys.ProfileManager_.CurrentProfile_.Progress_.TotalMedalCount_;
        }
    }
}
