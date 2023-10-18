using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");

        // Get the size of the array from the user
        int size = int.Parse(Console.ReadLine());

        // Create arrays of integer, string, and double based on user input
        int[] intArray = CreateArray<int>(size);
        string[] strArray = CreateArray<string>(size);
        double[] doubleArray = CreateArray<double>(size);

        // Check if the data types match
        if (AreDataTypesSame(intArray, strArray, doubleArray))
        {
            Console.WriteLine("All data types are the same. Printing the values:");
            PrintValues(intArray);
        }
        else
        {
            Console.WriteLine("Data types are not the same. Values are not valid.");
        }
    }

    // Generic method to create an array of a specified data type
    static T[] CreateArray<T>(int size)
    {
        T[] array = new T[size];
        Console.WriteLine($"Enter {typeof(T).Name} values:");

        for (int i = 0; i < size; i++)
        {
            string input = Console.ReadLine();
            T value = (T)Convert.ChangeType(input, typeof(T));
            array[i] = value;
        }

        return array;
    }

    // Method to check if data types of three arrays are the same
    static bool AreDataTypesSame<T1, T2, T3>(T1[] arr1, T2[] arr2, T3[] arr3)
    {
        return typeof(T1) == typeof(T2) && typeof(T2) == typeof(T3);
    }

    // Generic method to print the elements of an array
    static void PrintValues<T>(T[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
