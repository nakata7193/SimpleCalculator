using System;
using System.Windows.Forms;


namespace simple_calc
{
    public partial class Form1 : Form
    {
        public static decimal memoryStore = 0;
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
            if ((textBox_Result.Text == "0") || isOperationPerformed)
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
            isOperationPerformed = false;
            /*
             to fix the dot error!!!
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;
            */


        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Result != 0)
            {
                Button_Equal.PerformClick();
                OperationPerformed = button.Text;
                showCalculations.Text = Result + " " + OperationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                OperationPerformed = button.Text;
                Result = Double.Parse(textBox_Result.Text);
                showCalculations.Text = Result + " " + OperationPerformed;
                isOperationPerformed = true;
            }

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
                    textBox_Result.Text = (Result - double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (Result * double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (Result / double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "√":
                    textBox_Result.Text = (Result + Math.Sqrt(double.Parse(textBox_Result.Text)).ToString());
                    break;

                case "%":
                    textBox_Result.Text = (Result % double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
            Result = Double.Parse(textBox_Result.Text);
            showCalculations.Text = "";



        }

        private void buttonMR(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            string ButtonText = ButtonThatWasPushed.Text;
            decimal EndResult = 0;
            decimal MemoryStore = memoryStore;

            if (ButtonText == "MC")
            {
                //Memory Clear
                MemoryStore = 0;
                return;
            }

            if (ButtonText == "MR")
            {
                //Memory Recall
                textBox_Result.Text = MemoryStore.ToString();
                return;
            }

            if (ButtonText == "MS")
            {
                // Memory subtract
                MemoryStore -= EndResult;
                return;
            }

            if (ButtonText == "M+")
            {
                // Memory add 

                MemoryStore += EndResult;
                return;

            }
        }
    }
}

