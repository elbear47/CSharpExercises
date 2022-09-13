Console.WriteLine("Enter the length: ");

// take user input
bool result;
double length;
result = double.TryParse(Console.ReadLine(), out length);


Console.WriteLine("Enter the width: ");
// take user input
bool result2;
double width;
result2 = double.TryParse(Console.ReadLine(), out width);


static double CalculateArea(double w, double l)
{
    return w * l;
}

static double CalculatePerimeter(double w, double l)
{
    return 2 * (w + l);
}

if (result && result2)
{
    double area = CalculateArea(length, width);
    Console.WriteLine($"Area is {area}");
    double perimeter = CalculatePerimeter(length, width);
    Console.WriteLine($"Perimeter is {perimeter}");
}
