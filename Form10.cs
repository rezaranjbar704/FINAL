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
    public partial class Form10 : Form
    {
       
        public Form10()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                using (var tt = new Model1())
                {
                    var gr = new Grading() { codestdent = int.Parse(textBox2.Text) , codelesson = int.Parse(textBox3.Text) , grade = textBox4.Text };
                    tt.Grading.Add(gr);
                    tt.SaveChanges();

                }
                MessageBox.Show("  نمره این درس دانشجو ثبت شد ");
               
            
        }
    }
}
