using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a valid date (yyyy-mm-dd):");
        string input = Console.ReadLine();
        bool isValid = ValidateDate(input);

        if (isValid)
        {
            Console.WriteLine("Date is valid!");
        }
        else
        {
            Console.WriteLine("Date is invalid!");
        }
    }

    static bool ValidateDate(string input)
    {
        // Split the input into year, month, and day components
        string[] components = input.Split('-');
        if (components.Length != 3)
        {
            return false;
        }

        // Parse the year, month, and day values
        int year, month, day;
        if (!int.TryParse(components[0], out year) || !int.TryParse(components[1], out month) || !int.TryParse(components[2], out day))
        {
            return false;
        }

        // Check if the year is between 2000 and 2050
        if (year < 2000 || year > 2050)
        {
            return false;
        }

        // Check if the month is between 1 and 12
        if (month < 1 || month > 12)
        {
            return false;
        }

        // Check if the day is valid for the given month and year
        int daysInMonth = DateTime.DaysInMonth(year, month);
        if (day < 1 || day > daysInMonth)
        {
            return false;
        }

        // Date is valid
        return true;
    }
}
