using VoxelTycoon;
using VoxelTycoon.Modding;
using VoxelTycoon.Notifications;
using VoxelTycoon.UI;

namespace HelloVoxelWorldMod
{
    public class HelloVoxelWorldMod : Mod
    {
        protected override void OnGameStarted()
        {
            // Maximum priority so we never miss it.
            var priority = NotificationPriority.Critical;

            // Make the notification look fancy by setting the color
            // to the current company color.
            var color = Company.Current.Color;

            var title = "Hello World!";
            var message = "Oh gosh, this is my first ever C# mod " +
            "for VT, and it's actually working for some reason!";

            // Action is executed when player clicks on notification.
            var action = new HelloVoxelWorldNotificationAction();

            // If you don't need any action, just pass default value (null).
            // var action = default(INotificationAction);

            // Use custom FontAwesome (https://fontawesome.com/icons) icon
            var icon = FontIcon.FaSolid("\uf7e4");

            // And finally, call the API
            NotificationManager.Current.Push(priority, color, title, message, action, icon);
        }

        protected override void OnGameStarting()
        {
            var notificationTypeId = "hello_voxel_world_mod/hello_world_notification_action".GetHashCode();
            NotificationManager.Current.RegisterNotificationAction<HelloVoxelWorldNotificationAction>(notificationTypeId);
        }
    }
}
