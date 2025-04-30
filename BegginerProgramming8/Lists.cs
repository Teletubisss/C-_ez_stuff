using System.Diagnostics.CodeAnalysis;

List<string> owoce = new List<string>(); // tworzymy pustą listę typu string

owoce.Add("Jabłko");
owoce.Add("Banan");
owoce.Insert(0, "Pomarańcza");
owoce.RemoveAt(1);

Console.WriteLine("Lista owoców:");
foreach (string owoc in owoce)
{
    Console.WriteLine(owoc);
}

List<int> liczby = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine(liczby[0]);


List<int> numbers = new List<int>();
Console.WriteLine("Please put in three nunbers: ");

for (int i = 0; i < 3; i++)
{
    var userInput = int.Parse(Console.ReadLine());
    numbers.Insert(i, userInput);
}

var sum = numbers[0] + numbers[1] + numbers[2];
Console.WriteLine("The sum of your numbers is: " + sum);