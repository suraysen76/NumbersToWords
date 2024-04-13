using NumbersToWords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersToWords
{
    public static class Logic
    {
       
        public static List<NumberStructure> ConvertToWords(string input)
        {
            var model = PopulateModel(input);
            
            
            model = ConstructNumberWord(model);
            model = ConstructValueTitleWord(model);

            model = ModifyTensWord(model,2);

            model = ModifyTeensWord(model,2,1);            model = ModifyTensWord(model, 5);
            model = ModifyTeensWord(model, 5, 4);
            return model;
        }

        private static List<NumberStructure> ConstructNumberWord(List<NumberStructure> model)
        {
            foreach (var col in model)
            {
                var val = col.Value;
                switch (val)
                {
                    case 1:
                        col.ValueInString = "one";
                        break;
                    case 2:
                        col.ValueInString = "two";
                        break;
                    case 3:
                        col.ValueInString = "three";
                        break;
                    case 4:
                        col.ValueInString = "four ";
                        break;
                    case 5:
                        col.ValueInString = "five ";
                        break;
                    case 6:
                        col.ValueInString = "six ";
                        break;
                    case 7:
                        col.ValueInString = "seven ";
                        break;
                    case 8:
                        col.ValueInString = "eight ";
                        break;
                    case 9:
                        col.ValueInString = "nine ";
                        break;
                    case 10:
                        col.ValueInString = "ten ";
                        break;
                }


            }
            return model;

        }
        private static List<NumberStructure> ConstructValueTitleWord(List<NumberStructure> model)
        {
            
            foreach (var col in model)
            {
                var pos = col.Position;
                switch (pos)
                {
                    
                    case 3:
                        
                        if (col.Value != 0)
                        {
                            col.valueTitle = "hundred";
                        }
                        else { col.valueTitle = ""; }
                                    
                        break;
                    case 4:
                        col.valueTitle = "thousand";
                        break;
                    //case 5:
                    //    col.Multiplier = "tens";
                    //    break;
                    case 6:
                        if (col.Value != 0)
                        {
                            col.valueTitle = "hundred";
                        }
                        else { col.valueTitle = ""; }
                        break;
                    case 7:
                        col.valueTitle = "million";
                        break;
                    default:
                        col.valueTitle = "";
                        break;

                }


            }
            return model;

        }
            
        private static List<NumberStructure> PopulateModel(string input)
        {
            var returnList = new List<NumberStructure>();
            

            char[] stringArray = input.ToCharArray();
            int len = stringArray.Length;
           
            int position = len;
            foreach (char tempChar in stringArray)
            {
                var value = Convert.ToInt32("" + tempChar);
                var model = new NumberStructure() { Position = position, Value = value };
                position--;
                returnList.Add(model);
            }
            

            return returnList;

        }
        private static List<NumberStructure> ModifyTensWord(List<NumberStructure> model, int tensPos) {

            foreach (var col in model)
            {
                if (col.Position == tensPos)
                {
                    var val = col.Value;
                    switch (val)
                    {
                        case 2:
                            col.ValueInString = "twenty";
                            break;
                        case 3:
                            col.ValueInString = "thirty";
                            break;
                        case 4:
                            col.ValueInString = "forty";
                            break;
                        case 5:
                            col.ValueInString = "fifty";
                            break;
                        case 6:
                            col.ValueInString = "sixty";
                            break;
                        case 7:
                            col.ValueInString = "seventy";
                            break;
                        case 8:
                            col.ValueInString = "eighty";
                            break;
                        case 9:
                            col.ValueInString = "ninety";
                            break;
                        case 1:
                            col.ValueInString = "ten";
                            break;
                        default:
                            col.valueTitle = "";
                            break;

                    }
                }
            }
            return model;

        }

        private static List<NumberStructure> ModifyTeensWord(List<NumberStructure> model, int tensPos, int onesPos)
        {

            var filteredModel = model.Where(x => x.Value == 1 && x.Position == tensPos).ToList();
            if (filteredModel.Count ==1)
            {
                var word = String.Empty;
                var onesVal = model.Where(x => x.Position == onesPos).ToList()[0].Value;
                switch (onesVal)
                {
                    case 0:
                        word = "ten";
                        break;
                    case 1:
                        word = "eleven";
                        break;
                    case 2:
                        word = "twelve";
                        break;
                    case 3:
                        word = "thirteen";
                        break;
                    case 4:
                        word = "fourteen";
                        break;
                    case 5:
                        word = "fifteen";
                        break;
                    case 6:
                        word = "sixteen";
                        break;
                    case 7:
                        word = "seventeen";
                        break;
                    case 8:
                        word = "eightteen";
                        break;
                    case 9:
                        word = "nineteen";
                        break;
                }
                var temp = word;
                model.Where(x=>x.Position== tensPos).First().ValueInString = word;
                model.Where(x => x.Position == onesPos).First().ValueInString = "";
            }
            return model;
        }

        }
}
