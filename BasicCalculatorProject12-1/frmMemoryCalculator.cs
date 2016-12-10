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

    public partial class frmMemoryCalculator : Form
    {
        Thread thread;//A thread variable that starts frmBasicalculatore
        public frmMemoryCalculator()
        {
            InitializeComponent();
        }

        //Declaration of various variables for to be used for storing operator Value
        string operatorValueStore;
        decimal curentDisplayValue;//A label that displays values being entered by the user
                                   //Calculator standardCalculator = new Calculator();
        MemoryCalculator memorycalculator;
        string operatorValue;//This variable stores the operator value when the user presses an operator
        string calculatedValue;//A variable that stores the calculated value
        string valueEnter;//Current Value enter by the user
        
        decimal finalMemoryValue = 0;//A variable that stores the current value in memory

        //A form load events thats that focuses the focus on the equal button
        private void calculator_Load(object sender, EventArgs e)
        {
            btnEqual.Focus();
        }

        //An event handler that backspace characters display in the label
        private void btnBack_Click(object sender, EventArgs e)
        {
            MemoryCalculator.BackSpace(lblResult);

            btnEqual.Focus();

        }


        //An event handler that fires the button that is being clicked on the calcultor
        private void UserNumberClick(object sender, EventArgs e)
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

            operatorValue += buttonValue.Text;

        }

        private void OperatorPress(object sender, EventArgs e)
        {

            //Casting of the operator sender to a button and saving the text in operatorValueStore
            Button operatorValue = (Button)sender;
            operatorValueStore = operatorValue.Text;

            //Set label value to zero to avoid FormatException
            SetLabelResult(lblResult);
            //Converting of the current value display to a decimal 
            valueEnter = MemoryCalculator.EnterValue(lblResult.Text);
            curentDisplayValue = Decimal.Parse(valueEnter);

            this.operatorValue = operatorValueStore;
            lblresultDisplayBox.Text = this.operatorValue;
            if (Double.Parse(lblResult.Text) == 0)
            {
                lblResult.Text = "0";
                lblresultDisplayBox.Text = "";
            }
            lblresultDisplayBox.Text = lblResult.Text + this.operatorValue;
            //Setting the textbox value to empty string if the user presses an operator
            lblResult.Text = "";

        }
        //An event handler that fires when the equal button is pressed
        private void EqualButtonPress(object sender, EventArgs e)
        {
            lblresultDisplayBox.Text = ""; //if the user presses the equals button set the label to empty string
            //Sets label value to zero to avoid FormatExceptions
            SetLabelResult(lblResult);
            valueEnter = MemoryCalculator.EnterValue(lblResult.Text);
            //Instantiation of the memory calculator      
            memorycalculator = new MemoryCalculator(curentDisplayValue, Decimal.Parse(valueEnter));

            //Calling the equals method from the Calculator class that was inherited
            calculatedValue = memorycalculator.Equals(operatorValueStore);
            memorycalculator.CurrentValue = calculatedValue; //Assigning the currentValue to a currentValue string
            valueEnter = memorycalculator.CurrentValue;//Current value in the calculator


            lblResult.Text = calculatedValue;//set the calculated value in the lblResult.Text label
            operatorValue = lblResult.Text;

            //Checks and perform the below operation base on user clicked
            if (operatorValueStore == "sqrt" || operatorValueStore == "1/X" || operatorValueStore == "+/-")
            {
                //Set the current values of sqrt root, +/- and reciprocal
                lblResult.Text = memorycalculator.operatorValue(operatorValueStore, curentDisplayValue.ToString());
            }


        }
        //A method that enables the memory button when there is a value in memory.
        public void memoryActive()
        {
            if (!finalMemoryValue.ToString().Equals("0"))
            {
                btnMemoryContainValue.Enabled = true;
            }
            else
            {
                btnMemoryContainValue.Enabled = false;
            }
        }
        // A method that listens for the various memory buttons and perform respective operation
        private void memoryButtonsClick(object sender, EventArgs e)
        {
            Button buttValue = (Button)sender;
            switch (buttValue.Text)
            {
                case "M+":
                   
                    finalMemoryValue += MemoryCalculator.MemoryAdd(Decimal.Parse(lblResult.Text));
                    memoryActive();
                    break;
                case "MR":
                    memoryActive();
                    lblResult.Text = MemoryCalculator.MemoryRecall(finalMemoryValue).ToString();
                    break;
                case "MC":                    
                    finalMemoryValue = 0;
                    memoryActive();
                    lblResult.Text = MemoryCalculator.MemoryClear(finalMemoryValue).ToString();
                    break;
                case "MS":
                    
                    finalMemoryValue = MemoryCalculator.MemoryStore(Convert.ToDecimal(lblResult.Text));
                    memoryActive();
                    break;
            }

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
        //This method sets the label that has a value of empty string to zero
        private void SetLabelResult(Label lblLabelSet)
        {
            if (lblLabelSet.Text == "")
            {
                lblLabelSet.Text = "0";
            }

        }
        // A event handler that opens the frmBasicCalculator on the memory calculator tool strip menu when standard calculator is clicked
        private void memoryCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openMemoryCalulator);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openMemoryCalulator(Object obj)
        {
            Application.Run(new frmBasicCalculator());

        }
        // A form event that loads and disable the M button on the calculator
        private void frmMemoryCalculator_Load(object sender, EventArgs e)
        {
            btnMemoryContainValue.Enabled = false;
        }
        //An event handler that clears the valuse display in the txtBox
       private void btnClear_Click(object sender, EventArgs e)
        {
            MemoryCalculator.Clear(lblResult,operatorValueStore,lblresultDisplayBox, operatorValueStore);
            lblresultDisplayBox.Text = "";
            btnEqual.Focus();

        }
    }      
 }
