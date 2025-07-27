using System;

class Program
{
    static void Main(string[] args)
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
    }
}
