/*
    challenge
Build Specifications:
1 Point: Use if/else statements to take different actions depending on user input.  
Given an integer entered by a user, perform the following conditional actions:
1 Point: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
1 Point: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
1 Point: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
1 Point: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
1 Point: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
 
*/



Console.WriteLine("Welcome to number analyzer!\nEnter a number between 1-100");
int num = int.Parse(Console.ReadLine());
// function for determining if number is odd/even

static bool IsEven(int x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    return false;
}

//odd and less than 60
if (!IsEven(num) && num < 60)
{

    Console.WriteLine("Odd and less than 60.");
}
//even and in the inclusive range of 2 to 24
else if (IsEven(num) && (num >= 2 && num <=24))
{
    Console.WriteLine("Even and less than 25.");
}
//even and in the inclusive range of 26 to 60
else if (IsEven(num) && (num >= 26 && num <= 60))
{
    Console.WriteLine("Even and between 26 and 60 inclusive.");
}
//even and greater than 60
else if (IsEven(num) && num > 60)
{
    Console.WriteLine("Even and greater than 60.");
}

//odd and greater than 60
else if (!IsEven(num) && num > 60)
{
    Console.WriteLine("Odd and greater than 60.");
}
