using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SelectionScreen;

//James Hunt - 17670565

namespace SortingMethods
{
    
    //Contains the class and method for the bubble sort algorithm
    public class BubbleSort
    {
        public static int u;
        public static void SortingLow()
        {
            for (int i = 0; i < Start.Low.Count - 1; i++) 
            for (int z = 0; z < Start.Low.Count - i - 1; z++)               
                    if (Start.Low.ElementAt(z) > Start.Low.ElementAt(z + 1))
                    {
                        float temp = Start.Low.ElementAt(z);
                        Start.Low[z] = Start.Low[z + 1];
                        Start.Low[z + 1] = temp;
               
                    }
            Order.Choice();
        }
    }
    //Contains the class and method for the Selection Sort Algorithm
    public class SelectionSort
    {
        public static void SortingLow()
        {
            int n = Start.Low.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int z = i + 1; z < n; z++)
                    if (Start.Low[z] < Start.Low[min])
                        min = z;
                float temp = Start.Low.ElementAt(min);
                Start.Low[min] = Start.Low[i];
                Start.Low[i] = temp;
            }
            Order.Choice();
        }
    }
    //Contains the class and method for the Binary tree Search Algorithm
    public class BinarySearchTree
    {
        public static void BST()
        {


            int mini = 0;
            int max = Start.Low.Count - 1;
            float search = Start.parseout;
            bool loop = true;
            int guess = 0; ;
            while (loop)
            {
                if (max < mini)
                {
                    loop = false;
                    Console.WriteLine("{0} is not in the array", search);
                    //Testing 1,2,3
                    if (Start.Low[guess] >= Start.Low[guess + 1])
                    {
                        float temp = guess + 1;
                    }
                    Console.WriteLine("The closest numbers to the search were {0} at {1} and {2} at {3}", Start.Low[guess], guess, Start.Low[guess + 1], (guess + 1));
                    Console.WriteLine("\n Press Any button to Return to the choice menu");
                    Console.ReadLine();
                    Order.Choice();
                }
                guess = (mini + max) / 2;
                int q = 0; q++;
                if (Start.Low[guess] == search)
                {
                    Console.WriteLine("{0} can be found at the {1} index", search, guess);
                    Console.WriteLine("\n Press Any button to Return to the choice menu");
                    Console.ReadLine();
                    Order.Choice();
                }
                else if (Start.Low[guess] < search)
                {
                    mini = guess + 1;
                }
                else if (Start.Low[guess] > search)
                {
                    max = guess - 1;
                }
            }
        }
    }
    /// <summary>
    /// Contains the scraped class for quicksort that isn't used in the program.
    /// </summary>
    
    public class Quicksort
    {
        
         public static void quickSort(float []arr, int low, int high)
        {

            {
                if (low < high)
                {

                    //pi is partitioning index, arr[pi] is  
                    //now at right place 
                    //int pi = partition(arr, low, high);

                    // Recursively sort elements before 
                    // partition and after partition 
                    //quickSort(arr, low, pi - 1);
                    //quickSort(arr, pi + 1, high);
                }
            }
            Start.q = false;
            Order.Choice();
        }
         static int partition(float []arr, int low, int high)
        {
            float pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    float temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            float temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
    //Contains the class and method for the Insertion Sort Algorithm
    public class insertionSort
    {

       public static void insertionsorting()
        {
            int n = Start.Low.Count;
            for (int i = 1; i < n; ++i)
            {
                float key = Start.Low[i];
                int j = i - 1;

                while(j >= 0 && Start.Low[j] > key)
                {
                    Start.Low[j + 1] = Start.Low[j];
                    j = j - 1;
                }
                Start.Low[j + 1] = key;

            }
            Order.Choice();
        }
    }
    //Contains the class and method for the Linear Search Algorithm.
    public class Linear
    {
        public static void LinearSearch()
        {
            float search = Start.parseout;
            for (int i = 0; i < Start.Low.Count - 1; i++)
            {
                if (Start.Low[i] == search)
                {
                    Console.WriteLine("That number is located at the {0} index of the list", i);
                    Console.WriteLine("\n Press Any button to Return to the choice menu");
                    Console.ReadLine();
                    Order.Choice();
                }
                if (Start.Low[i] < search && Start.Low[i + 1] > search)
                {
                    Console.WriteLine("The closest numbers to the search were {0} at {1} and {2} at {3}", Start.Low[i], i, Start.Low[i + 1], i + 1);
                    Console.WriteLine("\n Press Any button to Return to the choice menu");
                    Console.ReadLine();
                    Order.Choice();
                }
            }
        }
    }


}

