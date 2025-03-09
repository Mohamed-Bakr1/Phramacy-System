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
using Pharmacy;
using SharedLibrary;

namespace From2
{
    public partial class Form2 : Form
    {
        //public static object Empnum;
        public Form2()
        {
            InitializeComponent();
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True;Trust Server Certificate=True");


            SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from employee where [User Name] = '" + UserBox.Text + "' and Password = '" + PassBox.Text + "'", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                dr.Close(); // Close the first reader before executing another command

                // Retrieve the EmployeeID
                SqlCommand cmd1 = new SqlCommand("SELECT EmployeeID FROM employee WHERE [User Name] = @UserName AND Password = @Password", con);
                cmd1.Parameters.AddWithValue("@UserName", UserBox.Text);
                cmd1.Parameters.AddWithValue("@Password", PassBox.Text);

                SqlDataReader dr2 = cmd1.ExecuteReader();
                if (dr2.Read())
                {
                    Class1.Empnum = dr2["EmployeeID"]; // Assign EmployeeID
                }
                dr2.Close();

            }
            else
            {
                MessageBox.Show("invalide User Name or Password");
            }
            con.Close();
        }
    }
}
