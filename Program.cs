using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var permissions = new PermissionControl();
        var neuroSama = new NeuroSama(permissions);

        permissions.GrantEmotionPermission();
        permissions.GrantDataPermission();

        await neuroSama.SpeakBasedOnMemoryAsync("Based on what you shared with me, here's how I feel.");
    }
}