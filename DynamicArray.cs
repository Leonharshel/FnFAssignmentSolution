using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the size of the array
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        // Ask the user for the type of the array
        Console.WriteLine("Enter the type of the array (int, double, string):");
        string type = Console.ReadLine();

        // Create the array based on the user's input
        var arrayType = Type.GetType(type);
        if (arrayType == null)
        {
            Console.WriteLine("Invalid array type!");
            return;
        }

        var array = Array.CreateInstance(arrayType, size);

        // Populate the array with values
        Console.WriteLine($"Enter {size} values for the array:");
        for (int i = 0; i < size; i++)
        {
            var value = Console.ReadLine();
            array.SetValue(Convert.ChangeType(value, arrayType), i);
        }

        // Display the contents of the array
        Console.WriteLine("Array contents:");
        foreach (var value in array)
        {
            Console.WriteLine(value);
        }
    }
}
