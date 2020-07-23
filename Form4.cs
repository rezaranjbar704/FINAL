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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
                 
        }
       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text == "")
            {
                MessageBox.Show("شماره دانشجویی را وارد کنید");
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
                MessageBox.Show("   رشته تحصیلی  را وارد کنید");
            }
            else
            {
                using (var tt = new Model1())
                {
                    var stu = new student() { codestdent = int.Parse( textBox1.Text) , namestudent = textBox2.Text , lastnamestudent = textBox3.Text , Idstudent = int.Parse ( textBox4.Text) , fathername = textBox5.Text , birthday = textBox6.Text , field = textBox7.Text };
                    tt.student.Add(stu);
                    tt.SaveChanges();
                    
                }
                MessageBox.Show("دانشجو ثبت شد");
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
