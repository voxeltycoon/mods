using VoxelTycoon;
using VoxelTycoon.Game.UI;
using VoxelTycoon.Modding;

namespace SettingsExampleMod
{
    public class ExampleSettingsMod : SettingsMod
    {
        public const string ShowDialogKey = "ShowDialog";

        protected override void SetDefaults(WorldSettings worldSettings)
        {
            worldSettings.SetBool<ExampleSettingsMod>(ShowDialogKey, false);
        }

        protected override void SetupSettingsControl(SettingsControl settingsControl, WorldSettings worldSettings)
        {
            settingsControl.AddToggle("Show dialog", null,
                worldSettings.GetBool<ExampleSettingsMod>(ShowDialogKey),
                () => worldSettings.SetBool<ExampleSettingsMod>(ShowDialogKey, true),
                () => worldSettings.SetBool<ExampleSettingsMod>(ShowDialogKey, false));
        }
    }
}
