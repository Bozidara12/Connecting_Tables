namespace IzvajdaneStepenuvaneDelenieSubirane
{
    public partial class Form1 : Form
    {
        double number1 = 0;
        double number2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName2_Click(object sender, EventArgs e)
        {

        }

        private void btnRazlika_Click(object sender, EventArgs e)
        {

            int result = 1;
            for (int i = 1; i <= (int)number1; i++)
            {
                result = result * i;
            }
            lblResult.Text = $"{(int)number1}!= {result}".ToString();
        }

        private void btn1_Leave(object sender, EventArgs e)
        {
            number1 = double.Parse(txtName2.Text);
        }

        private void btn2_Leave(object sender, EventArgs e)
        {
            number2 = double.Parse(txtName2.Text);
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{number1}*{number2}={number1 + number2}";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblResult.Text= $"{number1}-{number2}={number1 -number2}";
        }

    }
}
