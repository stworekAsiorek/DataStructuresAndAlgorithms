using System;
using System.Runtime.CompilerServices;
using DataStructuresAndAlgorithms.Practice;
using DataStructuresAndAlgorithms.Practice.PhoneBook;
using DataStructuresAndAlgorithms.Practice.CtCI;
using DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs;

namespace DataStructuresAndAlgorithms { 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine($"Sum interative of 4: {Recursion.SumIterative(4)}");
            //Console.WriteLine($"Sum recursive of 4: {Recursion.SumRecursive(4)}");
            //Console.WriteLine($"Factorial recursive of 4: {Recursion.FactorialRecursive(4)}");
            //Console.WriteLine($"Factorial recursive of 4: {Recursion.Fibbonacci(4)}");

            //int[] A = { 15, 21, 47, 84, 96 };
            //int n = 5;
            //int key = 84;
            //Console.WriteLine($"Binary Search iterative: {Search.BinarySearchIterative(A, n, key)}");
            //Console.WriteLine($"Binary Search recursive: {Search.BinarySearchRecursive(A, 0, n-1, key)}");

            int[] A = { 96, 15, 17, 21, 17, 84 };
            Console.WriteLine($"SELECTION SORT");
            Console.WriteLine($"Unsorted array: {string.Join(" ", A)}");
            Sorting.SelectionSort(A);
            Console.WriteLine($"Sorted array: {string.Join(" ", A)}");

            int [] B = { 96, 15, 17, 21, 17, 84 };
            Console.WriteLine($"INSERTION SORT");
            Console.WriteLine($"Unsorted array: {string.Join(" ", B)}");
            Sorting.InsertionSort(B);
            Console.WriteLine($"Sorted array: {string.Join(" ", B)}");

            int[] C = { 96, 15, 17, 21, 17, 84 };
            Console.WriteLine($"QUICK SORT");
            Console.WriteLine($"Unsorted array: {string.Join(" ", C)}");
            Sorting.QuickSort(C);
            Console.WriteLine($"Sorted array: {string.Join(" ", C)}");

            int[] D = { 96, 15, 17, 21, 17, 84 };
            Console.WriteLine($"MERGE SORT");
            Console.WriteLine($"Unsorted array: {string.Join(" ", D)}");
            Sorting.QuickSort(D);
            Console.WriteLine($"Sorted array: {string.Join(" ", D)}");

            //A a = new A();
            //A b = new B();

            //a.Print();
            //b.Print();

            //var helper = new LastTenHelper();
            //helper.Add("Ala", 3);
            //helper.Add("Ma", 4);
            //helper.Add("Kota", 5);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //helper.Add("Ala", 4);
            //var lastTenOfAla = helper.GetLastTenPrices("Ala");

            //Console.WriteLine($"LastTenPrices for Ala: {string.Join(" ", lastTenOfAla)}");

            //var phoneEntryValidator = new PhoneEntryValidator();
            //var phoneBook = new PhoneBook(phoneEntryValidator);

            //var phoneEntry = new PhoneEntry { FirstName = "Joanna", LastName = "Szczerba", PhoneNumber = "698641500" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { FirstName = "Alicja", LastName = "Szczerba", PhoneNumber = "657893421" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { FirstName = "Janina", LastName = "Szczudlik", PhoneNumber = "987654321" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { FirstName = "Joanna", LastName = "Szczerbak", PhoneNumber = "988765432" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { FirstName = "Jagoda", LastName = "Adamik", PhoneNumber = "987765432" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { FirstName = "Jagoda", LastName = "Adamik", PhoneNumber = "987765432" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { FirstName = "Przemyslaw", LastName = "Adamski", PhoneNumber = "987655432" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { FirstName = "Przemyslaw*", LastName = "Adamski", PhoneNumber = "987655432" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //phoneEntry = new PhoneEntry { LastName = "Adamski", PhoneNumber = "987655432" };
            //phoneBook.AddPhoneEntry(phoneEntry);

            //var numbersForSzczer = phoneBook.FindPeopleWithPrefix("Szczer");

            //Console.WriteLine($"Numbers with prefix \"Szczer\": {string.Join(" ", numbersForSzczer)}");

            //var numbersForSzcz = phoneBook.FindPeopleWithPrefix("Szcz");

            //Console.WriteLine($"Numbers with prefix \"Szcz\": {string.Join(" ", numbersForSzcz)}");

            //var numbersForAda = phoneBook.FindPeopleWithPrefix("Ada");

            //Console.WriteLine($"Numbers with prefix \"Ada\": {string.Join(" ", numbersForAda)}");

            //var numbersForBad = phoneBook.FindPeopleWithPrefix("Bad");

            //Console.WriteLine($"Numbers with prefix \"Bad\": {string.Join(" ", numbersForBad)}");

            //var numbersForSzczerba = phoneBook.FindPeopleWithPrefix("Szczerba");

            //Console.WriteLine($"Numbers with prefix \"Szczerba\": {string.Join(" ", numbersForSzczerba)}");

            //ArraysAndStrings.TestURLify();
            //ArraysAndStrings.TestIsPalindromePermutation();
            //ArraysAndStrings.TestOneAway();

            //ArraysAndStrings.TestStringCompression();

            //SquareMatrix.TestRotation();

            //Matrix.TestZeroMatrix();

            //RecursionAndDynamicProgramming.TestTripleStep(5);

            //LinkedLists.TestIntersection();

            //var solution = new Solution();
            //var result = solution.NumDecodings("226");
            //Console.WriteLine(result);

            //var minimalTree = new MinimalTree();
            //minimalTree.TestCreateMinimalTree();

            //BSTSequence.Test();
        }
    }
}