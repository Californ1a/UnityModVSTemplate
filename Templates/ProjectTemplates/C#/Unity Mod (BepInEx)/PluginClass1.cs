using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using $safeprojectname$.Properties;

namespace $safeprojectname$
{
    // TODO Review this file and update to your own requirements.

    [BepInPlugin(ModInfo.MyGUID, ModInfo.PluginName, ModInfo.Version)]
    public class $safeprojectname$Plugin : BaseUnityPlugin
    {
        // Config entry key strings
        // These will appear in the config file created by BepInEx and can also be used
        // by the OnSettingsChange event to determine which setting has changed.
        public static string FloatExampleKey = "Float Example Key";
        public static string IntExampleKey = "Int Example Key";
        public static string KeyboardShortcutExampleKey = "Recall Keyboard Shortcut";

        // Configuration entries. Static, so can be accessed directly elsewhere in code via
        // e.g.
        // float myFloat = $safeprojectname$Plugin.FloatExample.Value;
        // TODO Change this code or remove the code if not required.
        public static ConfigEntry<float> FloatExample;
        public static ConfigEntry<int> IntExample;
        public static ConfigEntry<KeyboardShortcut> KeyboardShortcutExample;

        private static readonly Harmony Harmony = new Harmony(ModInfo.MyGUID);
        internal static ManualLogSource Log;

        /// <summary>
        /// Initialise the configuration settings and patch methods
        /// </summary>
        private void Awake()
        {
            // Sets up our static Log, so it can be used elsewhere in code.
            // .e.g.
            // $safeprojectname$Plugin.Log.LogDebug("Debug Message to BepInEx log file");
			Log = BepInEx.Logging.Logger.CreateLogSource(ModInfo.PluginName);

            // Float configuration setting example
            // TODO Change this code or remove the code if not required.
            FloatExample = Config.Bind("General", // The section under which the option is shown
                FloatExampleKey, // The key of the configuration option
                1.0f, // The default value
                new ConfigDescription("Example float configuration setting.", // Description that appears in Configuration Manager
                    new AcceptableValueRange<float>(0.0f, 10.0f))); // Acceptable range, enabled slider and validation in Configuration Manager

            // Int setting example
            // TODO Change this code or remove the code if not required.
            IntExample = Config.Bind("General",
                IntExampleKey,
                1,
                new ConfigDescription("Example int configuration setting.",
                    new AcceptableValueRange<int>(0, 10)));

            // Keyboard shortcut setting example
            // TODO Change this code or remove the code if not required.
            KeyboardShortcutExample = Config.Bind("General",
                KeyboardShortcutExampleKey,
                new KeyboardShortcut(KeyCode.A, KeyCode.LeftControl));

            // Add listeners methods to run if and when settings are changed by the player.
            // TODO Change this code or remove the code if not required.
            FloatExample.SettingChanged += ConfigSettingChanged;
            IntExample.SettingChanged += ConfigSettingChanged;
            KeyboardShortcutExample.SettingChanged += ConfigSettingChanged;

            // Apply all of our patches
            Logger.LogInfo("Loading...");
            Harmony.PatchAll();
            Logger.LogInfo("Loaded");
        }

        /// <summary>
        /// Code executed every frame. See below for an example use case
        /// to detect keypress via custom configuration.
        /// </summary>
        // TODO - Add your code here or remove this section if not required.
        private void Update()
        {
            if ($safeprojectname$Plugin.KeyboardShortcutExample.Value.IsDown())
	    {
	        // Code here to do something on keypress
                Logger.LogInfo("Keypress detected!");
            }
        }

        /// <summary>
        /// Method to handle changes to configuration made by the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigSettingChanged(object sender, System.EventArgs e)
        {
            SettingChangedEventArgs settingChangedEventArgs = e as SettingChangedEventArgs;

            // Check if null and return
            if (settingChangedEventArgs == null) return;

            // Example Float Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == FloatExampleKey)
            {
                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
            }

            // Example Int Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == IntExampleKey)
            {
                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
            }

            // Example Keyboard Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == KeyboardShortcutExampleKey)
            {
                KeyboardShortcut newValue = (KeyboardShortcut)settingChangedEventArgs.ChangedSetting.BoxedValue;

                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
            }
        }
    }
}
