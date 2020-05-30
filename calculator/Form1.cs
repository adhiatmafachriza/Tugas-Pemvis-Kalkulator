using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public bool isResultClicked = false;
        public bool isParentOpenClicked = false;
        public bool isParentCloseClicked = false;
        public bool isOperandClicked = false;
        public bool isPlusMinusClicked = false;
        public bool isPowerClicked = false;
        DataTable table = new DataTable();
        Trigonometri trigonoOperation = new Trigonometri();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperandClick(object sender, EventArgs e)
        {
            isOperandClicked = true;
            Button button = (Button)sender;

            if (isResultClicked == true && isPowerClicked == false)
            {
                textBoxResult.Text = "0";
                textBoxHistory.Text = "";
                isResultClicked = false;
            }
            else if (isResultClicked == true && isPowerClicked == true)
            {
                textBoxHistory.Text = "";
                isResultClicked = false;
            }
                
            if(textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }

            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void btnOperatorClick(object sender, EventArgs e)
        {
            if (isResultClicked == true)
            {
                textBoxResult.Text = "0";
                textBoxHistory.Text = "";
                isResultClicked = false;
            }

            if (isPowerClicked == true)
            {
                //DataTable table = new DataTable();
                String expression = textBoxResult.Text;
                int indexPangkat = expression.IndexOf('^');
                String baseNum = expression.Substring(0, indexPangkat);
                String powerNum = expression.Substring(indexPangkat + 1);
                double baseNumFix = Convert.ToDouble(table.Compute(baseNum, String.Empty));
                double powerNumFix = Convert.ToDouble(table.Compute(powerNum, String.Empty));
                double result = Math.Pow(baseNumFix, powerNumFix);
                textBoxResult.Text = (result).ToString();
            }

            Button button = (Button)sender;
            textBoxHistory.Text = textBoxHistory.Text + " " + textBoxResult.Text + " " + button.Text;
            textBoxResult.Text = "0";
            isPowerClicked = false;
        }

        private void btnResultClick(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();
            String expression = "";
            double result;

            if (isParentOpenClicked == true && isParentCloseClicked == false)   // ( 7 + 2 =
            {
                textBoxHistory.Text = textBoxHistory.Text + " " + textBoxResult.Text + " )";   // ( 7 + 2 ) =
            }
            else
            {
                //  ( 7 + 2 ) atau 7 + 2
                if(isPowerClicked == true)
                {
                    expression = textBoxResult.Text;
                    int indexPangkat = expression.IndexOf('^');
                    String baseNum = expression.Substring(0, indexPangkat);
                    String powerNum = expression.Substring(indexPangkat + 1);
                    double baseNumFix = Convert.ToDouble(table.Compute(baseNum, String.Empty));
                    double powerNumFix = Convert.ToDouble(table.Compute(powerNum, String.Empty));
                    result = Math.Pow(baseNumFix, powerNumFix);
                    textBoxResult.Text = (result).ToString();
                }
                textBoxHistory.Text = textBoxHistory.Text + " " + textBoxResult.Text;
            }

            String expressionTemp = textBoxHistory.Text;

            if (expressionTemp.Contains(','))
            {
                expression = expressionTemp.Replace(',', '.');
            }
            else
            {
                expression = textBoxHistory.Text;
            }

            result = Convert.ToDouble(table.Compute(expression, String.Empty));
            textBoxResult.Text = (result).ToString();
            textBoxHistory.Text = textBoxHistory.Text + " =";
            isResultClicked = true;
            isParentOpenClicked = false;
            isParentCloseClicked = false;
            isOperandClicked = false;
            isPlusMinusClicked = false;
            isPowerClicked = false;
        }

        private void btnParentClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.Text == "(")
            {
                if(isResultClicked == true)
                {
                    textBoxHistory.Text = "";
                }

                textBoxHistory.Text = textBoxHistory.Text + " " + button.Text;
                isResultClicked = false;
                isParentOpenClicked = true;
                isParentCloseClicked = false;
                
                textBoxResult.Text = "0";
            }
            else if (button.Text == ")" && isParentOpenClicked == true)
            {
                textBoxHistory.Text = textBoxHistory.Text + " " + textBoxResult.Text + " " + button.Text;
                textBoxResult.Text = "";
                isParentCloseClicked = true;
                isParentOpenClicked = false;
            }
        }

        private void btnPlusMinusClicked(object sender, EventArgs e)
        {
            if(isOperandClicked == true)
            {
                if(isPlusMinusClicked == false)
                {
                    textBoxResult.Text = "-" + textBoxResult.Text;
                    isPlusMinusClicked = true;
                }
                else
                {
                    String result = textBoxResult.Text;
                    textBoxResult.Text = result.Substring(1, 1);
                    isPlusMinusClicked = false;
                }
                
            }
        }

        private void btnClearClick(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            textBoxHistory.Text = "";
            isResultClicked = false;
            isParentOpenClicked = false;
            isParentCloseClicked = false;
            isOperandClicked = false;
            isPlusMinusClicked = false;
        }

        private void btnTrigonoClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.Text == "sin" && isOperandClicked == true)
            {
                String expression = textBoxResult.Text;
                double angle = Convert.ToDouble(expression);
                double result = trigonoOperation.calculateSin(angle);
                if(result < 1 || result != -1)
                {
                    String strResult = (result).ToString();
                    textBoxResult.Text = strResult.Replace(',', '.');
                }
                else
                    textBoxResult.Text = (result).ToString();
                
            }
            else if(button.Text == "cos" && isOperandClicked == true)
            {
                String expression = textBoxResult.Text;
                double angle = Convert.ToDouble(expression);
                double result = trigonoOperation.calculateCos(angle);
                if(result < 1 || result != -1)
                {
                    String strResult = (result).ToString();
                    textBoxResult.Text = strResult.Replace(',', '.');
                }
                else
                    textBoxResult.Text = (result).ToString();
            }
            else if(button.Text == "tan" && isOperandClicked == true)
            {
                String expression = textBoxResult.Text;
                double angle = Convert.ToDouble(expression);
                double result = trigonoOperation.calculateTan(angle);
                if(result < 1 || result != -1)
                {
                    String strResult = (result).ToString();
                    textBoxResult.Text = strResult.Replace(',', '.');
                }
                else
                    textBoxResult.Text = (result).ToString();
            }
        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            String result = textBoxResult.Text;

            if (result.Length > 0)
                textBoxResult.Text = result.Substring(0, result.Length - 1);
            else
                textBoxResult.Text = "0";
        }

        private void btnPangkatClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String expression = "";
            String expressionTemp = textBoxResult.Text;

            if (expressionTemp.Contains(','))
                expression = expressionTemp.Replace(',', '.');
            else
                expression = textBoxResult.Text;

            double baseNum = Convert.ToDouble(table.Compute(expression, String.Empty));

            if (button.Text == "x^2")
            {
                double result = Math.Pow(baseNum, 2);
                textBoxResult.Text = (result).ToString();
                isPowerClicked = false;
            }
            else if(button.Text == "x^3")
            {
                double result = Math.Pow(baseNum, 3);
                textBoxResult.Text = (result).ToString();
                isPowerClicked = false;
            }
            else if(button.Text == "x^n")
            {
                isPowerClicked = true;
                textBoxResult.Text = textBoxResult.Text + "^";
            }
            else if(button.Text == "10^n")
            {
                double result = Math.Pow(10, baseNum);
                textBoxResult.Text = (result).ToString();
                isPowerClicked = false;
            }
            else if(button.Text == "1/x")
            {
                double result = 1 / baseNum;
                textBoxResult.Text = (result).ToString();
                isPowerClicked = false;
            }
        }
    }
}
