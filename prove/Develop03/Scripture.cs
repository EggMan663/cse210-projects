using System;

public class Scripture{

    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(string scripture) // single verse
    {
        _words = new List<Word>();
        foreach (string word in scripture.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public Scripture(string[] scriptures) // multiple verses 
    {
        _words = new List<Word>();
        foreach (string scripture in scriptures)
        {
            foreach (string word in scripture.Split(' '))
            {
                _words.Add(new Word(word));
            }
        }
    }

    public void hideRandom()
    {
        for (int i = 0; i < 3; i++)
        {
            int index = _random.Next(_words.Count);
            if (_words[index].IsHidden())
            {
                i--;
                Console.WriteLine(i);
                if (i < -2)
                {
                    break;
                }
            }
            else
            {
                _words[index].hide();
            }
            
        }
    }

    public void displayScripture()
    {
        foreach (Word word in _words)
        {
            Console.Write($"{word.show()} ");
        }
        Console.WriteLine();
    }
}