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

namespace windowsform
{
    public partial class SlotForm : Form
    {
        SqlConnection conn = new SqlConnection();
        public SlotForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();

            conn.ConnectionString = "server=.\\SQLEXPRESS;initial catalog=bookmyslot;User ID=sa;Password=Pass@123;TrustServerCertificate=true";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@stime", txtStartTime.Text);
            cmd.Parameters.AddWithValue("@etime", txtEndTime.Text);
            cmd.Parameters.AddWithValue("@sdate", dateTimePicker1.Text);
            cmd.CommandText = "insert into slot values(@stime,@etime,@sdate)";
            

            conn.Open();
            cmd.ExecuteNonQuery();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = conn.CreateCommand();
            conn.ConnectionString = "server=.\\SQLEXPRESS;initial catalog=bookmyslot;User ID=sa;Password=Pass@123;TrustServerCertificate=true";
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM slot";

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtStartTime.Text = reader[0].ToString();
                txtEndTime.Text = reader[1].ToString();
                txtDatePick.Text = reader[2].ToString();
            }

            
        }

    }
}
