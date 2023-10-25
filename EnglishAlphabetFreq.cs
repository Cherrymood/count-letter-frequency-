class EnglishAlphabetFreq
{
    Dictionary<char, double> conciseOxfordDictionary;

    public Dictionary<char, double> CompareEnglishDict(Dictionary<char, double> dict)
    {
        conciseOxfordDictionary = new Dictionary<char, double>()
        {
            {'a', 0.43}, {'e', 0.11}, {'r', 0.75}, {'i', 0.07}, {'o', 0.0716},
            {'t', 0.69}, {'n', 0.06}, {'s', 0.57}, {'l', 0.05}, {'c', 0.0453},
            {'u', 0.36}, {'d', 0.03}, {'p', 0.31}, {'m', 0.03}, {'h', 0.0301},
            {'g', 0.24}, {'b', 0.02}, {'f', 0.01}, {'y', 0.01}, {'w', 0.0128},
            {'k', 0.11}, {'v', 0.01}, {'x', 0.029}, {'z', 0.0029}, {'j', 0.0019}, {'q', 0.0019}
        };

        var answer = new Dictionary<char, double>();

        // Count letters in text
        foreach (var kvp in dict)
        {
            answer[kvp.Key] = conciseOxfordDictionary[kvp.Key] - dict[kvp.Key];
        }

        return answer;
    }
}
