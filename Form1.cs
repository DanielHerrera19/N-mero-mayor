namespace numeros_de_mayor_a_menor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Num1TextBox.Text);
            int num2 = int.Parse(Num2TextBox.Text);
            int num3 = int.Parse(Num3TextBox.Text);

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                int mayor = num1;

                if (num2 > mayor)
                {
                    mayor = num2;
                }

                if (num3 > mayor)
                {
                    mayor = num3;
                }

                ResultLabel.Text = $"El mayor n�mero es: {mayor}";
            }
            else
            {
                ResultLabel.Text = "Los n�meros deben ser diferentes";
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}