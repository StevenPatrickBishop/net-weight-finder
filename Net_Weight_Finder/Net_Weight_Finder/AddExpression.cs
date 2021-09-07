using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Weight_Finder
{
    class AddExpression
    {
        private List<Double> valueList;
        private Double listSum;
        private string inputString = "";
        private string tempString = "";



        public AddExpression() {

            valueList = new List<double>();
        }


        //set the input string
        private void setInputString(string inputPassedIn) {


            if (inputPassedIn.Contains('-') ||
                inputPassedIn.Contains('/') ||
                inputPassedIn.Contains('*')) 
            {
               throw new FormatException("Only addition is allowed");
            }

            if (inputPassedIn.EndsWith(" ") ||
                inputPassedIn.EndsWith(",") ||
                inputPassedIn.EndsWith("+"))

            {
                throw new FormatException("Invalid entry Try again");
            }

            inputString = inputPassedIn;
        }

        public double getListSum(string inputPassedIn) {


            //call set input method
            setInputString(inputPassedIn);


            while (inputString.Length > 0)
            {

                while (inputString.StartsWith(" ") ||
                       inputString.StartsWith(",") ||
                       inputString.StartsWith("+"))
                {
                    inputString = inputString.Remove(0, 1);
                }


                int delimitPoint = 0;

                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i].Equals(' ') ||
                        inputString[i].Equals(',') ||
                        inputString[i].Equals('+'))
                    {
                        delimitPoint = i;
                        break;
                    }
                }


                if (delimitPoint == 0)
                {

                    tempString = inputString.Substring(0);
                    valueList.Add(DParse(tempString));
                    inputString = "";
                }
                else
                {
                    tempString = inputString.Substring(0, delimitPoint);
                    valueList.Add(DParse(tempString));
                    inputString = inputString.Substring(delimitPoint);

                }

            }

            listSum = valueList.Sum();
            valueList.RemoveRange(0, valueList.Count());


            return listSum;
        }

        private double DParse(string testValue) {

            double number;

            if (Double.TryParse(testValue, out number))
            {

                return number;
            }

            else {
                throw new FormatException("Invalid input, try again");
            }


        }
    }
}
