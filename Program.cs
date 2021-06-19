using System;

namespace _10IntOfMultiplicationTable
{
    class Program
    {
        static void Main(string[] args) //  Declare and initialize array of 10 integers then print the multiplication table of each element in the array.
        {
            //declaring 
            int[] balance = new int[10];//number of the length

            //initializing
            int[] marks = new int[10] { 1, 9, 8, 7, 32, 41, 56, 76, 24, 87 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First Loop is " + marks[i]); //first loop
                


                for (int j = 1; j < 9; j++) //second loop

                {
                    Console.WriteLine("First Loop" + marks[i] + "*" + "Second Loop" + j + "=" + (marks[i] * j).ToString());
                }
                

            }
           
            


        }




    }

}


