using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadachaAnketa
{
    public partial class Form1 : Form
    {
        Person person1=new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           person1.Name = txt1.Text;
           if (chk1.Checked)
           {
               person1.Gender  = chk1.Text;
           }
            else
            {
               person1.Gender  = "Жена";
            }
            if (radioButton1.Checked)
            {
                person1.Eyas = radioButton1.Text;
            }
            if (radioButton2.Checked) 
            { 
                person1.Eyas = radioButton2.Text;  
            }
            if (radioButton3.Checked)
            {
                person1.Eyas = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                person1.Eyas = radioButton4.Text;
            }
            if(radioButton10.Checked)
            {
                person1.Eyas = radioButton10.Text;
            }
            if (radioButton9.Checked)
            {
                person1.Eyas = radioButton9.Text;
            }
            else
            {
                MessageBox.Show("Poleto cwqt na eyes e zadaljitelno");
            }
            if (radioButton5.Checked) 
            {
                person1.Hair = radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                person1.Hair = radioButton6.Text;
            }
            if (radioButton7.Checked)
            {
                person1.Hair = radioButton7.Text;
            }
            else
            {
                MessageBox.Show("Poleto cvqt na hair e zadaljitelno");
            }



             MessageBox.Show($"Ти си {person1.Name}=>{person1.Gender}.\n"+
                 $"с очи {person1.Eyas} и коса {person1.Hair}");



        }
    }
}
