namespace TDRCleanUpProcess
{
    partial class CleanUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanUpForm));
            this.form2_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proceed_button1 = new System.Windows.Forms.Button();
            this.cancel_button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.form2_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // form2_dataGridView1
            // 
            this.form2_dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form2_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.form2_dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.form2_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form2_dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.form2_dataGridView1.Name = "form2_dataGridView1";
            this.form2_dataGridView1.Size = new System.Drawing.Size(801, 193);
            this.form2_dataGridView1.TabIndex = 0;
            // 
            // proceed_button1
            // 
            this.proceed_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.proceed_button1.Location = new System.Drawing.Point(489, 260);
            this.proceed_button1.Name = "proceed_button1";
            this.proceed_button1.Size = new System.Drawing.Size(159, 37);
            this.proceed_button1.TabIndex = 1;
            this.proceed_button1.Text = "PROCEED";
            this.proceed_button1.UseVisualStyleBackColor = true;
            this.proceed_button1.Click += new System.EventHandler(this.proceed_button1_Click);
            // 
            // cancel_button2
            // 
            this.cancel_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button2.Location = new System.Drawing.Point(654, 260);
            this.cancel_button2.Name = "cancel_button2";
            this.cancel_button2.Size = new System.Drawing.Size(159, 37);
            this.cancel_button2.TabIndex = 2;
            this.cancel_button2.Text = "CANCEL";
            this.cancel_button2.UseVisualStyleBackColor = true;
            this.cancel_button2.Click += new System.EventHandler(this.cancel_button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Summary Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CleanUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button2);
            this.Controls.Add(this.proceed_button1);
            this.Controls.Add(this.form2_dataGridView1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CleanUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary Information";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form2_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView form2_dataGridView1;
        private System.Windows.Forms.Button proceed_button1;
        private System.Windows.Forms.Button cancel_button2;
        private System.Windows.Forms.Label label1;
    }
}