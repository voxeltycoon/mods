using VoxelTycoon;
using VoxelTycoon.Game.UI;
using VoxelTycoon.Modding;

namespace SettingsExampleMod
{
    public class SettingsExampleMainMenuMod : MainMenuMod
    {
        public override bool HasSettings => true;

        protected override void InitializeWorldSettings(WorldSettings worldSettings)
        {
            SetBoolValue(worldSettings, false);
        }

        protected override void SetupSettingsControl(SettingsControl settingsControl, WorldSettings worldSettings)
        {
            var currentValue = worldSettings.GetBool<SettingsExampleMod>("ExampleBoolValue");
            settingsControl.AddToggle("Example bool value", null,
                currentValue,
                () => SetBoolValue(worldSettings, true),
                () => SetBoolValue(worldSettings, false));
        }

        private void SetBoolValue(WorldSettings worldSettings, bool value)
        {
            worldSettings.SetBool<SettingsExampleMod>("ExampleBoolValue", value);
        }
    }
}
