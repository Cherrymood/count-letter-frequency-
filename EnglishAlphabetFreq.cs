class EnglishAlphabetFreq
{
    Dictionary<char, double> conciseOxfordDictionary;

    public EnglishAlphabetFreq()
    {
        conciseOxfordDictionary = new Dictionary<char, double>()
        {
            {'a', 43.31}, {'e', 11.16}, {'r', 7.58}, {'i', 7.54}, {'o', 7.16},
            {'t', 6.95}, {'n', 6.65}, {'s', 5.73}, {'l', 5.47}, {'c', 4.53},
            {'u', 3.63}, {'d', 3.38}, {'p', 3.16}, {'m', 3.01}, {'h', 3.01},
            {'g', 2.47}, {'b', 2.07}, {'f', 1.18}, {'y', 1.77}, {'w', 1.28},
            {'k', 1.10}, {'v', 1.00}, {'x', 0.29}, {'z', 0.29}, {'j', 0.19}, {'q', 0.19}
        };
    }
}
