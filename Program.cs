using System;

public delegate double Conversion(double from);////In this C# Program we are reading feet using ‘feet’ variable. Delegates are used to pass methods as arguments to other methods. After passing the arguments the values are converted to the required form. Print the inches of the feet using delegate.////
class DelegateDemo
{
    public static double FeetToInches(double feet)
    {
        return feet * 12;
    }

    static void Main()
    {

        Conversion doConversion = new Conversion(FeetToInches);
        Console.Write("Enter Feet:  ");
        double feet = Double.Parse(Console.ReadLine());
        double inches = doConversion(feet);
        Console.WriteLine("\n{0} Feet = {1} Inches.\n", feet, inches);
        Console.ReadLine();
    }
}
////Output:
///Enter Feet:  50
////50 Feet = 600 Inches.