using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr = "server=10.42.41.221;" +
            "port=3306;" +
            "user=PC1;" +
            "password=1111;" +
            "database=minions";

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection new opened!");

            MySqlCommand query = new MySqlCommand("select*from towns", connect);
            MySqlDataReader readerCombo = query.ExecuteReader();

            List<ComboBoxItem> items = new List<ComboBoxItem>();
            while (readerCombo.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = readerCombo[1].ToString();
                item.Value = (int)readerCombo[0];

                items.Add(item);
            }
            cmb1.DataSource = items;
            cmb1.DisplayMember = "Text";
            cmb1.ValueMember = "value";

            readerCombo.Close();
            connect.Close();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Minion {txt1.Text} e na {txt2.Text} i e ot grad {cmb1.SelectedValue}");
            string insertSQL = "INSERT INTO minions.minions" +
               "(id,`name`,age,town_id) " +
               $"VALUES(123,@name,@age,@town_id)";
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();

            MySqlCommand query = new MySqlCommand(insertSQL, connect);

            query.Parameters.AddWithValue("@name", txt1.Text);
            query.Parameters.AddWithValue("@age", txt2.Text);
            query.Parameters.AddWithValue("@town_id", cmb1.SelectedValue);

            query.ExecuteNonQuery();
            connect.Close();


            string SQL = "UPDATE minions SET Name=@name,Age=@age,TownId=@townId" +
                "WHERE id=@id";

            MySqlDataReader readerCombo = query.ExecuteReader();

            

            query = new MySqlCommand(SQL, connect);
            query.Parameters.AddWithValue("@name", txt1.Text);
            query.Parameters.AddWithValue("age", txt2.Text);
            query.Parameters.AddWithValue("@town_id", cmb1.SelectedValue);

            query.ExecuteNonQuery();
            connect.Close();

        }
    }
}
