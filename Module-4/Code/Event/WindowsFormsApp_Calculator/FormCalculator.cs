using System;
using System.Windows.Forms;
using ClassLibrary_Calculator;

namespace WindowsFormsApp_Calculator
{
    public partial class FormCalculator : Form
    {
        #region Constructor
        public FormCalculator()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region objects_declaration
        Calculator objcalculator = new Calculator();
        #endregion objects_declaration

        #region method_btnAddition
        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text))
            {
                txtAnswer.Text = "Number can't be blank";
            }
            else if (Convert.ToDouble(txtNumber1.Text) < 0 || Convert.ToDouble(txtNumber2.Text) < 0)
            {
                txtAnswer.Text = "Invalid Input";
            }
            else
            {
                double answer;
                lblAnswer.Text = "(" + txtNumber1.Text.ToString().Trim() + " + " + txtNumber2.Text.ToString().Trim() + ")";
                answer = objcalculator.Addition(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
                txtAnswer.Text = Convert.ToString(answer);
            }
        }
        #endregion method_btnAddition

        #region method_btnSubtraction
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text))
            {
                txtAnswer.Text = "Number can't be blank";
            }
            else if (Convert.ToDouble(txtNumber1.Text) < 0 || Convert.ToDouble(txtNumber2.Text) < 0)
            {
                txtAnswer.Text = "Invalid Input";
            }
            else
            {
                double answer;
                lblAnswer.Text = "(" + txtNumber1.Text.ToString().Trim() + " - " + txtNumber2.Text.ToString().Trim() + ")";
                answer = objcalculator.Subtraction(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
                txtAnswer.Text = Convert.ToString(answer);
            }
        }
        #endregion method_btnSubtraction

        #region method_btnClear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = String.Empty;
            txtNumber2.Text = String.Empty;
            txtAnswer.Text = String.Empty;
            lblAnswer.Text = String.Empty;
        }
        #endregion method_btnClear

        #region method_btnMultiplication
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text))
            {
                txtAnswer.Text = "Number can't be blank";
            }
            else if (Convert.ToDouble(txtNumber1.Text) < 0 || Convert.ToDouble(txtNumber2.Text) < 0)
            {
                txtAnswer.Text = "Invalid Input";
            }
            else
            {
                double answer;
                lblAnswer.Text = "(" + txtNumber1.Text.ToString().Trim() + " * " + txtNumber2.Text.ToString().Trim() + ")";
                answer = objcalculator.Multiplication(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
                txtAnswer.Text = Convert.ToString(answer);
            }
        }
        #endregion method_btnMultiplication

        #region method_btnDivision
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text))
            {
                txtAnswer.Text = "Number can't be blank";
            }
            else if (Convert.ToDouble(txtNumber1.Text) < 0 || Convert.ToDouble(txtNumber2.Text) < 0)
            {
                txtAnswer.Text = "Invalid Input";
            }
            else
            {
                double answer;
                lblAnswer.Text = "(" + txtNumber1.Text.ToString().Trim() + " / " + txtNumber2.Text.ToString().Trim() + ")";
                answer = objcalculator.Division(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
                txtAnswer.Text = Convert.ToString(answer);
            }
        }
        #endregion method_btnDivision

        #region method_btnModulo
        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text))
            {
                txtAnswer.Text = "Number can't be blank";
            }
            else if (Convert.ToDouble(txtNumber1.Text) < 0 || Convert.ToDouble(txtNumber2.Text) < 0)
            {
                txtAnswer.Text = "Invalid Input";
            }
            else
            {
                double answer;
                lblAnswer.Text = "(" + txtNumber1.Text.ToString().Trim() + " % " + txtNumber2.Text.ToString().Trim() + ")";
                answer = objcalculator.Modulo(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
                txtAnswer.Text = Convert.ToString(answer);
            }
        }
        #endregion method_btnModulo
    }
}
