using System;
using System.Windows.Forms;

namespace simple_calc
{
    public partial class Form1 : Form
    {
        Double Result = 0;
        string OperationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || isOperationPerformed )
                textBox_Result.Clear();

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
            isOperationPerformed = false;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperationPerformed = button.Text;
            Result = double.Parse(textBox_Result.Text);
            showCalculations.Text = Result + " " + OperationPerformed;
            isOperationPerformed = true;
        }

        private void Button_C_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            Result = 0;
        }

        private void Button_Equal_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    textBox_Result.Text = (Result + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Result + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (Result + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (Result + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "√":
                    textBox_Result.Text = (Result + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "%":
                    textBox_Result.Text = (Result + double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
        }
    }
}
