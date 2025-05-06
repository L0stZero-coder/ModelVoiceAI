using System.Collections.Generic;

public static class MemoryDatabase
{
    private static readonly List<string> collectedData = new List<string>
    {
        "User said they are sad today",
        "User just passed their exam",
        "User is feeling anxious",
        "User told a joke"
    };

    public static List<string> GetRecentEntries() => collectedData;
}