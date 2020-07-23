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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e )
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tt = new Model1() { })
            {
                int code = int.Parse(textBox1.Text);
                student stu = tt.student.FirstOrDefault(x => x.codestdent == code);
                tt.student.Remove(stu);
                tt.SaveChanges();

            }

            MessageBox.Show("دانشجو حذف شد");
            
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
                //student student = tt.student.Find(88);
                student stu = tt.student.FirstOrDefault(x => x.codestdent == code);


                textBox2.Text = stu.namestudent;
                textBox3.Text = stu.lastnamestudent;
                textBox4.Text = stu.Idstudent.ToString();
                textBox5.Text = stu.fathername;
                textBox6.Text = stu.birthday;
                textBox7.Text = stu.field;

            }

        }
    }
}
