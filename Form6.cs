using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;



        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "")
            {
                MessageBox.Show("کد استاد را وارد کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("   نام را وارد کنید");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("   نام خانوادگی را وارد کنید");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("   کد ملی را وارد کنید");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("   نام پدر را وارد کنید");
            }
           
            else if (textBox7.Text == "")
            {
                MessageBox.Show("   مقطع را وارد کنید");
            }
            else
            {
                using (var tt = new Model1())
                {
                    var pr = new Professor() { codeProfessor = int.Parse(textBox1.Text) , nameprofessor = textBox2.Text , lastnameprofessor = textBox3.Text , Idprofessor = int.Parse(textBox4.Text) , fathername = textBox5.Text ,birthday = textBox6.Text , Crosssection = textBox7.Text };
                    tt.Professor.Add(pr);
                    tt.SaveChanges();

                }
                MessageBox.Show("استاد ثبت شد");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }
    }
}
