//Keeps track of a single word and whether it is shown or hidden.
//The key behaviors for the Word class are to hide and show a word and to check if a word is hidden or not. In addition, a Word should have a behavior to get the display text of that word, which would be either the word itself (for example, "prayer") or, if the word were hidden, this behavior would return underscores (for example, "______").
class Word
{
    string text;

    bool isHidden;

    public Word(string _text)
    {
        text = _text;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public bool GetIsHidden()
    {   
        return isHidden;
    }

    public string GetDisplayText()
    {
        return text;
    }
     public void SetIsHidden(bool value)
    {
        isHidden = value;
    }

}