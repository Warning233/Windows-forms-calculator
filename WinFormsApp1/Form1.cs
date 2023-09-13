using System.Diagnostics.Contracts;
using System.Runtime;
using System.Xml.XPath;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string previousOperation = "";
        private double currentValue = 0;
        private string currentOperation = "";
        private bool isNewInputNumber = true;

        private bool isDecimalEntered = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;



            if (isNewInputNumber)
            {

                if (button.Text != "0" && button.Text != ".")
                {
                    result.Text = button.Text;
                    isNewInputNumber = false;
                }
                else if (button.Text == ".")
                {
                    result.Text = "0" + button.Text;
                    isDecimalEntered = true;
                    isNewInputNumber = false;
                }
            }
            else
            {
                string buttonText = button.Text.Replace(",", ".");

                if (!(buttonText == "." && isDecimalEntered))
                {
                    result.Text += buttonText;

                    if (buttonText == ".")
                        isDecimalEntered = true;
                }
            }

        }

        private void ClearButton_Click(Object sender, EventArgs e)
        {
            result.Text = "0";
            currentValue = 0;
            currentOperation = "";
            isNewInputNumber = true;
            isDecimalEntered = false;
        }

        private void DeleteButton_Click(Object sender, EventArgs e)
        {
            if (result.Text.Length > 1)
            {
                string stringToSDelete = result.Text;
                stringToSDelete = stringToSDelete.Substring(0, stringToSDelete.Length - 1);
                if (stringToSDelete[stringToSDelete.Length - 1] == '.')
                {
                    stringToSDelete = stringToSDelete.Replace(".", "");
                }
                currentValue = double.Parse(stringToSDelete);
                result.Text = currentValue.ToString();
                isDecimalEntered = false;
            }
            else
                result.Text = "0";
        }

        private void ModuleButton_Click(Object sender, EventArgs e)
        {

            if (result.Text.Length > 0)
            {
                double newValue = Double.Parse(result.Text);
                if (newValue != 0)
                {
                    newValue *= -1;
                }
                result.Text = newValue.ToString();
            }
            else
                result.Text = "0";

        }
        private void EqualsButton_Click(Object sender, EventArgs e)
        {
            isNewInputNumber = false;
            Perform("=");
            previousOperation = "";
        }
        private void PlusButton_Click(Object sender, EventArgs e)
        {
            Perform("+");
            previousOperation = "+";
        }
        private void MinusButton_Click(Object sender, EventArgs e)
        {
            Perform("-");
            previousOperation = "-";
        }
        private void MultiplyButton_Click(Object sender, EventArgs e)
        {
            Perform("×");
            previousOperation = "×";
        }
        private void DivisionButton_Click(Object sender, EventArgs e)
        {

            Perform("÷");
            previousOperation = "÷";
        }
        private void SqrtButton_Click(Object sender, EventArgs e)
        {
            Perform("√x");
            previousOperation = "√x";
        }
        private void Perform(string operation)
        {
            if (result.Text.Length > 0)
            {
                if (!isNewInputNumber)
                {

                    double newValue = double.Parse(result.Text);



                    if (previousOperation != "")
                    {
                        switch (previousOperation)
                        {
                            case "+":
                                currentValue += newValue;
                                break;

                            case "-":
                                currentValue -= newValue;
                                break;

                            case "×":
                                currentValue *= newValue;
                                break;

                            case "÷":
                                if (newValue != 0)
                                {
                                    currentValue /= newValue;
                                }
                                else
                                {
                                    currentValue = double.NaN;
                                }
                                break;

                            case "√x":
                                if (newValue >= 0)
                                {
                                    currentValue = Math.Sqrt(newValue);
                                }
                                else
                                {
                                    currentValue = double.NaN;

                                }
                                break;

                        }
                    }
                    else
                    {
                        currentValue = newValue;
                    }
                    previousOperation = operation;
                    isNewInputNumber = true;
                    isDecimalEntered = false;
                    result.Text = currentValue.ToString();

                }
            }
            else
            {
                result.Text = "0";
            }
        }

    }
}