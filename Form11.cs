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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int code = int.Parse(textBox1.Text);
            using (Model1 tt = new Model1())
            {
                //student student = tt.student.Find(88);
                student stu = tt.student.FirstOrDefault(x => x.codestdent == code);


                textBox2.Text = stu.namestudent;
                textBox3.Text = stu.lastnamestudent; 
                textBox7.Text = stu.field;

               

            }
            SqlConnection Connection = new SqlConnection("Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True");
           


            string selectsql = "Select * FROM Grading --WHERE codestdent  = @codestdent  ";

            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = selectsql;

            DataTable table = new DataTable();

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = Command;

            adapter.Fill(table);

            Connection.Close();



            dataGridView1.DataSource = table;

        }
    }
}
