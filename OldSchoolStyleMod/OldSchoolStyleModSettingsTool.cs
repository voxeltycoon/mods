using UnityEngine;
using VoxelTycoon;
using VoxelTycoon.Game.UI;
using VoxelTycoon.Tools;
using VoxelTycoon.UI;

namespace OldSchoolStyleMod
{
    public class OldSchoolStyleModSettingsTool : ITool
    {
        private Hotkey _toggleHotkey = new Hotkey(KeyCode.Z);
        private HotkeyPanelItem _toggleHotkeyPanelItem;

        public void Activate()
        {
            _toggleHotkeyPanelItem = HotkeyPanel.Current.Add(string.Empty).AddKey(_toggleHotkey);
        }

        public bool Deactivate(bool soft)
        {
            HotkeyPanel.Current.Clear();
            return true;
        }

        public bool OnUpdate()
        {
            if (ToolHelper.IsHotkeyDown(_toggleHotkey))
                OldSchoolStyleManager.Current.Enabled ^= true;

            _toggleHotkeyPanelItem.SetCaption(OldSchoolStyleManager.Current.Enabled ? "Disable" : "Enable");

            return false;
        }
    }
}