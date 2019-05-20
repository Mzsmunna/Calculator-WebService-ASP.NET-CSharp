using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSCalculator
{
    /// <summary>
    /// Summary description for CalService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalService : System.Web.Services.WebService
    {
        string firstNumber;
        string secondNumber;
        string totalString;
        string signOperation;
        bool fraction;
        double result;

        public void Reload(string firstNumber, string signOperation, string secondNumber, string totalString, bool fraction, double result)
        {
            /*this.firstNumber = calcr_memory["firstNumber"];
            this.secondNumber = calcr_memory["secondNumber"];
            this.totalString = calcr_memory["totalString"];
            this.signOperation = calcr_memory["signOperation"];
            this.fraction = bool.Parse(calcr_memory["fraction"]);
            this.result = Convert.ToDouble(calcr_memory["result"]);*/

            this.firstNumber = firstNumber;
            this.signOperation = signOperation;
            this.secondNumber = secondNumber;
            this.totalString = totalString;
            this.fraction = fraction;
            this.result = result;
        }

        public List<string> Refreshed()
        {
            /*calcr_memory["firstNumber"] = firstNumber;
            calcr_memory["secondNumber"] = secondNumber;
            calcr_memory["totalString"] = totalString;
            calcr_memory["signOperation"] = signOperation;
            calcr_memory["fraction"] = fraction.ToString();
            calcr_memory["result"] = result.ToString();*/

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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod (EnableSession = true)]
        public void Initialize()
        {
            this.firstNumber = "";
            this.secondNumber = "";
            this.totalString = "";
            this.signOperation = "";
            this.fraction = false;
            this.result = 0;
        }

        [WebMethod]
        public List<string> Calculation(string firstNumber, string signOperation, string secondNumber, string totalString, bool fraction, double result)
        {
            Reload(firstNumber, signOperation, secondNumber, totalString, fraction, result);

            if ((this.firstNumber != "") && (this.secondNumber != ""))
            {
                double x = Convert.ToDouble(this.firstNumber);
                double y = Convert.ToDouble(this.secondNumber);

                if (this.signOperation == "+")
                {
                    this.result = x + y;
                }
                else if (this.signOperation == "-")
                {
                    this.result = x - y;
                }
                else if (this.signOperation == "x")
                {
                    this.result = x * y;
                }
                else if (this.signOperation == "/")
                {
                    this.result = x / y;
                }
                else if (this.signOperation == "%")
                {
                    this.result = (x / 100) * y;
                }

                this.totalString += " = " + this.result;
                this.secondNumber = "";
            }
            else if ((this.firstNumber != "") && (this.secondNumber == ""))
            {
                this.totalString = this.firstNumber;
            }

            List<string> res = Refreshed();

            return res;
        }

        [WebMethod]
        public List<string> ButtonPressed(int digit, string firstNumber, string signOperation, string secondNumber, string totalString, bool fraction, double result)
        {
            Reload(firstNumber, signOperation, secondNumber, totalString, fraction, result);

            if (this.signOperation == "")
            {
                this.firstNumber += digit;
            }
            else
            {
                this.secondNumber += digit;
            }

            this.totalString += digit;

            List<string> res = Refreshed();

            return res;
        }

        [WebMethod]
        public List<string> SignPressed(string sign, string firstNumber, string signOperation, string secondNumber, string totalString, bool fraction, double result)
        {
            Reload(firstNumber, signOperation, secondNumber, totalString, fraction, result);

            if ((this.signOperation == "") && (this.firstNumber != ""))
            {
                this.signOperation = sign;
                this.totalString += " " + sign + " ";
                this.fraction = false;
            }
            else if ((this.signOperation != "") && (this.firstNumber != "") && (this.secondNumber != ""))
            {
                List<string> cal_memory = Calculation(firstNumber, signOperation, secondNumber, totalString, fraction, result);
                this.firstNumber = this.result.ToString();
                this.signOperation = sign;
                this.totalString = this.result + " " + sign + " ";
                //fraction = false;
            }
            else if (this.result > 0)
            {
                this.firstNumber = this.result.ToString();
                this.signOperation = sign;
                this.totalString = this.result + " " + sign + " ";
            }

            if ((this.signOperation != "") && (this.firstNumber != "") && (this.secondNumber == ""))
            {
                //this.firstNumber = this.result.ToString();
                this.signOperation = sign;
                this.totalString = this.firstNumber + " " + sign + " ";
                //fraction = false;
            }

            List<string> res = Refreshed();

            return res;        
        }

        [WebMethod]
        public double Sum(double x, double y)
        {
            double sum = x + y;
            return sum;
        }

        [WebMethod]
        public double Sub(double x, double y)
        {
            double sub = x - y;
            return sub;
        }

        [WebMethod]
        public double Mult(double x, double y)
        {
            double mult = x * y;
            return mult;
        }

        [WebMethod]
        public double Div(double x, double y)
        {
            if(y == 0)
            {
                return 0;

            }else
            {
                double div = x / y;
                return div;
            }          
        }
    }
}
