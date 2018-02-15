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
    public partial class MainForm : Form
    {
        string sOwnerkey;
        string sCompletebox;
        string sGenerateremitbox;
        string sFormatzerosbox;

        int iRecordsfound;

        public MainForm()
        {
            InitializeComponent();

            complete_checkBox1.Checked = true;
            formatzeros_checkBox3.Checked = true;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            {
                ref_textBox1.Clear();
                if (String.IsNullOrEmpty(richTextBox1.Text.Trim()))
                {
                    string msg = "Please input text.";
                    string caption = "";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(msg, caption, buttons, icon);
                    return;
                }

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=appleemeaprodsql.traxtech.com; Initial Catalog=Aeur_Prod_02M5; Trusted_Connection=True");
                    string sTruncate = "IF OBJECT_ID ('[Payments].[tbl_Payment_CleanupFB_Deny_IDs]') IS NOT NULL TRUNCATE TABLE [Payments].[tbl_Payment_CleanupFB_Deny_IDs]" +
                                    " ELSE CREATE TABLE [Payments].[tbl_Payment_CleanupFB_Deny_IDs] (ID VARCHAR(25))";

                    // This will remove all listed separators from input text.
                    string sSource = richTextBox1.Text.Trim();
                    string[] sSeparators = { "\n", ".", "/", " ", "\r", "\t", "," };
                    string[] words = sSource.Split(sSeparators, StringSplitOptions.RemoveEmptyEntries);

                    con.Open();
                    // This will truncate / create table so that we clean table every execute.
                    SqlCommand trnc = new SqlCommand(sTruncate, con);
                    trnc.ExecuteNonQuery();

                    // For loop of text arrays
                    for (var i = 0; i < words.Length; i++)
                    {
                        var lineValue = words[i];
                        string sQuery = "INSERT INTO [Payments].[tbl_Payment_CleanupFB_Deny_IDs] (ID) VALUES ('" + lineValue + "')";
                        SqlCommand cmd = new SqlCommand(sQuery, con);
                        cmd.ExecuteNonQuery();
                    }

                    // This will execute the sprocs and results will display
                    SqlCommand execSproc = new SqlCommand("[payments].[usp_Payment_CleanupFB_Deny_Information]", con);
                    string sqlStringQuery = "select INV_ID, FB_ID, INV_KEY, FB_KEY, BAT_ID, BAT_KEY, VEND_LABL, INV_CURRENCY_QUAL, INV_CREAT_DTM, INV_DUE_DTM, INV_PD_DTM, INV_FB_CNT, INV_AMT, INV_APP_AMT, FB_AMT, FB_APP_AMT, FB_ADJM_AMT, INV_STAT, FB_STAT, DENIAL_REASON from [Payments].[Payment_Cleanup_FB_List]";

                    SqlDataAdapter dsInfo = new SqlDataAdapter(sqlStringQuery, con);
                    DataSet ds = new DataSet();

                    execSproc.ExecuteNonQuery();
                    iRecordsfound = dsInfo.Fill(ds, "FBList_table");

                    if (iRecordsfound > 0)
                    {
                        information_dataGridView1.DataSource = ds;
                        information_dataGridView1.DataMember = "FBList_table";
                    }
                    else
                    {
                        string msg = "No matching records found.";
                        string caption = "";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Information;
                        MessageBox.Show(msg, caption, buttons, icon);
                    }

                    SqlCommand cmdEnv = new SqlCommand("select OWNER_NAME, OWNER_KEY from [Payments].[Payment_Cleanup_FB_List]", con);
                    SqlDataReader dReader;
                    dReader = cmdEnv.ExecuteReader();
                    
                    while (dReader.Read())
                    {
                        string sqlName = dReader.GetString(dReader.GetOrdinal("OWNER_NAME"));
                        string sqlOwner = dReader.GetString(dReader.GetOrdinal("OWNER_KEY"));

                        env_textBox3.Text = (dReader["OWNER_NAME"].ToString().ToUpper());
                        own_textBox2.Text = (dReader["OWNER_KEY"].ToString().ToUpper());
                    }

                    sOwnerkey = own_textBox2.Text;
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void validate_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(richTextBox1.Text.Trim()))
                {
                    string msg = "Please input text.";
                    string caption = "";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(msg, caption, buttons, icon);
                    return;
                }

                SqlConnection con = new SqlConnection("Data Source=appleemeaprodsql.traxtech.com; Initial Catalog=Aeur_Prod_02M5; Trusted_Connection=True");
                SqlCommand execSproc = new SqlCommand("[payments].[usp_Payment_CleanupFB_Deny_Validation]", con);
                string sqlErrorLogs = "select * from [payments].[tbl_payment_cleanupFB_failRI]";

                con.Open();
                execSproc.ExecuteNonQuery();
                SqlDataAdapter errInfo = new SqlDataAdapter(sqlErrorLogs, con);
                DataSet er = new DataSet();

                errInfo.Fill(er, "FailRI_Table");
                errorlogs_dataGridView1.DataSource = er;
                errorlogs_dataGridView1.DataMember = "FailRI_Table";

                if (errInfo.Fill(er) > 0)
                {
                    string msg = "Got an error validation. Please check the Error Logs tab for the information.";
                    string caption = "";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show(msg, caption, buttons, icon);
                }
                else if (iRecordsfound == 0)
                {
                    string msg = "No record(s) found.";
                        string caption = "";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Information;
                        MessageBox.Show(msg, caption, buttons, icon);
                }
                else
                {
                    string msg = "Bills are eligible for payment cleanup.";
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

        private void cleanup_button_Click(object sender, EventArgs e)
        {

            if (complete_checkBox1.Checked) { sCompletebox = "1"; } else { sCompletebox = "0"; }
            if (generateremit_checkBox2.Checked) { sGenerateremitbox = "1"; } else { sGenerateremitbox = "0"; }
            if (formatzeros_checkBox3.Checked) { sFormatzerosbox = "1"; } else { sFormatzerosbox = "0"; }

            if (String.IsNullOrEmpty(richTextBox1.Text.Trim()))
            {
                string msg = "Please input text.";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(msg, caption, buttons, icon);
                return;
            }
            else if (iRecordsfound == 0)
            {
                string msg = "No record(s) found.";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(msg, caption, buttons, icon);
            }
            else if (string.IsNullOrEmpty(ref_textBox1.Text))
            {
                string msg = "Please provide the reference number.";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(msg, caption, buttons, icon);
            }
            else
            {
                string sRef = ref_textBox1.Text;
                string sOwn = sOwnerkey;
                string iCom = sCompletebox;
                string iGen = sGenerateremitbox;
                string iFor = sFormatzerosbox;

                CleanUpForm newForm = new CleanUpForm(sRef, sOwn, iCom, iGen, iFor);
                newForm.ShowDialog();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.V)
                {
                    richTextBox1.SelectedText = Clipboard.GetText();
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
