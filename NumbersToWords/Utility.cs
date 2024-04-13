using NumbersToWords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersToWords
{
    public static class Utility
    {
        public static string PrintResult(string result)
        {
            var outputString = String.Empty;

            var reverse = Logic.ConvertToWords(result);

            var len = reverse.Count;

            var descendingOrder = reverse.OrderByDescending(i => i.Position).ToList();

            for (var i = 0; i < len; i++) 
            {
                var itm = descendingOrder[i];
                if (!String.IsNullOrEmpty(itm.ValueInString))
                {
                    outputString += itm.ValueInString + " " + itm.valueTitle + " ";
                }
                else if(!String.IsNullOrEmpty(itm.valueTitle)){
                    outputString += " " + itm.valueTitle + " ";
                }
            }

            return outputString;
        }

        public static string PrintModel(List<NumberStructure> model) {
            var output = String.Empty;
            foreach(var itm in model)
            {
                output = output + itm.ValueInString + " " + itm.valueTitle + " ";   
            }
            return output;
        }
    }
}