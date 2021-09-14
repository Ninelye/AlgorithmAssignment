using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
//James Hunt - 17670565

namespace SelectionScreen
{
    public class Start
    {
        //Variable Declarations
        public static List<float> Low = new List<float>();
        public static float parseout;
        public static int count = Low.Count();
        public static void DataStart()
        {
            Start.Low.Clear();
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Choose which array to analyse");
                Console.WriteLine("\n0. Exit");
                Console.WriteLine("1. Low 256 ");
                Console.WriteLine("2. Low 2048");
                Console.WriteLine("3. Low 4096");
                Console.WriteLine("4. Mean 256");
                Console.WriteLine("5. Mean 2048");
                Console.WriteLine("6. Mean 4096");
                Console.WriteLine("7. High 256");
                Console.WriteLine("8. High 2048");
                Console.WriteLine("9. High 4096");
                Console.WriteLine("A. Low & High 256");
                Console.WriteLine("B. Low & High 2048");
                Console.WriteLine("C. Low & High 4096");
               

                //using a switch statement the user can navigate and select a data item
                char select = (char)Console.ReadKey(true).KeyChar;
                Console.Clear();
                switch (select)
                {
                    case '1':
                        foreach (string line in File.ReadLines("Data/Low_256.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);



                        }
                        //Contains code for quicksort
                     //   arr = Low.ToArray();//{ 1.2f, 1.3f, 1.25f, 1.2525f }; 
                      //  for (int i = 0; i < Low.Count; i++)
                       // {
                       // Low[i] = arr[i];
                       // }
                       // int n = arr.Length;
                        //SortingMethods.Quicksort.quickSort(arr, 0, n - 1);
                        
                        SortingMethods.SelectionSort.SortingLow();
                        break;
                    case '2':
                        foreach (string line in File.ReadLines("Data/Low_2048.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.insertionSort.insertionsorting();
                        break;
                    case '3':
                        foreach (string line in File.ReadLines("Data/Low_4096.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.BubbleSort.SortingLow();
                        break;
                    case '4':
                        foreach (string line in File.ReadLines("Data/Mean_256.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.BubbleSort.SortingLow();
                        break;
                    case '5':
                        foreach (string line in File.ReadLines("Data/Mean_2048.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.insertionSort.insertionsorting();
                        break;
                    case '6':
                        foreach (string line in File.ReadLines("Data/Mean_4096.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.SelectionSort.SortingLow();
                        break;
                    case '7':
                        foreach (string line in File.ReadLines("Data/High_256.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.SelectionSort.SortingLow();
                       
                        break;
                    case '8':
                        foreach (string line in File.ReadLines("Data/High_2048.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.BubbleSort.SortingLow();
                        break;
                    case '9':
                        foreach (string line in File.ReadLines("Data/High_4096.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }

                        SortingMethods.insertionSort.insertionsorting();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    case 'a':
                        foreach(string line in File.ReadLines("Data/High_256.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }
                        foreach (string line in File.ReadLines("Data/Low_256.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }
                        SortingMethods.BubbleSort.SortingLow();
                        break;
                    case 'b':
                        foreach (string line in File.ReadLines("Data/High_2048.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }
                        foreach (string line in File.ReadLines("Data/Low_2048.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }
                        SortingMethods.SelectionSort.SortingLow();
                        break;
                    case 'c':
                        foreach (string line in File.ReadLines("Data/High_4096.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }
                        foreach (string line in File.ReadLines("Data/Low_4096.txt"))
                        {
                            if (line == "")
                                continue;
                            float convert = float.Parse(line);
                            Low.Add(convert);
                        }
                       
                        SortingMethods.insertionSort.insertionsorting();
                        //SortingMethods.Quicksort.Quicksorting(arr, 0, arr.Length -1);
                        break;


                }
            }
            Console.ReadLine();
        }
        public static float[] arr;

        public static bool q = true;
        static void Main(string[] args)
        {
            bool dark = true;
            while (dark)
            {
                
                DataStart();
            }
        }

    }
    public class Order
    {
        //The descend class was used to allow quicksort to print however it still works without quicksort functioning
        public static void Descend()
        {
            if (Start.q == true)
            {
                Console.Clear();
                foreach (var no in Start.Low)
                {
                    int i = 0;
                    i++;
                    Console.WriteLine("{0}\n", no);
                    
                      
                }
                Console.WriteLine("\nPress Any Button to Return to the Main Menu");
                Console.ReadLine();
            }
            if (Start.q == false)
            {
                
                Console.Clear();
                foreach (var no in Start.arr)
                {
                    int i = 0;
                    i++;
                    Console.WriteLine("{0}\n", no);
                    
                }
                Console.WriteLine("\nPress Enter Button to Return to the Main Menu");
                Console.ReadLine();
            }
            
        }
        //Displays data list in ascending order
        public static void Ascend()
        {
            Console.Clear();
            
            for (int i = Start.Low.Count - 1; i >= 0; i--)
                Console.WriteLine(Start.Low.ElementAt(i));

            Console.WriteLine("\nPress Any Button to Return to the Main Menu");
            Console.ReadLine();
        }
        //Shows the tenth item in the list
        public static void TenthItem()
        {
            Console.Clear();
            for (int i = 0; i < Start.Low.Count;i = i + 10)
            {
                Console.WriteLine(Start.Low[i]);
            }
            Console.WriteLine("\nPress Any Button to Return to the Main Menu");
            Console.ReadLine();
        }
        //shows the fifth item in the list.
        public static void FifthItem()
        {
            Console.Clear();
            for (int i = 0; i < Start.Low.Count; i = i + 50)
            {
                Console.WriteLine(Start.Low[i]);
            }
            Console.WriteLine("\nPress Any Button to Return to the Main Menu");
            Console.ReadLine();
        }
        //shows the eight item in the list.
        public static void EighthItem()
        {
            Console.Clear();
            for (int i = 0; i < Start.Low.Count; i = i + 80)
            {
                Console.WriteLine(Start.Low[i]);
            }
            Console.WriteLine("\nPress Any Button to Return to the Main Menu");
            Console.ReadLine();
        }
        //Another menu for organizing the data
        public static void Choice()
        {
            Console.Clear();
            Console.WriteLine("Please Select One");
            Console.WriteLine("\n1. Sort in Ascending Order");
            Console.WriteLine("2. Sort in Descending Order");
            Console.WriteLine("3. Show every 10th Number in the Array");
            Console.WriteLine("4. Show every 50th Number in the Array");
            Console.WriteLine("5. Show every 80th Number in the Array");
            Console.WriteLine("6. Search Array using Binary Search");
            Console.WriteLine("7. Search Array using Linear Search");
            Console.WriteLine("8. Exit Application");
            char select = (char)Console.ReadKey(true).KeyChar;
            switch (select)
            {
                case '1':
                    Ascend();
                    break;
                case '2':
                    Descend();
                    break;
                case '3':
                    TenthItem();
                    break;
                case '4':
                    FifthItem();
                    break;
                case '5':
                    EighthItem();
                    break;
                case '8':
                    Environment.Exit(0);
                    break;
                case '7':
                    bool loopy = true;
                    while (loopy)
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter your search term");
                        String guess = Console.ReadLine();

                        bool success = float.TryParse(guess, out Start.parseout);
                            if (success)
                            {
                            loopy = false;
                            SortingMethods.Linear.LinearSearch();
                            }
                        else
                            Console.WriteLine("That is not an acceptable search term, Please try again");
                    }
                    break;

                case '6':
                    bool loop = true;
                   
                    while (loop)
                    {
                        Console.Clear();
                        Console.WriteLine("Please Enter your Search Term");
                        String guess = Console.ReadLine();

                        bool success = float.TryParse(guess, out Start.parseout);
                        if (success)
                        {
                            loop = false;
                            SortingMethods.BinarySearchTree.BST();
                        }
                        else
                            Console.WriteLine("That is not an acceptable search term, Please try again");
                    }
                    break;
            }

                       
                    }
                 }

        
        }
        
    

