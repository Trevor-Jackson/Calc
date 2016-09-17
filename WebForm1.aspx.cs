using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            try { 
                double num1 = double.Parse(FirstBox.Text);
                double num2 = double.Parse(secondBox.Text);
                double result;
                result = num1 + num2;
                resultLabel.Text = result.ToString();
                Error.Text = string.Empty;
                exceptionType.Text = string.Empty;
            } catch (Exception exception) {
                exceptionType.Text = exception.Message;
                Error.Text = "Please insert a number // fill in all fields"; }
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            try {
                double num1 = double.Parse(FirstBox.Text);
                double num2 = double.Parse(secondBox.Text);
                double result;
                result = num1 - num2;
                resultLabel.Text = result.ToString();
                Error.Text = string.Empty;
                exceptionType.Text = string.Empty;
            } catch (Exception exception) {
                exceptionType.Text = exception.Message;
                Error.Text = "Please insert a number // fill in all fields";}
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            try {
                double num1 = double.Parse(FirstBox.Text);
                double num2 = double.Parse(secondBox.Text);
                double result;
                result = num1 / num2;
                resultLabel.Text = result.ToString();
                Error.Text = string.Empty;
                exceptionType.Text = string.Empty;
            } catch (Exception exception) {             
                exceptionType.Text = exception.Message;
                Error.Text = "Please insert a number // fill in all fields"; }
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            try {
                double num1 = double.Parse(FirstBox.Text);
                double num2 = double.Parse(secondBox.Text);
                double result;
                result = num1 * num2;
                resultLabel.Text = result.ToString();
                exceptionType.Text = string.Empty;
                Error.Text = string.Empty;
            } catch (Exception exception) {
                exceptionType.Text = exception.Message;
                Error.Text = "Please insert a number // fill in all fields"; }
        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            FirstBox.Text = string.Empty;
            secondBox.Text = string.Empty;
            resultLabel.Text = string.Empty;
            exceptionType.Text = string.Empty;
            Error.Text = string.Empty;
        }
    }
}
