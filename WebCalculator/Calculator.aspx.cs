using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        string firstNumber = "";
        string secondNumber = "";
        string totalString = "";
        string signOperation = "";
        bool fraction = false;
        double result = 0;

        CalcResult.CalServiceSoapClient calculator = new CalcResult.CalServiceSoapClient();

        public void Reload(List<string> array)
        {
            this.firstNumber = array[0];
            this.signOperation = array[1];
            this.secondNumber = array[2];
            this.totalString = array[3];
            this.fraction = bool.Parse(array[4]);
            this.result = Convert.ToDouble(array[5]);

            if (Session["firstNumber"] != null)
            {
                Session["firstNumber"] = firstNumber;
            }

            if (Session["signOperation"] != null)
            {
                Session["signOperation"] = signOperation;
            }

            if (Session["secondNumber"] != null)
            {
                Session["secondNumber"] = secondNumber;
            }

            if (Session["totalString"] != null)
            {
                Session["totalString"] = totalString;
            }

            if (Session["fraction"] != null)
            {
                Session["fraction"] = fraction.ToString();
            }

            if (Session["result"] != null)
            {
                Session["result"] = result.ToString();
            }
        }

        public List<string> Refreshed()
        {
            if (Session["firstNumber"] != null)
            {
                this.firstNumber = Session["firstNumber"].ToString();
            }

            if (Session["signOperation"] != null)
            {
                this.signOperation = Session["signOperation"].ToString();
            }

            if (Session["secondNumber"] != null)
            {
                this.secondNumber = Session["secondNumber"].ToString();
            }

            if (Session["totalString"] != null)
            {
                this.totalString = Session["totalString"].ToString();
            }

            if (Session["fraction"] != null)
            {
                this.fraction = bool.Parse(Session["fraction"].ToString());
            }

            if (Session["result"] != null)
            {
                this.result = Convert.ToDouble(Session["result"].ToString());
            }

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

        public void ResetAll()
        {
            this.firstNumber = "";
            this.secondNumber = "";
            this.totalString = "";
            this.signOperation = "";
            this.resultBox.Text = "";
            this.fraction = false;
            this.result = 0;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            calculator.Initialize();

            if(Session["firstNumber"] == null)
            {
                Session["firstNumber"] = "";
            }

            if (Session["signOperation"] == null)
            {
                Session["signOperation"] = "";
            }

            if (Session["secondNumber"] == null)
            {
                Session["secondNumber"] = "";
            }

            if (Session["totalString"] == null)
            {
                Session["totalString"] = "";
            }

            if (Session["fraction"] == null)
            {
                Session["fraction"] = "false";
            }

            if (Session["result"] == null)
            {
                Session["result"] = "0";
            }
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            buttonClicked(0);
        }

        protected void Button01_Click(object sender, EventArgs e)
        {
            buttonClicked(1);
        }

        protected void Button02_Click(object sender, EventArgs e)
        {
            buttonClicked(2);
        }

        protected void Button03_Click(object sender, EventArgs e)
        {
            buttonClicked(3);
        }

        protected void Button04_Click(object sender, EventArgs e)
        {
            buttonClicked(4);
        }

        protected void Button05_Click(object sender, EventArgs e)
        {
            buttonClicked(5);
        }

        protected void Button06_Click(object sender, EventArgs e)
        {
            buttonClicked(6);
        }

        protected void Button07_Click(object sender, EventArgs e)
        {
            buttonClicked(7);
        }

        protected void Button08_Click(object sender, EventArgs e)
        {
            buttonClicked(8);
        }

        protected void Button09_Click(object sender, EventArgs e)
        {
            buttonClicked(9);
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            Session["firstNumber"] = "";
            Session["signOperation"] = "";
            Session["secondNumber"] = "";
            Session["totalString"] = "";
            Session["fraction"] = "false";
            Session["result"] = "0";

            ResetAll();
        }

        protected void ButtonSum_Click(object sender, EventArgs e)
        {
            signClicked("+");
        }

        protected void ButtonSub_Click(object sender, EventArgs e)
        {
            signClicked("-");
        }

        protected void ButtonMult_Click(object sender, EventArgs e)
        {
            signClicked("x");
        }

        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            signClicked("/");
        }

        protected void ButtonPer_Click(object sender, EventArgs e)
        {
            signClicked("%");
        }

        protected void ButtonSqr_Click(object sender, EventArgs e)
        {
            List<string> cal_memory = Refreshed();

            if (signOperation == "")
            {
                if (firstNumber != "")
                {
                    firstNumber = (Convert.ToDouble(firstNumber) * Convert.ToDouble(firstNumber)).ToString();
                    totalString = firstNumber;
                    Session["firstNumber"] = firstNumber;
                }
            }
            else
            {
                if (secondNumber != "")
                {
                    secondNumber = (Convert.ToDouble(secondNumber) * Convert.ToDouble(secondNumber)).ToString();
                    totalString = firstNumber + " " + signOperation + " " + secondNumber;
                    Session["secondNumber"] = secondNumber;
                }
            }

            resultBox.Text = totalString;
            Session["totalString"] = totalString;
        }

        protected void ButtonRoot_Click(object sender, EventArgs e)
        {
            List<string> cal_memory = Refreshed();

            if (signOperation == "")
            {
                if (firstNumber != "")
                {
                    firstNumber = Math.Sqrt((Convert.ToDouble(firstNumber))).ToString();
                    totalString = firstNumber;
                    Session["firstNumber"] = firstNumber;
                }
            }
            else
            {
                if (secondNumber != "")
                {
                    secondNumber = Math.Sqrt((Convert.ToDouble(secondNumber))).ToString();
                    totalString = firstNumber + " " + signOperation + " " + secondNumber;
                    Session["secondNumber"] = secondNumber;
                }
            }

            resultBox.Text = totalString;
            Session["totalString"] = totalString;
        }

        protected void ButtonDott_Click(object sender, EventArgs e)
        {
            List<string> cal_memory = Refreshed();

            if (fraction == false)
            {
                if (signOperation == "")
                {
                    if (firstNumber == "")
                    {
                        firstNumber += "0.";
                        Session["firstNumber"] = firstNumber;
                    }
                    else
                    {
                        firstNumber += ".";
                        Session["firstNumber"] = firstNumber;
                    }

                }
                else
                {
                    if (secondNumber == "")
                    {
                        secondNumber += "0.";
                        Session["secondNumber"] = secondNumber;
                    }
                    else
                    {
                        secondNumber += ".";
                        Session["secondNumber"] = secondNumber;
                    }
                }

                fraction = true;
                totalString += ".";
                resultBox.Text = totalString;

                Session["fraction"] = fraction.ToString();
                Session["totalString"] = totalString;
            }
        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {
            List<string> cal_memory = Refreshed();
            List<string> calculation = calculator.Calculation(firstNumber, signOperation, secondNumber, totalString, fraction, result);
            Reload(calculation);
            resultBox.Text = totalString;
            firstNumber = result.ToString();
            signOperation = "";
            Session["firstNumber"] = firstNumber;
            Session["signOperation"] = "";
        }

        protected void ButtonErase_Click(object sender, EventArgs e)
        {
            List<string> cal_memory = Refreshed();

            if (secondNumber != "")
            {
                secondNumber = secondNumber.Remove(secondNumber.Length - 1, 1);
                Session["secondNumber"] = secondNumber;
            }
            else if (signOperation != "")
            {
                signOperation = "";
                Session["signOperation"] = "";
            }
            else if (firstNumber != "")
            {
                firstNumber = firstNumber.Remove(firstNumber.Length - 1, 1);
                Session["firstNumber"] = firstNumber;
            }

            totalString = firstNumber + " " + signOperation + " " + secondNumber ;
            resultBox.Text = totalString;
            Session["totalString"] = totalString;
        }
    }
}