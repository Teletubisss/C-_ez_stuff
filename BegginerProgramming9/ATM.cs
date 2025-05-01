
Dictionary<string, int> ATM = new Dictionary<string, int>();
ATM.Add("Adam", 500);
ATM.Add("Josie", 2500);
ATM.Add("Brad", 1250);

Console.WriteLine("Type in your Name (Adam, Josie or Brad): ");

var user = Console.ReadLine();

if (ATM.ContainsKey(user))
{
    Console.WriteLine();
    Console.WriteLine("Welcome " + user + "!");
    Console.WriteLine("Your current balance is: " + ATM[user]);
    Console.WriteLine();
    Console.WriteLine("What would you like to do today? Deposit or withdraw cash? ");

    var action = Console.ReadLine();

    if (action == "deposit" || action == "Deposit")
    {
        Console.WriteLine();
        Console.WriteLine("Of couse. How much money would you like to deposit?");

        var depositMoney = int.Parse(Console.ReadLine());
        ATM[user] += depositMoney;

        Console.WriteLine();
        Console.WriteLine("Transaction succesfull! Your current balance is: " + ATM[user]);

    }
    else if (action == "withdraw" || action == "Withdraw")
    {
        Console.WriteLine("Of couse. How much money would you like to withdraw?");

        var withdrawMoney = int.Parse(Console.ReadLine());

        if (withdrawMoney <= ATM[user])
        {
            ATM[user] -= withdrawMoney;
            Console.WriteLine();
            Console.WriteLine("Transaction succesfull! Your current balance is: " + ATM[user]);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("You don't have enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid Action");
    }
}
else
{
    Console.WriteLine("Invalid user");
}
