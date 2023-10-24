class CountFrequency{

    public Dictionary<char, double> Count(string text)
    {
    var count = new Dictionary<char, int>();
    var alphabet = "abcdefghijklmnopqrstuvwxyz";

    int totalLetters = 0;

    // Convert the text to lowercase
    text = text.ToLower();

    // Count letters in text
    foreach (char letter in text)
    {
        if (alphabet.Contains(letter))
        {
            if (count.ContainsKey(letter))
            {
                count[letter]++;
                totalLetters++;
            }
            else
            {
                count[letter] = 1;
                totalLetters++;
            }
        }
    }

    var frequencies = new Dictionary<char, double>();

    foreach (var keyValue in count)
    {
        frequencies[keyValue.Key] = (double)keyValue.Value / totalLetters;
    }

    return frequencies;
}
}