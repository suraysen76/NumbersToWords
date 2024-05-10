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
            string[] inputData;

            inputData = new string[] {  "10","3010","15","50","100","104","115","156","399","1000","1009","1015","1100","1301","1414","10000","11000", "11010", "11014","24110"};
            Console.WriteLine("Input :" + string.Join(", ", inputData) );

            foreach (var inputStr in inputData)
            {
                string output = Utility.PrintResult(inputStr).Trim();
                Console.WriteLine(inputStr+" >>> "+ output);//
            }
            Console.ReadLine();
        }    
    }
}
