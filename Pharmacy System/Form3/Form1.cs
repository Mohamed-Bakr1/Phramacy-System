using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Medicine  where [Name] = '" + textBox1.Text + "'", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                using (SqlCommand cmd2 = new SqlCommand("UPDATE Medicine SET Quantity = @Quantity, Price = @Price WHERE Name = @textBox1.Text", con))
                {
                    cmd.Parameters.AddWithValue("@Quantity", "textBox3.Text");
                    cmd.Parameters.AddWithValue("@Price", "Price");

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (SqlCommand cmd1 = new SqlCommand("INSERT INTO Medicine (Name, Quantity, Price) VALUES (@Name, @Quantity, @Price)", con))
                {
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Price", textBox2.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
