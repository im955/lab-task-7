namespace Farheniet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


             void Form1_Load(object sender, EventArgs e)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                textBox2.Text = celsius.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Please enter a valid Fahrenheit temperature.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}