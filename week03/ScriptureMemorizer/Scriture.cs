using System;
using System.ComponentModel;
using System.Xml;


public class Scripture
{
    private Reference _reference;
    private List<Word> _word;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = ConvertTextToWordList(text);
    }

    private List<Word> ConvertTextToWordList(string text)
    {
        string[] wordsArray = text.Split(' ');
        List <Word> wordList = new List<Word>();

        foreach (string word in wordsArray)
        {
            wordList.Add(new Word(word));
        }

        return wordList;
    }

    public void HideRandomWords(int numberToHide) {
        Random random = new Random();
        List<Word> unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();

        if (unhiddenWords.Count != 0)
        {
            for (int i = 0; i < count && unhiddenWords.Count > 0; i++)
            {
                int index = random.Next(unhiddenWords.Count);
                unhiddenWords[index].Hide();
                unhiddenWords.RemoveAt(index);
            }
        }
    }
    public string GetDisplayText()
    {
        string words = "";
        foreach (Word word in _words)
        {
            words += word.GetDisplayText() + " ";
        }
        words = words.Trim();
        string referenceText = _reference.GetDisplayText();
        return referenceText + " " + words;
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}