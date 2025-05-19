# 🗣️ ModelVoiceAI

**ModelVoiceAI** is a C# .NET 6.0 console application designed to bring emotionally expressive voice output to a virtual AI persona named *Model*. By integrating Azure Text-to-Speech (TTS), contextual memory, and a permission system, the application enables dynamic and human-like emotional speech synthesis.

---

## 🎯 Features

- ✅ Emotion-driven voice modulation (pitch, rate, volume)
- ✅ Azure TTS integration with SSML and `express-as` emotion styles
- ✅ Mock memory database simulating contextual data influence
- ✅ Permission-based control of emotional and memory expression
- ✅ Clean, modular architecture with separate logic layers

---

## 😊 Supported Emotions

Model can express the following emotions, inferred automatically from memory context:

- Happy
- Sad
- Angry
- Excited
- Calm
- Neutral

Each emotion uses specific SSML voice tags and custom voice modulation (pitch, speed, volume).

### 🧠 Example Behavior

If memory includes:  
`"User said they are sad today"`  
Then the AI will respond in a **sad** voice, using **lower pitch** and **slower rate**.

---

## ⚙️ Setup Instructions

### 1. Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Azure Cognitive Services Speech Resource](https://learn.microsoft.com/en-us/azure/cognitive-services/speech-service/quickstarts)

### 2. Clone and Configure

```bash
git clone https://github.com/L0st-Zero-coder/ModelVoiceAI.git
cd ModelVoiceAI
```

### 3. Configure Azure Credentials

Open `TextToSpeechEngine.cs` and update:

```csharp
private const string subscriptionKey = "YourSubscriptionKey";
private const string region = "YourRegion";
```

Replace with your actual Azure Speech API key and region.

### 4. Build and Run

```bash
dotnet restore
dotnet run
```

---

## 📁 Project Structure

```
ModelVoiceAI/
├── Program.cs                
├── Model.cs               	 
├── Permissions.cs            
├── EmotionVoiceProfile.cs  
├── MemoryDatabase.cs  
├── TextToSpeechEngine.cs   
├── ModelVoiceAI.csproj
```

---

## 🛠️ Technologies Used

- C# 10 / .NET 6.0  
- Azure Cognitive Services Speech SDK  
- SSML (Speech Synthesis Markup Language)

---

## 📄 License

This project is open for educational and experimental use. License to be defined.

---

## 🙌 Contributions

Feel free to fork the repository and submit pull requests for improvements or new features. Collaboration is welcome!
