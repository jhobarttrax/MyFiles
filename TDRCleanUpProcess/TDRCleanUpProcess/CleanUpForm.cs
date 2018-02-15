using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TDRCleanUpProcess
{
    public partial class CleanUpForm : Form
    {
        string sReference;
        string sOwnerkey;
        string sComplete;
        string sGenerateremit;
        string sFormatzeros;

        public CleanUpForm(string refer, string own, string comp, string gen, string form)
        {
            InitializeComponent();

            sReference = refer;
            sOwnerkey = own;
            sComplete = comp;
            sGenerateremit = gen;
            sFormatzeros = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=appleemeaprodsql.traxtech.com; Initial Catalog=Aeur_Prod_02M5; Trusted_Connection=True");
                string sqlStringQuery = "select INV_ID, INV_KEY, INV_FB_CNT, INV_APP_AMT, VEND_LABL, INV_CURRENCY_QUAL, DENIAL_REASON from [Payments].[Payment_Cleanup_FB_List]" +
                                        " group by INV_ID, INV_KEY, INV_FB_CNT, INV_APP_AMT, VEND_LABL, INV_CURRENCY_QUAL, DENIAL_REASON";
                string sqlUpdate = "update [Payments].[Payment_Cleanup_FB_List] set DENIAL_REASON = '" + sReference + "'";

                SqlCommand cmdQuery = new SqlCommand(sqlUpdate, con);

                con.Open();

                cmdQuery.ExecuteNonQuery();
                SqlDataAdapter dsInfo = new SqlDataAdapter(sqlStringQuery, con);
                DataSet ds = new DataSet();

                dsInfo.Fill(ds, "FBList_table");

                if (dsInfo.Fill(ds) > 0)
                {
                    form2_dataGridView1.DataSource = ds;
                    form2_dataGridView1.DataMember = "FBList_table";
                }
                else
                {
                    string msg = "No matching records found.";
                    string caption = "";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(msg, caption, buttons, icon);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancel_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proceed_button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=appleemeaprodsql.traxtech.com; Initial Catalog=Aeur_Prod_02M5; Trusted_Connection=True");
                string execString = "exec [Payments].[usp_Payment_CleanupFB_Deny] '" + sOwnerkey + "', " + Convert.ToInt32(sComplete) + ", " + Convert.ToInt32(sGenerateremit) + ", " + Convert.ToInt32(sFormatzeros) + " ";

                SqlCommand execSproc = new SqlCommand(execString, con);

                con.Open();
                execSproc.ExecuteNonQuery();
                con.Close();

                string msg = "Submit Check created.";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(msg, caption, buttons, icon);

                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     }
}
