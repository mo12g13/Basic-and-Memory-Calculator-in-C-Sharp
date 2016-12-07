using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculatorProject12_1
{
    class Calculator
    {
        private decimal first_Value;
        private decimal second_Value;
        private Stack<string> valueEnter;
        private string currentEnterValue;

        //This method returns the current value in the label
        public Calculator(decimal firstValue, decimal secondValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.valueEnter = new Stack<string>();
        }

        //A method that stores the first two value entered into the calculator
        public Stack<string> EnterValue(string firstValue, string secondValue)
        {
            firstValue = FirstValue.ToString();
            secondValue = SecondValue.ToString();
            valueEnter.Push(secondValue);
            valueEnter.Push(firstValue);
            return valueEnter;
        }

        //A property that gets and sets the current value display in the calculator
        public String CurrentValue
        {
            get
            {
                return currentEnterValue;
            }
            set
            {
                currentEnterValue = value;
            }
        }
       
        //The property that sets and gets the first value of the entered in the calculator
        public decimal FirstValue
        {
            get
            {
                return first_Value;
            }
            set
            {
                first_Value = value;
            }
        }
        //A property that sets and gets the second value entered in the calculator
        public decimal SecondValue
        {
            get
            {
                return second_Value;
            }
            set
            {
                second_Value = value;
            }
        }

        //A method that return sum of both numbers
        public decimal Add()
        {
            return FirstValue + SecondValue;
        }

        //This method return the substracted value of the calculator
        public decimal Substract()
        {
            return FirstValue - SecondValue;
        }
        // This method returns the multiplication value of the calculator    
        public decimal Multiply()
        {
            return FirstValue * SecondValue;
        }

        //This method return divided value of the calculator
        //return can't by zero if the numerator is zero
        public String Divide()
        {
            decimal value = 0;
            try
            {
                value = FirstValue / SecondValue;
            }
            catch (DivideByZeroException)
            {
                return "Can't divide by zero";
            }
            return value.ToString("N6");
        }

        //A method that returns a squareroot of number enter by the user
        public decimal SquareRoot(string number1)
        {

            decimal value = Decimal.Parse(number1);

            return value * value;
        }
        //A method that returns the reciprocal of the number being display in the lblResult.Text
        public String Reciprocal(string value)
        {
            decimal number = Decimal.Parse(value);
            if (number > 0)
            {
                return "-" + number.ToString();
            }
            else
            {
                return Math.Abs(number).ToString();
            }
        }
        // A method that divides   number 1 by the current value display on the calculator
        public string current_Value_Divide_One(String value)
        {
            decimal answer = 0;
            try
            {
                decimal currentResult = decimal.Parse(value);
                answer = (1 / currentResult);
            }
            catch (DivideByZeroException)
            {
                return "Can't divide by zero";

            }
            return answer.ToString("N5");


        }
        public string getCurrenValue()
        {
            return CurrentValue;
        }

        // A method that returns the calculated value when equal button is clicked
        public string Equals(String operatorValue)
        {
            string answer = "";
            switch (operatorValue)
            {
                case "+":
                    answer = "" + Add().ToString();
                    break;
                case "*":
                    answer = "" + Multiply();
                    break;
                case "/":
                    answer = Divide();
                    break;
                case "-":
                    answer = "" + Substract();
                    break;
            }
            return answer;
        }
        // A method that returns the various value of the operator press
        public string operatorValue(string operatorEnter, string calculatedValue)
        {
            string value = "";
            switch (operatorEnter)
            {
                case "sqrt":
                    value = SquareRoot(calculatedValue).ToString();

                    break;
                case "+/-":
                    value = Reciprocal(Convert.ToString(calculatedValue));
                    break;
                case "1/X":
                    value = current_Value_Divide_One(calculatedValue);
                    break;
            }
            return value;
        }
        //To do, the method that clears the controls
        public static void Clear(Label one, string store, Label two, string value2)
        {
            one.Text = "";
            one.Text = "0";
            store = "";
            two.Text = "";
            value2 = "";
        }
//A method that backspace value display in the calculator
        public static void BackSpace(Label value)
        {
            if (value.Text == "0")
            {
                value.Text = "0";

            }
            else if (value.Text == "")
            {
                value.Text = "0";

            }

            //A condition that delete from the text box when it is present
            else if (value.Text != "0" || value.Text != "")
            {
                // txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
                value.Text = value.Text.Remove(value.Text.Length - 1, 1);

            }
        }
        // A method the keeps track of the current value entered by the user
        public static string EnterValue(string enterValue)
        {
            return enterValue;
        }

    }
}


