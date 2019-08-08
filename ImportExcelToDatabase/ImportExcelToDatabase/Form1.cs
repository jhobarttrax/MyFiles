using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ImportExcelToDatabase
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        private void selectFile_button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string header = radioButton1.Checked ? "YES" : "NO";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString(); // Select which tab will be looked up.
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        //Populate DataGridView.
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void import_button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new System.Data.SqlClient.SqlConnection();
                con = new System.Data.SqlClient.SqlConnection();
                con.ConnectionString = "Data Source=AppleAsiaProdSQL.traxtech.com;Initial Catalog=Apasia_Prod_02M12;Trusted_Connection=True";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();

                for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
                {

                    String insertData = "INSERT INTO dbo.AppleAPACInvoicesToBeClosedPaid(INV_ID, INV_KEY, CHECK_NUM, PAID_AMOUNT, PAID_DATE) " +
                                        "VALUES (@traxinvid, @invkey, @paymentnumber, @paidamount, @paymentdate)";
                    SqlCommand cmd = new SqlCommand(insertData, con);
                    //cmd.Parameters.AddWithValue("@scac", dataGridView1.Rows[i].Cells[0].Value);
                    //cmd.Parameters.AddWithValue("@scac", dataGridView1.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@traxinvid", dataGridView1.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@invkey", dataGridView1.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@paymentnumber", dataGridView1.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@paidamount", dataGridView1.Rows[i].Cells[3].Value);
                    //cmd.Parameters.AddWithValue("@paymentcurrency", dataGridView1.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@paymentdate", dataGridView1.Rows[i].Cells[4].Value);
                    //cmd.Parameters.AddWithValue("@submittedby", dataGridView1.Rows[i].Cells[7].Value);
                    //cmd.Parameters.AddWithValue("@comment", dataGridView1.Rows[i].Cells[8].Value);
                    da.InsertCommand = cmd;
                    cmd.ExecuteNonQuery();
                }
                con.Close();

                string msg = "Records have been imported.";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(msg, caption, buttons, icon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
