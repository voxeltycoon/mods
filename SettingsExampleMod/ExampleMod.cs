using VoxelTycoon;
using VoxelTycoon.Modding;
using VoxelTycoon.UI.Windows;

namespace SettingsExampleMod
{
    public class ExampleMod : Mod
    {
        protected override void OnGameStarted()
        {
            var showDialog = WorldSettings.Current.GetBool<ExampleSettingsMod>(ExampleSettingsMod.ShowDialogKey);
            if (showDialog)
                Dialog.ShowPositiveMessage("Yay, it's working!");
        }
    }
}
