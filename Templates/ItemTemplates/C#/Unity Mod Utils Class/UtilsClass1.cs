using System.Linq;
using UnityEngine;

namespace $rootnamespace$.Utils
{
    /// <summary>
    /// Static utilities class for common functions and properties to be used within your mod code
    /// </summary>
    internal static class $safeitemname$
    {
        /// <summary>
        /// Example static method to return Players current medal count
        /// </summary>
        /// <returns></returns>
        public static long GetPlayerMedalCount()
        {
            return G.Sys.ProfileManager_.CurrentProfile_.Progress_.TotalMedalCount_;
        }
    }
}
