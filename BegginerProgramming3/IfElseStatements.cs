
Console.WriteLine("Hello! Please enter a number: ");
string newNum = Console.ReadLine();
float FloatNum = float.Parse(newNum);

if (FloatNum < 0)
{
    Console.WriteLine("Your number is less than 0");
} else if(FloatNum > 0)
{
    Console.WriteLine("Your number is more than 0");
} else
{
    Console.WriteLine("Your number is equal to 0");
}




Console.WriteLine("Please write down your password: ");
string password = Console.ReadLine();

Console.WriteLine("Please confirm your password: ");
string passwordCon = Console.ReadLine();

if (passwordCon == password)
{
    Console.WriteLine("Your passwords match!");
} else if (password != passwordCon)
{
    Console.WriteLine("Your passwords don't match.");
} else if (passwordCon == null || password == null)
{
    Console.WriteLine("Password is null.");
}


