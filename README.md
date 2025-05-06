ModelVoiceAI is a C# .NET 6.0 console application that empowers a virtual AI persona (referred to as Model) to express human-like emotions using Azure Text-to-Speech (TTS). This project combines voice synthesis, emotional inference from contextual memory, and permission-based control to create emotionally expressive AI speech.

-> Features
✅ Emotion-driven voice modulation (pitch, speed, volume)

✅ Integration with Azure TTS using SSML and express-as emotion styles

✅ Mock memory database for simulating AI "collected data"

✅ Permission system to control emotional expression and data access

✅ Modular architecture (separate classes for TTS, memory, permissions, and logic)

-> Supported Emotions
Model can speak with the following emotional styles, automatically inferred from memory:

Happy
Sad
Angry
Excited
Calm
Neutral

Voice parameters (pitch/speed/volume) and Azure SSML express-as tags are used to shape each emotional voice.

Example Behavior

-> If the memory contains:
"User said they are sad today"
Then Model will respond using a sad voice with lowered pitch and slower rate.

-> Setup Instructions
1. Prerequisites
.NET 6 SDK

Azure Cognitive Services Speech Resource

2. Clone and Configure
bash
Copy
Edit
git clone https://github.com/L0st-Zero-coder/ModelVoiceAI.git
cd ModelVoiceAI

-> Edit TextToSpeechEngine.cs:
private const string subscriptionKey = "YourSubscriptionKey";
private const string region = "YourRegion";
Replace with your actual Azure credentials.

4. Build and Run
dotnet restore
dotnet run

-> Project Structure
ModelVoiceAI/
├── Program.cs                
├── Model.cs               	 
├── Permissions.cs            
├── EmotionVoiceProfile.cs  
├── MemoryDatabase.cs  
├── TextToSpeechEngine.cs   
├── ModelVoiceAI.csproj

-> Technologies Used
C# 10 / .NET 6.0

Azure Cognitive Services Speech SDK

SSML (Speech Synthesis Markup Language)

