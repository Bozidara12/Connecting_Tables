using MySql.Data.MySqlClient;

namespace Connection_Tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr = "server=10.6.0.127;" +
            "port=3306;" +
            "user=PC1;" +
            "password=1111;" +
            "database=trees_zaimov";
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connect=new MySqlConnection(connstr);
            if (connect.State==0) connect.Open();
            MessageBox.Show("Connection now opened!");
        }
    }
}
