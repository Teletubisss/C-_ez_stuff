int count = 0;

while (count < 10)
{
    Console.WriteLine("Number: " + count);  
    count++;   //count = count + 1
}
Console.WriteLine("Count is complete!");



int number = 0;
Console.WriteLine("Please enter valid numbers below 100:");

while (number < 100)
{
    number = int.Parse(Console.ReadLine());
}

Console.WriteLine("The number you entered was too large, the loop has ended...");


Console.WriteLine("Please put a number to count to ten from: ");
var userInput = Console.ReadLine();
int userNumber = int.Parse(userInput);

do
{
    if (userNumber > 10)
    {
        Console.WriteLine("Your number is too large!");
    } else
    {
        Console.WriteLine("Count: " + userNumber);
        userNumber++;
    }
} while (userNumber <= 10);
