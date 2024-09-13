using System.Data;
using System.Data.SqlClient;

namespace DisconnectedDB_Demo
{
    public partial class Form1 : Form

    {
        DataSet dataSet;
        SqlDataAdapter adapter = new SqlDataAdapter("select * from slot", "server=.\\SQLEXPRESS;initial catalog=bookmyslot;User ID=sa;Password=Pass@123;TrustServerCertificate=true");
        DataTable dt;

        public Form1()
        {
            InitializeComponent();

            dataSet = new DataSet();
            dt=dataSet.Tables[0];

            dt.PrimaryKey = new[] { dt.Columns["id"] };
            SqlCommandBuilder commandbuilder = new SqlCommandBuilder(adapter);


            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = dataSet.Tables[0];
            DataRow row = dt.NewRow();
            row["starttime"] = "19:00";
            row["endtime"] = "12:20";
            row[2] = DateTime.Now;
            dt.Rows.Add(row);
            adapter.Update(dt);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow row = dt.Rows.Find("12:20");
            dt.Rows[0].Delete();
            adapter.Update(dt);
        }
    }

}
