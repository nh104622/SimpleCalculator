using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0.0;
        string operand1 = "";
        string operand2 = "";
        string input = "0";
        char operation;
        char prevOperation = ' ';
        bool opFailed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "9";
            else
                input += "9";
            Screen.Text += input;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "8";
            else
                input += "8";
            Screen.Text += input;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "7";
            else
                input += "7";
            Screen.Text += input;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "6";
            else
                input += "6";
            Screen.Text += input;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "5";
            else
                input += "5";
            Screen.Text += input;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "4";
            else
                input += "4";
            Screen.Text += input;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "3";
            else
                input += "3";
            Screen.Text += input;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "2";
            else
                input += "2";
            Screen.Text += input;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            if (input == "0")
                input = "1";
            else
                input += "1";
            Screen.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {

            Screen.Text = "";
            if (input.Length > 1)
            {
                if (input[0] == '0')
                {
                    input = "0";
                } else
                {
                    input += "0";
                }
            } else
            {
                input += "0";
            }

            Screen.Text += input;
        }


        private void DoMath()
        {
            
            if (input != "" || prevOperation == '=')
            {


                if (input != "")
                    operand2 = input;
                input = "";


                if (operand2 != "")
                {
                    if (operation == '/')
                    {
                        if (int.Parse(operand2) != 0)   //to prevent dividing by 0
                        {
                            result = double.Parse(operand1) / double.Parse(operand2);
                        }
                        else
                        {
                            Screen.Text = "Cannot divide by zero";
                            opFailed = true;
                        }
                    }
                    else if (operation == '*')
                        result = double.Parse(operand1) * double.Parse(operand2);
                    else if (operation == '-')
                        result = double.Parse(operand1) - double.Parse(operand2);
                    else if (operation == '+')
                        result = double.Parse(operand1) + double.Parse(operand2);
                    else if (operation == '^')
                        result = Math.Pow(double.Parse(operand1), double.Parse(operand2));
                    else if (operation == 'R')
                    {

                        if (double.Parse(operand1) >= 0 && double.Parse(operand2) != 0)
                        {

                            result = Math.Pow(double.Parse(operand1), 1.0 / double.Parse(operand2));
                        }
                        else
                        {

                            Screen.Text = "Invalid input";
                            opFailed = true;

                        }
                    }

                    if (!opFailed)
                    {
                        Screen.Text = result.ToString();
                        operand1 = result.ToString();   //set new result as operand1
                    }
                    else
                    {
                        opFailed = false;

                    }
                }
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            prevOperation = ' ';    //only used if user is hitting equals
            if (input != "")
            {

                if (operand1 == "")
                {
                    operand1 = input;   //store input  for operation
                    input = ""; //reset input
                }
                else
                {
                    DoMath();
                }

            }

            operation = '/';

        }


        private void Multiply_Click(object sender, EventArgs e)
        {
            prevOperation = ' ';
            if (input != "")
            {
                if (operand1 == "")
                {
                    operand1 = input;   //store input  for operation
                    input = ""; //reset input
                }
                else
                {
                    DoMath();
                }

            }

            operation = '*';

        }


        private void Subtract_Click(object sender, EventArgs e)
        {
            prevOperation = ' ';
            if (input != "")
            {
                if (operand1 == "")
                {
                    operand1 = input;   //store input  for operation
                    input = ""; //reset input
                }
                else
                {
                    DoMath();
                }

            }

            operation = '-';


        }


        private void Add_Click(object sender, EventArgs e)
        {
            prevOperation = ' ';
            if (input != "")
            {
                if (operand1 == "")
                {
                    operand1 = input;   //store input  for operation
                    input = ""; //reset input
                }
                else
                {

                    DoMath();
                }

            }
            operation = '+';
        }


        private void Equal_Click(object sender, EventArgs e)
        {

            prevOperation = '=';    //state we are performing an equal op
            DoMath();


        }


        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            input = "0";
            operand1 = "";
            operand2 = "";
            result = 0.0;
            prevOperation = ' ';
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            int temp;


            if (input.Length == 0)
            {
                temp = int.Parse(operand1);
            }
            else
            {
                temp = int.Parse(input);
            }

            temp = -temp;
          
            input = temp.ToString();
            Screen.Text = input;
        }

        private void Power_Click(object sender, EventArgs e)
        {
            prevOperation = ' ';
            if (input != "")
            {
                if (operand1 == "")
                {
                    operand1 = input;   //store input  for operation
                    input = ""; //reset input
                }
                else
                {
                    DoMath();
                }

            }

            operation = '^';
        }

        private void Root_Click(object sender, EventArgs e)
        {
            prevOperation = ' ';

            if (input != "")
            {
                if (operand1 == "")
                {
                    operand1 = input;   //store input  for operation
                    input = ""; //reset input
                }
                else
                {
                    DoMath();
                }

            }
            operation = 'R';

        }

        private void Decimal_Click(object sender, EventArgs e)
        {

            if (input.IndexOf('.')==-1) //no decimal in the value
            {
                input += ".";
                Screen.Text += ".";
            }
            
        }

    }
}
