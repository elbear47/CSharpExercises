bool continueProgram = false;
do
{
    

    Console.WriteLine("Enter a number:");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a second number:");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a third number:");
    int x3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a fourth number:");
    int x4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a fifth number:");
    int x5 = int.Parse(Console.ReadLine());


    int[] nums = { x1, x2, x3, x4, x5 };

    Console.WriteLine("Your Array: ");

    foreach (int i in nums)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Would you like to continue?(y/n)");
    string s = Console.ReadLine();

    if (s =="y")
    {
        continueProgram = true;

    }
    else continueProgram = false;

} while (continueProgram);
