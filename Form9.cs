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
    public partial class Form9 : Form
    {
       
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tt = new Model1() { })
            {
                int code = int.Parse(textBox1.Text);
                Professor pro = tt.Professor.FirstOrDefault(x => x.codeProfessor == code);
                tt.Professor.Remove(pro);
                tt.SaveChanges();

            }

            MessageBox.Show("استاد حذف شد");
         
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int code = int.Parse(textBox1.Text);
            using (Model1 tt = new Model1())
            {

                Professor pro = tt.Professor.FirstOrDefault(x => x.codeProfessor == code);


                textBox2.Text = pro.nameprofessor;
                textBox3.Text = pro.lastnameprofessor;
                textBox4.Text = pro.Idprofessor.ToString();
                textBox5.Text = pro.fathername;
                textBox6.Text = pro.birthday;
                textBox7.Text = pro.Crosssection;

            }
        }
    }
}
