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

    public Dictionary<char, double> Execute(string pathText)
    {
        var text = textToCompare.ReadFile(pathText);

        var textFreq = freqText.Count(text);

        var compare = compareText.CompareEnglishDict(textFreq);

        // Return the textFreq dictionary
        Console.WriteLine("textFreq dictionary");
        foreach (var kvp in textFreq)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        Console.WriteLine("Compare extFreq");
        foreach (var kvp in compare)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        return compare; 
    }
}