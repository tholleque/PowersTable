// Powers Table 


Console.WriteLine("Welcome to the Powers table!");
Console.WriteLine("\r");
string input = "";
do
{
    Console.WriteLine("\r");
    Console.WriteLine("Please enter an integer:");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("\r");

    if (num > 1290)
    {
        Console.WriteLine("That number is TOO LARGE! Please continue and try again.");
    }
    else if (num <= 0)
    {
        Console.WriteLine("Please enter only positive Integers! Please try again.");
    }
    else
    {
        int sqr = 1;
        int cube = 1;
        Console.WriteLine("{0,4} {1,8} {2,10}", " Number", " Sqaure", "Cube ");
        Console.WriteLine("{0,4} {1,8} {2,10}", "========", "========", "========");
        for (int i = 1; i <= num; i++)
        {
            sqr = i * i;
            cube = i * i * i;
            Console.WriteLine("{0,4} {1,8} {2,12}", i, sqr, cube);
        }
    }
    Console.WriteLine("\r");
    Console.WriteLine("Would you like to continue? y/n");
    input = Console.ReadLine();
    if (input != "y")
    {
        Console.WriteLine("Goodbye!");


    }
} while (input == "y");
