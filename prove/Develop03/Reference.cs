//Keeps track of the book, chapter, and verse information.
//The Reference class is pretty simple as far as behaviors go. It should have the ability to get the display text of the reference, which is just a string combining the book, chapter, and verse (or verses). You could consider having getters and setters for each of the data elements that this class stores, but it may be even better to use a constructor to set them. The constructor will be discussed in more detail below.
class Reference 
{
    string book; 

    int chapter, verse, endVerse;

    public Reference(string _book, int _chapter, int _verse)
    {
        book = _book;
        chapter = _chapter;
        verse = _verse;
        endVerse = 0;
    }

    public Reference(string _book, int _chapter, int _verseStart, int _verseEnd)
    {
        book = _book; 
        chapter = _chapter;
        verse = _verseStart;
        endVerse = _verseEnd;
    }

    public string GetDisplayText()
    {
        string referenceDisplay = "";

        if (endVerse != 0)
        {
            referenceDisplay = $"{book} {chapter}:{verse}-{endVerse}";
        }

        return referenceDisplay;
    }


}