public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private string _text;

    public Scripture() {
        _reference = new Reference();
        _text = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";
        _words = CreateWordList();
    }

    public Scripture(String text, Reference reference) {
        _reference = reference;
        _text = text;
        _words = CreateWordList();
    }

    public string GetScriptureText()
    {
                
        return _text;
    }

    private List<Word> CreateWordList()
    {
        List<String> words = _text.Split(" ").ToList();
        List<Word> wordList = new List<Word>();
        words.ForEach(word => wordList.Add(new Word(word)));
        return wordList;
    }

    public void HideRandomWords()
    {
        List<int> randomNumbers = new List<int>();
        int numberToHide = 3;
        while (randomNumbers.Count != numberToHide)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, _words.Count);
            if (!randomNumbers.Contains(randomNumber))
            {
                randomNumbers.Add(randomNumber);
            }
        }

        randomNumbers.ForEach(randomNumber => {
            _words[randomNumber].SetHidden(true);
        });

    }

    public void DisplayScripture() {
        string displayScripture = _reference.GetReference() + " ";
        _words.ForEach(word => {
            displayScripture += word.GetDisplayText() + " ";
        });
        Console.WriteLine(displayScripture);
    }

    public List<Word> GetWords() {
        return _words;
    }

    public bool isAllHidden() {
        bool isAllHidden = true;
        _words.ForEach(word => {
            if(!word.GetHidden()) { 
                isAllHidden = false;
            }
        });
        return isAllHidden;
    }
}