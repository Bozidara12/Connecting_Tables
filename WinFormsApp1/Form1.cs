namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_MouseDown(object sender, MouseEventArgs e)
        {
            lblResult.Text = "MouseDown";
        }

        private void txt1_MouseEnter(object sender, EventArgs e)
        {
            lblResult.Text = "MouseEnter";
        }

        private void txt1_MouseLeave(object sender, EventArgs e)
        {
            lblResult.Text = "MouseLeve";
        }

        private void txt1_MouseUp(object sender, MouseEventArgs e)
        {
            lblResult.Text = "MouseUp";
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
