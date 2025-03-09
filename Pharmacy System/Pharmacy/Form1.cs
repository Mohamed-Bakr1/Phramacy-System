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
using SharedLibrary;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Done_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True"))
            {
                string name = MedicineBox.Text;
                int quantity = int.Parse(QuantityBox.Text);
                //object c1=Form1.Empnum;

                using (SqlCommand cmd = new SqlCommand("SELECT Quantity, MedicineID FROM Medicine WHERE Name = @Name", con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int availableQuantity = (int)reader["Quantity"];
                        int medicineID = (int)reader["MedicineID"];

                        if (quantity <= availableQuantity)
                        {
                            // Update Medicine table
                            reader.Close();
                            using (SqlCommand updateCmd = new SqlCommand("UPDATE Medicine SET Quantity = Quantity - @Quantity WHERE Name = @Name", con))
                            {
                                updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                                updateCmd.Parameters.AddWithValue("@Name", name);

                                updateCmd.ExecuteNonQuery();
                            }
                            string empnum = (string)Class1.Empnum;
                            // Insert Sale record
                            using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Sale (Quantity, SaleDate, MedicineID,EmployeeID) VALUES (@Quantity, @SaleDate, @MedicineID, @EmployeeID)", con))
                            {
                                insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                                insertCmd.Parameters.AddWithValue("@MedicineID", medicineID);
                                insertCmd.Parameters.AddWithValue("@EmployeeID", empnum);

                                insertCmd.ExecuteNonQuery();
                                
                            }

                            MessageBox.Show("Quantity updated and sale recorded successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Insufficient quantity.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Medicine does not exist.");
                    }
                }
            }
        }

        private void Add_Info_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer (Name, ContactNumber, Address) VALUES (@Name, @ContactNumber, @Address)", con))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Name", CusmterNameBox.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactBox.Text);
                    cmd.Parameters.AddWithValue("@Address", PersIDbox.Text);

                    MessageBox.Show("add successfully");

                    // Execute the command
                    con.Open();  // Open the connection
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
