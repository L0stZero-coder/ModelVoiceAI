public enum Emotion
{
    Neutral,
    Happy,
    Sad,
    Angry,
    Excited,
    Calm
}

public class EmotionVoiceProfile
{
    public float Pitch { get; set; }
    public float Speed { get; set; }
    public float Volume { get; set; }

    public EmotionVoiceProfile(float pitch, float speed, float volume)
    {
        Pitch = pitch;
        Speed = speed;
        Volume = volume;
    }
}