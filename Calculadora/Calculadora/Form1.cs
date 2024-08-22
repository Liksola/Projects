namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultado.Text += "7";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultado.Text += "5";
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultado.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultado.Text += "0";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            resultado.Text = ",";
        }

        private void buttonIgualdade_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            resultado.Text = "+";
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            resultado.Text = "-";
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            resultado.Text = "*";
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            resultado.Text = "/";
        }
    }
}
