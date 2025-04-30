
Console.WriteLine("Hello! Please enter the total array values: ");
var numVal = int.Parse(Console.ReadLine());

var arrayOfInts = new int[numVal];

var x = 0;

Console.WriteLine("Now please enter the " + numVal + " values");

while (x < arrayOfInts.Length)
{
    arrayOfInts[x] = int.Parse(Console.ReadLine());
    x++;
}

Console.WriteLine("The final value is: " + arrayOfInts[arrayOfInts.Length - 1]);

Console.WriteLine("And here is the whole array!");

for (int i = 0; i < arrayOfInts.Length; i++)
{
    Console.WriteLine(arrayOfInts[i]);
}


//foreach (string owoc in owoce)
//{
//    Console.WriteLine(owoc);
//}    <-- inny sposób

