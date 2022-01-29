using VoxelTycoon;
using VoxelTycoon.Modding;
using VoxelTycoon.UI.Windows;

namespace SettingsExampleMod
{
    public class SettingsExampleMod : Mod
    {
        protected override void OnGameStarted()
        {
            var boolValue = WorldSettings.Current.GetBool<SettingsExampleMod>("ExampleBoolValue");
            Dialog.ShowPositiveMessage(boolValue.ToString());
        }
    }
}
