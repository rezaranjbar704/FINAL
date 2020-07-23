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
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("کد درس را وارد کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("   نام درس را وارد کنید");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("   واحد درس را وارد کنید");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("   کد استاد را وارد کنید");
            }
           
            else if (textBox7.Text == "")
            {
                MessageBox.Show("   رشته تحصیلی  را وارد کنید");
            }
            else
            {

                using (var tt = new Model1())
                {
                    var le = new Lesson() { codelesson = int.Parse(textBox1.Text), namelesso = textBox2.Text, course = textBox3.Text , codeProfessor = int.Parse( textBox4.Text ) , startdate = textBox5.Text , examday = textBox6.Text , field = textBox7.Text };
                    tt.Lesson.Add(le);
                    tt.SaveChanges();

                }
                MessageBox.Show("درس ثبت شد");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
