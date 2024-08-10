using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{//---------------------------PROBLEM 2----Composite pattern for adding customers and saving every customer's information that is not available for everybodybut only for receptionist
    // Component interface
    public interface ICustomer
    {
        void AddCustomer(string name, string cnic, string phone);
    }

    // Leaf class
    public class Customer : ICustomer
    {

        public void AddCustomer(string name, string cnic, string phone)
        {
            
          //  MessageBox.Show($"Customer name: {name}, CNIC: {cnic}, Phone-No: {phone}");
        }
    }

    // Composite class
    public sealed class Receptionist : ICustomer
         
    {
       
        //----------PROBLEM3----- Receptionist can search for 1 customer at a time and can add customer one at a time aik waqt mai 2 kaam nahi karega
        private static Receptionist instance;
        private static int counter = 0;
        // Private constructor to prevent instantiation outside of the class
        private Receptionist()
        {
            counter++;
            MessageBox.Show("counter value of Receptionist Instance " + counter.ToString());
            
        }
        public static Receptionist GetInstance()
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {

                instance = new Receptionist();
            }

            // Return the singleton instance
            return instance;
        }
        public void search(string phone) 
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Booking WHERE Phone = @Phone";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Read the first row
                        reader.Read();

                        // Get customer information
                        string customerName = reader["Name"].ToString();
                        string Roomno = reader["RoomNumber"].ToString();
                        string customerPhone = reader["Phone"].ToString();

                        // Display customer information in a message box
                        MessageBox.Show($"Customer Information:\nName: {customerName}\nRoomNumber: {Roomno}\nPhone: {customerPhone}", "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
                    }

                    reader.Close();
                    con.Close();
                }
            }
        }
        private string connectionString = "Data Source=DESKTOP-AIG1MD4\\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True";

        public void AddCustomer(string name, string cnic, string phone)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Insert customer data into the database
                string query = "insert into Customer (Name, CNIC, Phone) VALUES (@Name, @CNIC, @Phone)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@CNIC", cnic);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully by receptionist");
                    con.Close();
                }

            }

        }
    }
}