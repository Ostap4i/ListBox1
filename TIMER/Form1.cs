namespace TIMER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            listBox1.Items.Add(str);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            listBox1.Items.Remove(str);
        }
    }
}