using VoxelTycoon.Notifications;
using VoxelTycoon.Serialization;
using VoxelTycoon.UI;

namespace HelloVoxelWorldMod
{
    public class HelloVoxelWorldNotificationAction : INotificationAction
    {
        public void Act()
        {
            OverlayMessage.ShowAtScreenCenter("Yeah, that custom action is working!");
        }

        public void Read(StateBinaryReader reader)
        {
        }

        public void Write(StateBinaryWriter writer)
        {
        }
    }
}
