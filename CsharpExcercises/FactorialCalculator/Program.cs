
static int CalculateFactorial(int a)
{
    
    int result = a;

    for (int i = 1; i < a; i++)
    {
        result = result * i;
    }
    return result;

}

Console.WriteLine("Welcome to the Factorial Calculator!");
Console.WriteLine("Enter an integer that’s greater than 0 but less than 10: ");
int num = int.Parse(Console.ReadLine());
int factorial = CalculateFactorial(num);

Console.WriteLine($"The factorial of {num} is {factorial}");