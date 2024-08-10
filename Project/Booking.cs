using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
   
    public class Booking:Database
    {
      
        public void createbooking(string type,string cus_name,string cnic,string phone,string Rno,string amount)
        { 
        Room room = new Room();
            room.GetRoomNo(Rno);
            Customer c = new Customer();
          ///  c.GetCustomer(cus_name,cnic,phone);
            Payment payment = new Payment();
            payment.payment_method(type,amount);
            Receptionist receptionist = Receptionist.GetInstance();
          
            
            receptionist.AddCustomer(cus_name, cnic, phone);
           
            Invoice invoice = new Invoice();
            invoice.bill(amount);
            try
            {
                OpenConnection();

              
                // Insert booking data into the database
                string query = "INSERT INTO Booking (Type, Phone, Name, RoomNumber, Amount) " +
                               "VALUES (@Type, @Phone, @Name, @RoomNumber, @Amount)";

             //   MessageBox.Show("Customer Added Successfully");
                con.Close();
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@Type", type),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Name", cus_name),
                new SqlParameter("@RoomNumber", Rno),
                new SqlParameter("@Amount", amount)
                };

                ExecuteNonQuery(query, parameters);
                MessageBox.Show("Booking Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating booking: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
       
        

        }
        public void search_customer(string phone)
        {
            Receptionist receptionist = Receptionist.GetInstance();

            receptionist.search(phone);
        }
    }
   public class Room:Database
    {
        public void GetRoomNo(string Rno) {
            // MessageBox.Show( "ROOM NO IS :"+Rno);
            con.Open();

            // Insert room data into the database
            string query = "INSERT INTO Room (RoomNumber) VALUES (@RoomNumber)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RoomNumber", Rno);

                cmd.ExecuteNonQuery();
              //  MessageBox.Show("Room Added Successfully");
            }

        }
    }
   public  class Payment:Database
    {
        public void payment_method(string op, string amount) {
            if (op == "Creditcard")
            {
                MessageBox.Show ("paid using Credit card");
            }
            else
                MessageBox.Show("paid by cash");
            con.Open();

            // Insert payment data into the database
            string query = "INSERT INTO Payment ( PaymentType, PaymentAmount) VALUES (@PaymentType, @PaymentAmount)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
              ///  cmd.Parameters.AddWithValue("@BookingID", bookingID);
                cmd.Parameters.AddWithValue("@PaymentType", op);
                cmd.Parameters.AddWithValue("@PaymentAmount", amount);

                cmd.ExecuteNonQuery();
           //     MessageBox.Show("Payment Added Successfully");
            }

        }
    }
  public  class Invoice:Database
    {
        public void bill(string amount) {

            //  MessageBox.Show("total bill is:"+amount);
            con.Open();

            // Insert invoice data into the database
            string query = "INSERT INTO Invoice ( Amount) VALUES ( @Amount)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
               /// cmd.Parameters.AddWithValue("@BookingID", bookingID);
                cmd.Parameters.AddWithValue("@Amount", amount);

                cmd.ExecuteNonQuery();
           //     MessageBox.Show("Invoice Added Successfully");
            }
        }
    }
    
   
}
