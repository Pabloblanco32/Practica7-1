namespace Practica7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, fahr1;
            v1 = double.Parse(textBox1.Text);
            fahr1 = v1 * (9.0 / 5.0) + 32;
            textBox2.Text = fahr1.ToString();
            label2.Text = " Fahrenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(textBox1.Text);
            cent1 = (v1 - 32) * (5.0 / 9.0);
            textBox2.Text = cent1.ToString();
            label2.Text = " Centigrados";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
