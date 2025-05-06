using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Threading.Tasks;

public static class TextToSpeechEngine
{
    private const string subscriptionKey = "YourSubscriptionKey";
    private const string region = "YourRegion";

    public static async Task SpeakAsync(string text, EmotionVoiceProfile profile, string emotionStyle)
    {
        var config = SpeechConfig.FromSubscription(subscriptionKey, region);
        config.SpeechSynthesisVoiceName = "en-US-JennyMultilingualNeural";
        config.SetSpeechSynthesisPitch($"{(profile.Pitch - 1.0f) * 100:+#;-#;0}%");
        config.SetSpeechSynthesisSpeakingRate($"{(profile.Speed - 1.0f) * 100:+#;-#;0}%");
        config.SetSpeechSynthesisVolume($"{(profile.Volume - 1.0f) * 100:+#;-#;0}%");

        using var audioConfig = AudioConfig.FromDefaultSpeakerOutput();
        using var synthesizer = new SpeechSynthesizer(config, audioConfig);

        string ssml = $@"
<speak version='1.0' xmlns='http://www.w3.org/2001/10/synthesis'
       xmlns:mstts='https://www.w3.org/2001/mstts' xml:lang='en-US'>
  <voice name='{config.SpeechSynthesisVoiceName}'>
    <mstts:express-as style='{emotionStyle}'>
      {System.Security.SecurityElement.Escape(text)}
    </mstts:express-as>
  </voice>
</speak>";

        var result = await synthesizer.SpeakSsmlAsync(ssml);
        if (result.Reason != ResultReason.SynthesizingAudioCompleted)
        {
            Console.WriteLine($"Speech synthesis failed: {result.Reason}");
        }
    }
}