using NumbersToWords.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {          
            // Getting String (word) from Console

            // Declaration of the array
            string[] inputData;

            // Initialization of array/
            inputData = new string[] { "110000" };
            //inputData = new string[] { "167","1","10","50","16","4","89","100","411","501","1011","3001","2411","34000","11000","111200"};
            Console.WriteLine("Input :" + string.Join(", ", inputData) );

            foreach (var inputStr in inputData)
            {
                var output = Utility.PrintResult(inputStr);
                Console.WriteLine(inputStr+" >>> "+ output);//
            }
            Console.ReadLine();
        }
       

       
    }
}
