using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskCalculator
{
    public partial class calculatorForm : Form
    {
        string firstNumber="";
        string secondNumber="";
        string totalString = "";
        string signOperation="";
        bool fraction = false;
        double result = 0;

        CalcResult.CalServiceSoapClient calculator = new CalcResult.CalServiceSoapClient();    

        public calculatorForm()
        {
            InitializeComponent();
        }

        private void calculatorForm_Load(object sender, EventArgs e)
        {
            calculator.Initialize();      
        }

        public void Reload(List<string> array)
        {
            this.firstNumber = array[0];
            this.signOperation = array[1];
            this.secondNumber = array[2];
            this.totalString = array[3];
            this.fraction = bool.Parse(array[4]); ;
            this.result = Convert.ToDouble(array[5]);
        }

        public List<string> Refreshed()
        {
            //As List(Of String)
            List<string> cal_vars = new List<string>();
            cal_vars.Add(firstNumber);
            cal_vars.Add(signOperation);
            cal_vars.Add(secondNumber);
            cal_vars.Add(totalString);
            cal_vars.Add(fraction.ToString());
            cal_vars.Add(result.ToString());
            //return cal_vars.ToArray();
            return cal_vars;
        }

        /*public void buttonPressed(int digit)
        {
            if (signOperation == "")
            {
                firstNumber += digit;
            }
            else
            {
                secondNumber += digit;
            }

            totalString += digit;
            resultBox.Text = totalString;

        }*/

        /*public void signPressed(string sign)
        {
            if ((signOperation == "") && (firstNumber != ""))
            {
                signOperation = sign;
                totalString += " " + sign + " ";
                resultBox.Text = totalString;
                fraction = false;
            }
            else if ((signOperation != "") && (firstNumber != "") && (secondNumber != ""))
            {
                calculation();
                firstNumber = result.ToString();
                signOperation = sign;
                totalString += result + " " + sign + " ";
                resultBox.Text = totalString;
                //fraction = false;
            }
            else if (result > 0)
            {
                firstNumber = result.ToString();
                signOperation = sign;
                totalString += result + " " + sign + " ";
                resultBox.Text = totalString;
            }
        }*/

        /*public void calculation()
        {
            if ((firstNumber != "") && (secondNumber != ""))
            {
                double x = Convert.ToDouble(firstNumber);
                double y = Convert.ToDouble(secondNumber);

                if (signOperation == "+")
                {
                    result = x + y;
                }
                else if (signOperation == "-")
                {
                    result = x - y;
                }
                else if (signOperation == "x")
                {
                    result = x * y;
                }
                else if (signOperation == "/")
                {
                    result = x / y;
                }
                else if (signOperation == "%")
                {
                    result = (x / 100) * y;
                }

                totalString += " = " + result;
            }
            else if ((firstNumber != "") && (secondNumber == ""))
            {
                totalString = firstNumber;
            }

            resultBox.Text = totalString;

            firstNumber = "";
            secondNumber = "";
            totalString = "";
            signOperation = "";
            fraction = false;
        }*/

        public void ResetAll()
        {
            firstNumber = "";
            secondNumber = "";
            totalString = "";
            signOperation = "";
            resultBox.Text = "";
            fraction = false;
            result = 0;
        }

        public void buttonClicked(int digit)
        {
            List<string> cal_memory = Refreshed();
            List<string> calculation = calculator.ButtonPressed(digit, firstNumber, signOperation, secondNumber, totalString, fraction, result);
            Reload(calculation);
            resultBox.Text = totalString;
        }

        public void signClicked(string sign)
        {
            List<string> cal_memory = Refreshed();
            List<string> calculation = calculator.SignPressed(sign, firstNumber, signOperation, secondNumber, totalString, fraction, result);
            Reload(calculation);
            resultBox.Text = totalString;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //buttonPressed(0);
            buttonClicked(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buttonPressed(1);
            buttonClicked(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buttonPressed(2);
            buttonClicked(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //buttonPressed(3);
            buttonClicked(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //buttonPressed(4);
            buttonClicked(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //buttonPressed(5);
            buttonClicked(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //buttonPressed(6);
            buttonClicked(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //buttonPressed(7);
            buttonClicked(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //buttonPressed(8);
            buttonClicked(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //buttonPressed(9);
            buttonClicked(9);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //signPressed("+");
            signClicked("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            //signPressed("-");
            signClicked("-");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            //signPressed("x");
            signClicked("x");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            //signPressed("/");
            signClicked("/");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            //calculation();
            List<string> cal_memory = Refreshed();
            List<string> calculation = calculator.Calculation(firstNumber, signOperation, secondNumber, totalString, fraction, result);
            Reload(calculation);
            resultBox.Text = totalString;
            firstNumber = result.ToString();
            signOperation = "";
        }

        private void buttonDott_Click(object sender, EventArgs e)
        {
            if(fraction==false)
            {
                if (signOperation == "")
                {
                    if(firstNumber=="")
                    {
                        firstNumber += "0.";
                    }
                    else
                    {
                        firstNumber += ".";
                    }
                    
                }
                else
                {
                    if (secondNumber == "")
                    {
                        secondNumber += "0.";
                    }
                    else
                    {
                        secondNumber += ".";
                    }
                }

                fraction = true;
                totalString += ".";
                resultBox.Text = totalString;
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            //signPressed("%");
            signClicked("%");
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (signOperation == "")
            {
                if (firstNumber != "")
                { 
                    firstNumber = (Convert.ToDouble(firstNumber) * Convert.ToDouble(firstNumber)).ToString();
                    totalString = firstNumber;
                }
            }
            else
            {
                if (secondNumber != "")
                {
                    secondNumber = (Convert.ToDouble(secondNumber) * Convert.ToDouble(secondNumber)).ToString();
                    totalString = firstNumber + " " + signOperation + " " + secondNumber;
                }
            }

            resultBox.Text = totalString;
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            List<string> cal_memory = Refreshed();

            if (signOperation == "")
            {
                if (firstNumber != "")
                {
                    firstNumber = Math.Sqrt((Convert.ToDouble(firstNumber))).ToString();
                    totalString = firstNumber;
                }
            }
            else
            {
                if (secondNumber != "")
                {
                    secondNumber = Math.Sqrt((Convert.ToDouble(secondNumber))).ToString();
                    totalString = firstNumber + " " + signOperation + " " + secondNumber;
                }
            }

            resultBox.Text = totalString;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            List<string> cal_memory = Refreshed();

            if (secondNumber != "")
            {
                secondNumber = secondNumber.Remove(secondNumber.Length - 1, 1);
            }
            else if (signOperation != "")
            {
                signOperation = "";
            }
            else if (firstNumber != "")
            {
                firstNumber = firstNumber.Remove(firstNumber.Length - 1, 1);
            }

            totalString = firstNumber + " " + signOperation + " " + secondNumber;
            resultBox.Text = totalString;
        }
    }
}
