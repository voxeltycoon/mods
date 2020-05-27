using VoxelTycoon;
using VoxelTycoon.Game.UI.ModernUI;
using VoxelTycoon.Modding;
using VoxelTycoon.Serialization;
using VoxelTycoon.UI;

namespace OldSchoolStyleMod
{
    public class OldSchoolStyleMod : Mod
    {
        protected override void OnGameStarting()
        {
            OldSchoolStyleManager.Initialize();
        }

        protected override void OnGameStarted()
        {
            Toolbar.Current.AddButton(FontIcon.Ketizoloto(I.Settings1), "Old school style settings", new ToolToolbarAction(() => new OldSchoolStyleModSettingsTool()));
        }

        protected override void Read(StateBinaryReader reader)
        {
            OldSchoolStyleManager.Current.Enabled = reader.ReadBool();
        }

        protected override void Write(StateBinaryWriter writer)
        {
            writer.WriteBool(OldSchoolStyleManager.Current.Enabled);
        }
    }
}
