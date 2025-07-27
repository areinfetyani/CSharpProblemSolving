using System;

class Program
{
    static async Task Main(string[] args)
    {
        // Problem 1: Second Max
        int[] myArray = { 20, -7, -3 };
        Console.WriteLine("Second Max: " + SecondMaxProblem.SecondMax(myArray));

        // Problem 2: First Non-Repeating Character
        Console.WriteLine("First Non-Repeating Character: " + FirstNonRepeatingCharacterProblem.firstNonrepeatingCharacter("aabbcciddlle"));

        // Problem 3: Missing Number in Array
        int[] myArray2 = { 2, 4, 1, 5, 3, 7 };
        Console.WriteLine("Missing Number: " + MissingArrayProblem.missingArray(myArray2));

        // Problem 4: Insertion Sort
        int[] myArray3 = { 2, 4, 1, 5, 3, 7 };
        Console.WriteLine("Sorted Array: " + string.Join(" ", InsertionSortProblem.insertionSort(myArray3)));

        // Problem 5: Max in Array
        int[] myArray4 = { 20, -7, -3 };
        Console.WriteLine("Max in Array: " + ArrayMaxProblem.ArrayMax(myArray4));

        // Problem 6: Vowel Count
        string str = "technology";
        Console.WriteLine("Vowel Count: " + VowelCountProblem.vowelCount(str));

        //Problem 7: Reverse String
        string str2 = "technology";
        Console.WriteLine("Reversed String: " + ReverseStringProblem.reverseString(str2));

        // Problem 8: Merge Sorted Arrays
        int[] array1 = { 1, 3, 5 };
        int[] array2 = { 2, 4, 6 };
        int[] mergedArray = MergeSortedArrayProblem.MergeSortedArray(array1, array2);
        Console.WriteLine("Merged Sorted Array: " + string.Join(" ", mergedArray));

        // Problem 9: Numeric String Check
        string numericString = "1234567890";
        Console.WriteLine(numericString + " is a Numeric String: " + NumericStringProblem.NumericString(numericString));

        // Problem 10: Multi-threaded Prime Finder
        var primes = await PrimeNumberFinderProblem.MultiThreadedPrimeFinder();
        Console.WriteLine("Total prime numbers found: " + primes.Count);
        Console.WriteLine("Primes Numbers between 1 and 1000000: " + string.Join(", ", primes));

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
