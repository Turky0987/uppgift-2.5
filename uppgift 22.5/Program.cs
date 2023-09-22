using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        Console.Write("Enter a calculation: ");
        string input = Console.ReadLine();

        string[] parts = input.Split('*');

        if (parts.Length == 2 && double.TryParse(parts[0], out double tal1) && double.TryParse(parts[1], out double tal2))
        {
            double resultat = tal1 * tal2;//
        }
    }
}
