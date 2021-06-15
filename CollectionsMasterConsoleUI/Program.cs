using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] array = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(array);

            //Print the first number of the array
            Console.WriteLine(array[0]);
            //Print the last number of the array            
            Console.WriteLine(array[array.Length - 1]);
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            Array.Reverse(array);



            Console.WriteLine("All Numbers Reversed:");

            NumberPrinter(array);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Sort(array);
            Array.Reverse(array);
            NumberPrinter(array);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(array);
            NumberPrinter(array);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> mylist = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(mylist.Count);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(mylist);

            //Print the new capacity
            Console.Write("Capacity of the list: ");
            Console.WriteLine(mylist.Count);


            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            try
            {
                int number = int.Parse(Console.ReadLine());
                NumberChecker(mylist, number);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hey hey hey, that isn't a number this isn't how this works. We're skipping this part >:(");
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(mylist);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("No Odds!!");
            OddKiller(mylist);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted numbers!!");
            mylist.Sort();
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] newArray = mylist.ToArray();

            //Clear the list
            mylist.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                    numbers[i] = 0;
                Console.WriteLine(numbers[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = 0; i < numberList.Count; i++)
            {
                if(numberList[i] % 2 == 0)
                {
                    Console.WriteLine(numberList[i]);
                    continue;
                }
                else
                {
                    int q = numberList[i];
                    numberList.Remove(i);
                }
            }
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Yep! We have that number on our list! Nice");
            } else
            {
                Console.WriteLine("Nope, that's not here");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(1, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i > -1; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
