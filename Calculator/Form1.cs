namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String total;
        int num1;
        int num2;
        String option;
        int result;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
            //plus
        }

        private void button15_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
            //divide
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {


        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button02_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button00_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button04_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button05_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button06_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }


        private void buttonttl_Click_1(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            if (option == ("+"))
                result = num1 + num2;

            if (option == ("-"))
                result = num1 - num2;

            if (option == ("*"))
                result = num1 * num2;

            if (option == ("/"))
                result = num1 / num2;

            textBox1.Text = result + "";

            //total
        }

        private void buttonmul_Click_1(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
            //multiply
        }

        private void buttonsub_Click_1(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
            //minus
        }
    }
}
