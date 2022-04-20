namespace CaculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public decimal? savedValue;
        public string lastOperation = string.Empty;
        public decimal secondValue;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 1;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 2;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 3;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if(savedValue == null)
            {
                MessageBox.Show("select a mathmatical operation or clear");
            }
            else if(lastOperation=="+")
            {
                secondValue = decimal.Parse(caculatorDisplay.Text);
                caculatorDisplay.Text= (savedValue + secondValue).ToString();
                savedValue = null;
                savedValueDisplay.Text= String.Empty;
            }
            else if (lastOperation == "-")
            {
                secondValue = decimal.Parse(caculatorDisplay.Text);
                caculatorDisplay.Text = (savedValue - secondValue).ToString();
                savedValue = null;
                savedValueDisplay.Text = String.Empty;
            }
            else if (lastOperation == "*")
            {
                secondValue = decimal.Parse(caculatorDisplay.Text);
                caculatorDisplay.Text = (savedValue * secondValue).ToString();
                savedValue = null;
                savedValueDisplay.Text = String.Empty;
            }
            else if (lastOperation == "/")
            {
                secondValue = decimal.Parse(caculatorDisplay.Text);
                caculatorDisplay.Text = (savedValue / secondValue).ToString();
                savedValue = null;
                savedValueDisplay.Text = String.Empty;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            savedValue = null;
            caculatorDisplay.Text = string.Empty;
            savedValueDisplay.Text= string.Empty;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 4;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 5;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 6;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (savedValue == null & caculatorDisplay.Text!= string.Empty)
            {
                savedValue = decimal.Parse(caculatorDisplay.Text);
                savedValueDisplay.Text =savedValue.ToString();
                caculatorDisplay.Text= String.Empty;
                lastOperation = "+";
            }
            else if(caculatorDisplay.Text == string.Empty)
            {
                MessageBox.Show("enter a value");
            }
            else
            {
                savedValue = (savedValue + decimal.Parse(caculatorDisplay.Text));
                savedValueDisplay.Text= savedValue.ToString();
                caculatorDisplay.Text = string.Empty;
                lastOperation = "+";
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (savedValue == null & caculatorDisplay.Text != string.Empty)
            {
                savedValue = decimal.Parse(caculatorDisplay.Text);
                savedValueDisplay.Text = savedValue.ToString();
                caculatorDisplay.Text = String.Empty;
                lastOperation = "-";
            }
            else if (caculatorDisplay.Text == string.Empty)
            {
                MessageBox.Show("enter a value");
            }
            else
            {
                savedValue = (savedValue - decimal.Parse(caculatorDisplay.Text));
                savedValueDisplay.Text = savedValue.ToString();
                caculatorDisplay.Text = string.Empty;
                lastOperation = "-";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 7;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 8;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 9;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (savedValue == null & caculatorDisplay.Text != string.Empty)
            {
                savedValue = decimal.Parse(caculatorDisplay.Text);
                savedValueDisplay.Text = savedValue.ToString();
                caculatorDisplay.Text = String.Empty;
                lastOperation = "*";
            }
            else if (caculatorDisplay.Text == string.Empty)
            {
                MessageBox.Show("enter a value");
            }
            else
            {
                savedValue = (savedValue * decimal.Parse(caculatorDisplay.Text));
                savedValueDisplay.Text = savedValue.ToString();
                caculatorDisplay.Text = string.Empty;
                lastOperation = "*";
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (savedValue == null & caculatorDisplay.Text != string.Empty)
            {
                savedValue = decimal.Parse(caculatorDisplay.Text);
                savedValueDisplay.Text = savedValue.ToString();
                caculatorDisplay.Text = String.Empty;
                lastOperation = "/";
            }
            else if (caculatorDisplay.Text == string.Empty)
            {
                MessageBox.Show("enter a value");
            }
            else
            {
                savedValue = (savedValue / decimal.Parse(caculatorDisplay.Text));
                savedValueDisplay.Text = savedValue.ToString();
                caculatorDisplay.Text = string.Empty;
                lastOperation = "/";
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            caculatorDisplay.Text += 0;
        }
    }
}