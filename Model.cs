using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class NeuroSama
{
    private readonly PermissionControl permissions;
    private readonly Dictionary<Emotion, EmotionVoiceProfile> emotionProfiles;

    public NeuroSama(PermissionControl permissionControl)
    {
        permissions = permissionControl;
        emotionProfiles = new Dictionary<Emotion, EmotionVoiceProfile>
        {
            { Emotion.Neutral, new EmotionVoiceProfile(1.0f, 1.0f, 1.0f) },
            { Emotion.Happy, new EmotionVoiceProfile(1.2f, 1.1f, 1.2f) },
            { Emotion.Sad, new EmotionVoiceProfile(0.8f, 0.9f, 0.7f) },
            { Emotion.Angry, new EmotionVoiceProfile(1.3f, 1.2f, 1.3f) },
            { Emotion.Excited, new EmotionVoiceProfile(1.4f, 1.3f, 1.4f) },
            { Emotion.Calm, new EmotionVoiceProfile(0.9f, 0.95f, 0.9f) }
        };
    }

    private Emotion InferEmotionFromData(List<string> data)
    {
        foreach (var entry in data)
        {
            if (entry.Contains("sad")) return Emotion.Sad;
            if (entry.Contains("anxious")) return Emotion.Calm;
            if (entry.Contains("joke")) return Emotion.Happy;
            if (entry.Contains("passed")) return Emotion.Excited;
        }
        return Emotion.Neutral;
    }

    public async Task SpeakBasedOnMemoryAsync(string message)
    {
        if (!permissions.EmotionPermissionGranted || !permissions.DataPermissionGranted)
        {
            Console.WriteLine("Error: Required permissions not granted.");
            return;
        }

        var memory = MemoryDatabase.GetRecentEntries();
        var inferredEmotion = InferEmotionFromData(memory);
        var profile = emotionProfiles[inferredEmotion];
        var style = inferredEmotion.ToString().ToLower();

        await TextToSpeechEngine.SpeakAsync(message, profile, style);
    }
}