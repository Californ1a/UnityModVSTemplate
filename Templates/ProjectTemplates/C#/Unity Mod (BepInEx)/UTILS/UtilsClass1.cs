using UnityEngine;

namespace $safeprojectname$.Utils
{
    /// <summary>
    /// Static utilities class for common functions and properties to be used within your mod code
    /// </summary>
    internal static class ModUtils
    {
        /// <summary>
        /// Example static method to return Players current profile data
        /// </summary>
        /// <returns></returns>
        public static Profile GetPlayerProfile()
        {
            return PlayerManager.Current_.profile;
        }
    }
}
