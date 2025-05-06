public class PermissionControl
{
    public bool EmotionPermissionGranted { get; private set; } = false;
    public bool DataPermissionGranted { get; private set; } = false;

    public void GrantEmotionPermission() => EmotionPermissionGranted = true;
    public void GrantDataPermission() => DataPermissionGranted = true;
}