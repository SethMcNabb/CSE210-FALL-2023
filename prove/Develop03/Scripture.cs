//Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
//The key behaviors for the Scripture class are to hide random words and also to get the display text as a string. (The "display text" refers to the text with some words shown normally, and some replaced by underscores.) It would also be nice to have a behavior to check if the scripture is completely hidden so that you know when to end the program.
class Scripture 
{
    Reference reference;

    List<Word> words;

    public Scripture(Reference _reference, string _text)
    {
        reference = _reference; 
        words = new List<Word>();

        List<string> allWords = _text.Split(' ').ToList();
        foreach(string wordString in allWords)
        {
            Word newWord = new Word(wordString);
             words.Add(newWord);
        }
    }

   public void HideRandomWords()
    {
        Random random = new Random();
        
        int numWordsToHide = 2;
        int wordCount = words.Count;

        for (int i = 0; i < numWordsToHide; i++)
        {
            int randomIndex = random.Next(0, wordCount);
            words[randomIndex].SetIsHidden(true);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }

        return ($"{reference.GetDisplayText()} {scriptureText}");
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}