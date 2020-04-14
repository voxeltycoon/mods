using UnityEngine;
using VoxelTycoon.Game.UI;
using VoxelTycoon.Tools;
using VoxelTycoon.UI;

namespace OldSchoolStyleMod
{
    public class OldSchoolStyleModSettingsTool : ITool
    {
        private const KeyCode _toggleKey = KeyCode.Z;

        private HotkeysUIItem _toggleHotkey;

        public void Activate()
        {
            _toggleHotkey = HotkeysUI.Current.Add(string.Empty, _toggleKey);
        }

        public bool OnUpdate()
        {
            if (ToolHelper.IsHotkeyDown(_toggleKey))
                OldSchoolStyleManager.Current.Enabled ^= true;

            _toggleHotkey.SetCaption(OldSchoolStyleManager.Current.Enabled ? "Disable" : "Enable");

            return false;
        }

        public bool TryDeactivate()
        {
            HotkeysUI.Current.Clear();

            return true;
        }
    }
}
