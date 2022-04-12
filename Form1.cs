using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserInputBox : Form
    {
        public UserInputBox()
        {
            InitializeComponent();

        }
        #region Variables
        string digits;
        double num1;
        double num2;
        #endregion

        #region Display BOX
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void UserInputBox_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Number Buttons
        private void OneButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        private void DotButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
        #endregion

        #region Operator Buttons
        private void MinusButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "-";
            }
            else
            {
                textBox1.Text = textBox1.Text + "-";
            }
        }
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "*";
            }
            else
            {
                textBox1.Text = textBox1.Text + "*";
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "+";
            }
            else
            {
                textBox1.Text = textBox1.Text + "+";
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "/";
            }
            else
            {
                textBox1.Text = textBox1.Text + "/";
            }

        }
        #endregion

        #region Function Buttons
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            digits = textBox1.Text; //takes everything that was typed in the calculator
            digits.Trim(); //Removes empty spaces

            if (digits.Contains("+"))
            {
                int position1 = digits.IndexOf("+"); //finds the index position of the operator

                num1 = Convert.ToDouble(digits.Substring(0, position1--)); //takes everything left of the operator

                num2 = Convert.ToDouble(digits.Substring(position1 + 2)); //takes everything right of the opperator // had to do +2 becase it was saving the numerator into the string
                                           

                this.textBox1.Text= Convert.ToString(Class1.addition(num1,num2)); // displays the calculation result

                //Bellow is to set the focus to the last digit in order to type again
                this.textBox1.Focus();
                this.textBox1.SelectionStart = textBox1.Text.Length;

            }

            if (digits.Contains("-"))
            {
                int position1 = digits.IndexOf("-"); //finds the index position of the operator

                num1 = Convert.ToDouble(digits.Substring(0, position1--)); //takes everything left of the operator

                num2 = Convert.ToDouble(digits.Substring(position1 + 2)); //takes everything right of the opperator // had to do +2 becase it was saving the numerator into the string


                this.textBox1.Text = Convert.ToString(Class1.subtraction(num1, num2));
                this.textBox1.Text = Convert.ToString(Class1.addition(num1, num2));
                this.textBox1.Focus();
                this.textBox1.SelectionStart = textBox1.Text.Length;

            }

            if (digits.Contains("*"))
            {
                int position1 = digits.IndexOf("*"); //finds the index position of the operator

                num1 = Convert.ToDouble(digits.Substring(0, position1--)); //takes everything left of the operator

                num2 = Convert.ToDouble(digits.Substring(position1 + 2)); //takes everything right of the opperator // had to do +2 becase it was saving the numerator into the string


                this.textBox1.Text = Convert.ToString(Class1.multiplication(num1, num2)); 

                this.textBox1.Text = Convert.ToString(Class1.addition(num1, num2));
                this.textBox1.Focus();
                this.textBox1.SelectionStart = textBox1.Text.Length;

            }

            if (digits.Contains("/"))
            {
                int position1 = digits.IndexOf("/"); //finds the index position of the operator

                num1 = Convert.ToDouble(digits.Substring(0, position1--)); //takes everything left of the operator

                num2 = Convert.ToDouble(digits.Substring(position1 + 2)); //takes everything right of the opperator // had to do +2 becase it was saving the numerator into the string


                this.textBox1.Text = Convert.ToString(Class1.division(num1, num2)); 

                this.textBox1.Text = Convert.ToString(Class1.addition(num1, num2));
                this.textBox1.Focus();
                this.textBox1.SelectionStart = textBox1.Text.Length;

            }

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num1 = 0;
            num2 = 0;
            sign = null;
        }
        #endregion



        private void EqualsButton_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
