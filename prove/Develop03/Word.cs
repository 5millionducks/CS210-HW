public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    public int Length { get; internal set; }

    public string GetDisplayText()
    {
        string displayText = "";
        if (_isHidden) {
            for (int i = 0; i < _text.Length; i++) {
                displayText += "_";
            }
        } else {
            displayText = _text;
        }
        return displayText;
    }

    public bool GetHidden() {
        return _isHidden;
    }

    public void SetHidden(bool hidden) {
        _isHidden = hidden;
    }
}