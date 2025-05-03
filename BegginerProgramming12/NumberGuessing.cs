namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)  //static - nie trzeba tworzyc obiektu, aby dzialalo, string[] args - tablica argumentów przekazanych z wiersza poleceń
        {
            var r = new Random();
            var numberWin = r.Next(0, 10);
            bool win = false;

            Console.WriteLine("Guess a number between 1 and 10!");

            do
            {
                var numberUser = int.Parse(Console.ReadLine());

                if (numberUser == numberWin)
                {
                    Console.WriteLine("You won! Correct number was " + numberWin);
                    win = true;
                }
                else
                {
                    Console.WriteLine("Wrong! Try again!");
                }
            } while (win == false);
        }
    }
}
