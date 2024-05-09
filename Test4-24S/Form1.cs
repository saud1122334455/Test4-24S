namespace Test4_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string t1 = textBox2.Text;
            string t2 = textBox3.Text;
            string t3 = textBox4.Text;
            string t4 = textBox5.Text;
            textBox2.Text = text;
            textBox3.Text = t1;
            textBox4.Text = t2;
            textBox5.Text = t3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            textBox1.Text = s;
            textBox2.Text = s;
            textBox3.Text = s;
            textBox4.Text = s;
            textBox5.Text = s;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
