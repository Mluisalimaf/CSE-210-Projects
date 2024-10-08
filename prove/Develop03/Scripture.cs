using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();

        /*_words = new List<Word>();

        //string[] wordsArray = text.Split(' ');

        foreach (string wordText in wordsArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }  */
    }

    public Reference Reference
    {
        get {return _reference;}
    }

    public string Text
    {
        get 
        {
            return string.Join(" ", _words.Where(word => !word.IsHidden()).Select(word => word.GetDisplayText()));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide > _words.Count)
        {
            numberToHide = _words.Count;
        }

        Random random = new Random();
        HashSet<int> indiceToHide = new HashSet<int>();

        while(indiceToHide.Count < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (indiceToHide.Add(index))
            {
                _words[index].Hide();
            }
        }

    }

    public string GetDisplayText()
    {
        return $"{Reference.GetDisplayText()}: {Text}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}

