
public class Hangman
{
    public string GetValidWords()
    {

        return WordsUtils.RandomWord();
    }

    public void Run()
    {
        var hangman = new Hangman();
        string randomWord = hangman.GetValidWords();

        int currentLives = 7;
        bool win = false;

        List<char> guessedLetters = new List<char>();

        while (currentLives > 0)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Your guesses so far: ");
            foreach (char x in guessedLetters)
            {
                Console.Write(x);
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (char x in randomWord)
            {
                if (guessedLetters.Contains(x))
                {
                    Console.Write(x);
                }
                else
                {
                    Console.Write("_");
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nLives remaining: " + currentLives);
            Console.WriteLine("\nPlease enter a guess!");
            Console.WriteLine();

            char guess = char.Parse(Console.ReadLine());

            if (randomWord.Contains(guess) && !guessedLetters.Contains(guess))
            {
                Console.WriteLine("\nCorrect!");
            }
            else
            {
                Console.WriteLine("\nIncorrect!");
                currentLives--;
            }

            guessedLetters.Add(guess);

            bool wordComplete = true;                   //kiedy wsystkie beda zgadniete, nigdy sie nie zmieni
            foreach(char x in randomWord)
            {
                if(!guessedLetters.Contains(x))
                {
                    wordComplete = false;
                }
            }

            win = wordComplete;  //bedzie albo true albo false w zaleznosci od tego wyzej
        }

        if (win == true)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }



}



