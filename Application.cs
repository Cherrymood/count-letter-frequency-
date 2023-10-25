class Application{

    ReadText textToCompare;
    CountFrequency freqText;
    EnglishAlphabetFreq compareText;

    public Application()
    {
        // Initialize the ReadText object
        textToCompare = new ReadText(); 

        // Initialize the CountFrequency object
        freqText = new CountFrequency(); 

        // Initialize the EnglishAlphabetFreq object
        compareText = new EnglishAlphabetFreq(); 

    }

    public void Execute(string pathText)
    {
        var text = textToCompare.ReadFile(pathText);
        var textFreq = freqText.Count(text);
        var compareText = compareText.CompareEnglishDict(textFreq);
        // Return the textFreq dictionary
        foreach (var kvp in compareText)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}