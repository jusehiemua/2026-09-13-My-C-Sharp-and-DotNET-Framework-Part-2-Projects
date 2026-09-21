using System;
using System.Collections.Generic;


namespace Module_1_ConsoleAppArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one - dimensional Array of strings.
            string[] str = new[] { "hello", "jack", "and", "jill", "went", "up", "the", "hill" };
            //display the array of string elements:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display the array of string elements:");
            Console.WriteLine("====================================:");

            Console.WriteLine("Array of strings = {" + str[0] + ", " + str[1] + ", " + str[2] + ", " + str[3] + ", " + str[4] + ", " + str[5] + ", " + str[6] + ", " + str[7] + "}");
            Console.ResetColor();
            Console.WriteLine();

            //Ask the user to select an index of the Array
            //Console.Write("Select an index (in the range [0, 1, ..., " + str.Length + "]) of the Array: ");
            Console.Write("Select an index to display a string in the Array: ");
            int selectedIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (selectedIndex >= 0 && selectedIndex < 8)
            {
                //And then display the string at that index on the screen.
                //Console.Write("The string in the index position " + selectedIndex + " in the string Array is: "+ str[selectedIndex]);
                Console.ResetColor();
                Console.Write("The string in the index position ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(selectedIndex);

                Console.ResetColor();
                Console.Write(" in the string Array is: ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(str[selectedIndex]);
                //Console.Write(output);

                Console.ResetColor();
                Console.WriteLine();
            }
            if (selectedIndex < 0 || selectedIndex >= 8)
            {
                //3.Add in a message that displays when the user selects an index that doesn’t exist.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("The index position " + selectedIndex + " does not exist in the string Array!!!");

                Console.ResetColor();
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine();


            //2. Create a one - dimensional Array of integers.
            int[] intArray = new[] { -29, 99, 18, 63, 4000, 300, -675, 123 };
            //display the array of integer elements:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display the array of integer elements:");
            Console.WriteLine("====================================:");

            Console.WriteLine("Array of integer = {" + intArray[0] + ", " + intArray[1] + ", " + intArray[2] + ", " + intArray[3] + ", " + intArray[4] + ", " + intArray[5] + ", " + intArray[6] + ", " + intArray[7] + "}");
            Console.ResetColor();
            Console.WriteLine();

            //Ask the user to select an index of the Array
            //Console.Write("Select an index (in the range [0, 1, ..., " + str.Length + "]) of the Array: ");
            Console.Write("Select an index to display an integer in the Array: ");
            selectedIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (selectedIndex >= 0 && selectedIndex < 8)
            {
                //And then display the string at that index on the screen.
                //Console.Write("The string in the index position " + selectedIndex + " in the string Array is: "+ str[selectedIndex]);
                Console.ResetColor();
                Console.Write("The string in the index position ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(selectedIndex);

                Console.ResetColor();
                Console.Write(" in the integer Array is: ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(intArray[selectedIndex]);
                //Console.Write(output);

                Console.ResetColor();
                Console.WriteLine();
            }
            if (selectedIndex < 0 || selectedIndex >= 8)
            {
                //3.Add in a message that displays when the user selects an index that doesn’t exist.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("The index position " + selectedIndex + " does not exist in the integer Array!!!");

                Console.ResetColor();
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine();

            //4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.*/
            /*
            //list of integers
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            intList.Remove(10);
            */





            //2. Create a list of strings.
            List<string> strList1 = new List<string>();
            //string[] str = new[] { "hello", "jack", "and", "jill", "went", "up", "the", "hill" };
            strList1.Add("Jesse");
            strList1.Add("Julius");
            strList1.Add("Julie");
            strList1.Add("Jane");
            strList1.Add("Joseph");
            strList1.Add("Jack");
            strList1.Add("Jackie");
            strList1.Add("Jonathan");
            strList1.Add("Johnbull");
            //display the display the list ofstring elements:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display the list of string elements:");
            Console.WriteLine("===================================:");

            Console.WriteLine("List of strings = {" + strList1[0] + ", " + strList1[1] + ", " + strList1[2] + ", " + strList1[3] + ", " + strList1[4] + ", " + strList1[5] + ", " + strList1[6] + ", " + strList1[7] + ", " + strList1[8] + "}");
            Console.ResetColor();
            Console.WriteLine();

            //Ask the user to select an index of the List
            Console.Write("Select an index to display a string in the List: ");
            selectedIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (selectedIndex >= 0 && selectedIndex < 9)
            {
                //And then display the string at that index on the screen.
                //Console.Write("The string in the index position " + selectedIndex + " in the string Array is: "+ str[selectedIndex]);
                Console.ResetColor();
                Console.Write("The string in the index position ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(selectedIndex);

                Console.ResetColor();
                Console.Write(" in the string List is: ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(strList1[selectedIndex]);
                //Console.Write(output);

                Console.ResetColor();
                Console.WriteLine();
            }
            if (selectedIndex < 0 || selectedIndex >= 9)
            {
                //3.Add in a message that displays when the user selects an index that doesn’t exist.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("The index position " + selectedIndex + " does not exist in the string List!!!");

                Console.ResetColor();
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine();




        }
    }
}
