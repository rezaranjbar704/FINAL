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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
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
                Lesson less = tt.Lesson.FirstOrDefault(x => x.codelesson == code);
                tt.Lesson.Remove(less);
                tt.SaveChanges();

            }


            MessageBox.Show("درس حذف شد");
            
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
               
                Lesson les = tt.Lesson.FirstOrDefault(x => x.codelesson == code);


                textBox2.Text = les.namelesso;
                textBox3.Text = les.course;
                textBox4.Text = les.codeProfessor.ToString();
                textBox5.Text = les.startdate;
                textBox6.Text = les.examday;
                textBox7.Text = les.field;

            }
        }
    }
}
