using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Practice_7{
    internal class Program{
        public static void Main(string[] args){
            int CountOfUniqueItems(int[] nums)
            {
                int counter = 0;
                int UniqueItems = 0;
                foreach (int item in nums){
                    if (nums[counter]==nums[counter+1])
                    {
                        UniqueItems++;
                        counter++;
                    }
                }
                return UniqueItems;
                
            }
            System.Console.WriteLine("welcome   to the program...");
            System.Console.WriteLine("Enter Array length: ");
            int ArrayLength = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Array Items: ");
            int[] arr = new int[ArrayLength];
            for (int i = 0; i < arr.Length; i++)
            {
                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Please enter a number :");
                    i--; // Allow the user to re-enter the value.
                }
                else if (int.TryParse(userInput, out int parsedValue))
                {
                    arr[i] = parsedValue;
                }
                else
                {
                    Console.WriteLine($"Invalid input: '{userInput}' is not a valid integer. Please enter a valid integer.");
                    i--; 
                    // Allow the user to re-enter the value.
                }
            }
            System.Console.WriteLine("Count of unique itmes :");
            System.Console.WriteLine(CountOfUniqueItems(arr));
        }
    }
}