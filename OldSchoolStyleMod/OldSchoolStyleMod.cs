using VoxelTycoon;
using VoxelTycoon.Game.UI.ModernUI;
using VoxelTycoon.Modding;
using VoxelTycoon.Serialization;
using VoxelTycoon.UI;

namespace OldSchoolStyleMod
{
    public class OldSchoolStyleMod : IMod
    {
        public void OnBeforeGameLoad()
        {
            OldSchoolStyleManager.Initialize();
        }

        public void OnGameLoaded()
        {
            Toolbar.Current.AddButton(FontIcon.Ketizoloto(I.Settings1), "Old school style settings", new ToolToolbarAction(() => new OldSchoolStyleModSettingsTool()));
        }

        public void Read(StateBinaryReader reader)
        {
            OldSchoolStyleManager.Current.Enabled = reader.ReadBool();
        }

        public void Write(StateBinaryWriter writer)
        {
            writer.WriteBool(OldSchoolStyleManager.Current.Enabled);
        }
    }
}
