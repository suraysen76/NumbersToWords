using NumbersToWords.Models;
using System;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter a Number");

            // Getting String (word) from Console

            // Declaration of the array
            string[] inputData;

            // Initialization of array/
            inputData = new string[] { "11","1","10","50","16","4","99","100","411","501","1011","3001","2411","34000"};

            //inputData = new string[] { "34000" };
            foreach (var inputStr in inputData) {

                var reverse = Logic.ConvertToWords(inputStr);
                var outputString = String.Empty;
                var len = reverse.Count;
                for (var i = len - 1; i >= 0; i--)
                {
                    var itm = reverse[i];
                    if (!String.IsNullOrEmpty(itm.ValueInString))
                    {
                        outputString += itm.ValueInString +" " + itm.Multiplier + " ";
                    }

                }
                Console.WriteLine(inputStr + " > " + outputString);
            }
            Console.ReadLine();
        }

       
    }
}
