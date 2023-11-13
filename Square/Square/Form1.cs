namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DisplaySquareOfNumbers();
            }

             void DisplaySquareOfNumbers()
            {
                textBox1.Clear();

                for (int i = 1; i <= 10; i++)
                {
                    int square = CalculateSquare(i);
                     textBox1.AppendText($"Square of {i}: {square}\r\n");
                }
            }

             int CalculateSquare(int number)
            {
                return number * number;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}