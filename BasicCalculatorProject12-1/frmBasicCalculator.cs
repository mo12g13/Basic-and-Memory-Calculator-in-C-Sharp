using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicCalculatorProject12_1
{
    public partial class frmBasicCalculator : Form
    {
        Thread thread;
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        //Declaration of various variables for to be used for storing operator Value
        string operatorValueStore;
        decimal curentDisplayValue;//A label that displays values being entered by the user
                                   //Calculator standardCalculator = new Calculator();
        string storeOperator;//Value store in 
        string calculatedValue;//Current calculated Value
        string enterValue;

        //A form load events thats that focuses the focus on the equal button
        private void calculator_Load(object sender, EventArgs e)
        {
            btnEqual.Focus();
        }

        //An event handler that backspace characters display in the textbox
        private void btnBack_Click(object sender, EventArgs e)
        {
            Calculator.BackSpace(lblResult);

            btnEqual.Focus();

        }


        //An event handler that fires the button that is being clicked on the calcultor
        private void NumberPressk(object sender, EventArgs e)
        {
            //If the value in the textbox is equals to zero, clear the zero when a number is clicked
            if (lblResult.Text.Equals("0"))
            {

                lblResult.Text = "";
            }

            //Casting of the sender to a button
            Button buttonValue = (Button)sender;

            //Storing of the sender in the lblResult.Text
            lblResult.Text += buttonValue.Text;

            storeOperator += buttonValue.Text;

        }
        //An event handler that listen for the various operator enter by the user
        private void operatorSelected(object sender, EventArgs e)
        {

            //Casting of the operator sender to a button and saving the text in operatorValueStore
            Button operatorValue = (Button)sender;
            operatorValueStore = operatorValue.Text;
            //A method from the calculator class the get the EnterValue by calling Enter Value Method
            enterValue = Calculator.EnterValue(lblResult.Text);
            //Converting the enter enterValue to a decimal
            curentDisplayValue = Decimal.Parse(enterValue);
           

            storeOperator = operatorValueStore;
            lblresultDisplayBox.Text = storeOperator;
            if (Double.Parse(lblResult.Text) == 0)
            {
                lblResult.Text = "0";
                lblresultDisplayBox.Text = "";
            }
            lblresultDisplayBox.Text = lblResult.Text + storeOperator;
           
            lblResult.Text = "";

        }
        // The equal button event handler 
        private void EqualPress(object sender, EventArgs e)
        {
            lblresultDisplayBox.Text = "";
            if(lblResult.Text == "")
            {
                lblResult.Text = "0";
            }
            //Convert the second EnterValue enter by the user by the calling the EnterValue Method of calculator class
            enterValue = Calculator.EnterValue(lblResult.Text);
            //Instatiation the calculator to be used for calculation
            Calculator basicCalculator = new Calculator(curentDisplayValue, Decimal.Parse(enterValue));
            //Calling the equal method from the calculator to calculate the what ever operator was passed
            calculatedValue = basicCalculator.Equals(operatorValueStore);
            enterValue = Calculator.EnterValue(lblResult.Text);

            //A property that sets and gets the current calculated value by calling CurrentValue Property
            basicCalculator.CurrentValue = calculatedValue;            //Assigning the currentValue to a currentValue string
            string currentValue = basicCalculator.CurrentValue;
            lblResult.Text = currentValue;
            storeOperator = lblResult.Text;          
            // A condition that checks and perform the respective operations
            if (operatorValueStore == "sqrt" || operatorValueStore == "1/X" || operatorValueStore == "+/-")
            {
                string currentOperator = operatorValueStore;              
                //Set the current values of sqrt root, +/- and reciprocal
                string currentAnswer= basicCalculator.operatorValue(operatorValueStore, curentDisplayValue.ToString());
                lblResult.Text = currentAnswer;
                currentAnswer += operatorValueStore;
           }             
            
           
        }
        //An event handler that clears the valuse display in the txtBox
        private void btnClear_Click(object sender, EventArgs e)
        {
            Calculator.Clear(lblResult, storeOperator, lblresultDisplayBox, operatorValueStore);
            lblresultDisplayBox.Text = "";
            btnEqual.Focus();

        }
        //The calculator key pressed event that response to value being keyed by the user
        private void calculator_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    btnEqual.Focus();
                    break;
                case "1":
                    btn1.PerformClick();
                    btnEqual.Focus();
                    break;
                case "2":
                    btn2.PerformClick();
                    btnEqual.Focus();
                    break;
                case "3":
                    btn3.PerformClick();
                    btnEqual.Focus();
                    break;
                case "4":
                    btn4.PerformClick();
                    btnEqual.Focus();
                    break;
                case "5":
                    btn5.PerformClick();
                    btnEqual.Focus();
                    break;
                case "6":
                    btn6.PerformClick();
                    btnEqual.Focus();
                    break;
                case "7":
                    btn7.PerformClick();
                    btnEqual.Focus();
                    break;
                case "8":
                    btn8.PerformClick();
                    btnEqual.Focus();
                    break;
                case "9":
                    btn9.PerformClick();

                    break;
                case "*":
                    btnMultiplication.PerformClick();
                    break;
                case "+":
                    btnAddition.PerformClick();
                    break;
                case "-":
                    btnSubstract.PerformClick();
                    break;
                case "/":
                    btnDivide.PerformClick();
                    break;
                case "sqrt":
                    btnSquareRoot.PerformClick();
                    break;
                case "1/X":
                    btnDivideOne.PerformClick();
                    break;
                case ".":
                    btnDot.PerformClick();
                    break;
             default:
                    break;
            }

        }
        // A thread that loads the memory calculator when the  tool strip of Memory calulator is clicked
        private void memoryCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openMemoryCalulator);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
      
        private void  openMemoryCalulator(Object obj)
        {
            Application.Run(new frmMemoryCalculator());
            
        }
        //An event handler that exit the forms when clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
