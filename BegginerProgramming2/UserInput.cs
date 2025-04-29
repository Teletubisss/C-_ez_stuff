
Console.WriteLine("Hello! What is your name?");
string name;
name = Console.ReadLine();
Console.WriteLine("Thanks " + name);


string numOne;
Console.WriteLine("What would you like to add to number 5?: ");
numOne = Console.ReadLine();
int yourSum = int.Parse(numOne) + 5;
Console.WriteLine("Your new nuber is: " + yourSum);

string numTwo;
string numThree;
Console.WriteLine("Please give two numbers: ");
numTwo = Console.ReadLine();
numThree = Console.ReadLine();
float multiply = float.Parse(numTwo) * float.Parse(numThree);
Console.WriteLine("The multiplication of your numbers equals to: " + multiply);


