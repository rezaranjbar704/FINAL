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
    public partial class Form12 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form12()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


            SqlConnection Connection = new SqlConnection("Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True");
            // Connection.ConnectionString = "Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True";

            string insertsql = "INSERT INTO Selectunit VALUES (@codestdent , @codelesson , @namelesso , @course , @codeProfessor , @startdate , @examday , @field) ";
            string selectsql = "Select * FROM Selectunit   " ;
            string selectWhereClause = "WHERE codestdent = @codestdent ";

            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = selectsql;


            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                selectsql += selectWhereClause;
                Command.Parameters.Clear();
                SqlParameter Selectunitcode = new SqlParameter("codestdent", textBox1.Text);
                Command.Parameters.Add(Selectunitcode);
            }



            DataTable table = new DataTable();

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = Command;

            adapter.Fill(table);

            Connection.Close();



            dataGridView1.DataSource = table;





        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var tt = new Model1())
            {
                var se = new Selectunit() { codestdent = int.Parse(textBox1.Text), codelesson = int.Parse(textBox5.Text), namelesso = textBox6.Text, course = textBox7.Text, codeProfessor = int.Parse(textBox8.Text), startdate = textBox9.Text, examday = textBox10.Text, field = textBox11.Text };
                tt.Selectunit.Add(se);
                tt.SaveChanges();

            }
            MessageBox.Show("درس ثبت شد");
            this.Hide();
            Form12 f12 = new Form12();
            f12.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            string codelesson = textBox5.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Selectunit where codelesson ='" + codelesson + "' ";

            cmd.ExecuteNonQuery();
            MessageBox.Show("درس حذف شد");
            con.Close();
            this.Hide();
            Form12 f12 =new Form12();
            f12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int code = int.Parse(textBox5.Text);
            using (Model1 tt = new Model1())
            {

                Lesson les = tt.Lesson.FirstOrDefault(x => x.codelesson == code);


                textBox6.Text = les.namelesso;
                textBox7.Text = les.course;
                textBox8.Text = les.codeProfessor.ToString();
                textBox9.Text = les.startdate;
                textBox10.Text = les.examday;
                textBox11.Text = les.field;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int code = int.Parse(textBox1.Text);
            using (Model1 tt = new Model1())
            {

                student les = tt.student.FirstOrDefault(x => x.codestdent == code);


                textBox2.Text = les.namestudent;
                textBox3.Text = les.lastnamestudent;
                textBox4.Text = les.field;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
