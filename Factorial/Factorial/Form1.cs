namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                long result = CalculateFactorial(number);
                textBox2.Text = $"  {result}";
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            long CalculateFactorial(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * CalculateFactorial(n - 1);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}