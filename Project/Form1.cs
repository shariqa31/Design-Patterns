using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Project
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {

            ////PROBLEM1-- FACADE CLASS 
            Booking booking = new Booking();
            booking.createbooking(comboBox1.Text, custnametxt.Text, custcnictxt.Text, custphtxt.Text, comboBox2.Text, amounttxt.Text);
            MessageBox.Show("ROOM BOOKED. \n Customer name:" + custnametxt.Text + " \n CNIC:" + custcnictxt.Text + "\n Phone-No:" + custphtxt.Text + " \n ROOM NUMER:" + comboBox2.Text + " \n PAYMENT MODE:" + comboBox1.Text + " \n AMOUNT:" + amounttxt.Text);

        }

        private void custnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)

        {
           
            Booking booking = new Booking();
            booking.search_customer(searchtxt.Text);
        }
      
    }
}