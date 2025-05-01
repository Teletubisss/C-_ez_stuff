
public class Hangman
{
    public void GetValidWords()
    {

        var randomWord = WordsUtils.RandomWord();
        Console.WriteLine("Wylosowane słowo: " + randomWord);


    }
}



