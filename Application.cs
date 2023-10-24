class Application{

    ReadText sherlockText;
    CountFrequency freqText;

    public Application()
    {
        // Initialize the ReadText object
        sherlockText = new ReadText(); 

        // Initialize the CountFrequency object
        freqText = new CountFrequency(); 
    }

    public Dictionary<char, double> Execute(string pathText)
    {
        var sherlock = sherlockText.ReadFile(pathText);
        var textFreq = freqText.Count(sherlock);
        // Return the textFreq dictionary
        foreach (var kvp in textFreq)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        return textFreq; 
    }
}