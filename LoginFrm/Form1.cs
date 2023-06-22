namespace LoginFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
            Math.Abs(-1);
            Console.WriteLine("Git");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See Git");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Dev Branch");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ganme Over");
        }
    }
}