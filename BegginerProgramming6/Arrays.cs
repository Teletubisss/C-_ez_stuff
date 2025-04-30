//string [] nazwa_arraya = {"element", "element"}

string[] fruits = { "Apple", "Orange", "Banana", "Kiwi" };

Console.WriteLine(fruits);
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1] + " " + fruits[2]);
fruits[0] = "Strawberry";
Console.WriteLine(fruits[0]);

int arrayLength = fruits.Length;
Console.WriteLine(arrayLength);


var nums = new int[3];                //tworzy nowe ale bez podanych nazw - jedynie robi trzy miejsca
Console.WriteLine("Please enter three numbers to add to an array:");

nums[0] = int.Parse(Console.ReadLine());
nums[1] = int.Parse(Console.ReadLine());
nums[2] = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Our is array now = {" + nums[0] + ", " + nums[1] + ", " + nums[2] + "}");