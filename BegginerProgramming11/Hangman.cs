
public class Hangman
{
    void getValidWords()
    {
        var wordsObj = new Words();                   //nowa zmienna z klasa Words
        string[] words = wordsObj.ListWords();            //nowa talbica words z lista words

        var rand = new Random();                         //new Random() - obiekt ktory randomuje, rand - zmienna 
        var randomWord = words[rand.Next(words.Length)];  //rand.Next losuje z zakresu 0 do length - 1

        Console.WriteLine("Wylosowane słowo: " + randomWord);


    }
}


