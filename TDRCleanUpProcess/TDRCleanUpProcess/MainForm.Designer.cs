namespace TDRCleanUpProcess
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.validate_button = new System.Windows.Forms.Button();
            this.cleanup_button = new System.Windows.Forms.Button();
            this.information_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ref_textBox1 = new System.Windows.Forms.TextBox();
            this.ref_label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.env_label3 = new System.Windows.Forms.Label();
            this.env_textBox3 = new System.Windows.Forms.TextBox();
            this.own_label2 = new System.Windows.Forms.Label();
            this.own_textBox2 = new System.Windows.Forms.TextBox();
            this.formatzeros_checkBox3 = new System.Windows.Forms.CheckBox();
            this.generateremit_checkBox2 = new System.Windows.Forms.CheckBox();
            this.complete_checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorlogs_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.information_dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorlogs_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 150);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(443, 72);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(188, 33);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search ID(s)";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(442, 111);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(189, 33);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // validate_button
            // 
            this.validate_button.Location = new System.Drawing.Point(442, 150);
            this.validate_button.Name = "validate_button";
            this.validate_button.Size = new System.Drawing.Size(189, 33);
            this.validate_button.TabIndex = 4;
            this.validate_button.Text = "Validate Payment Clean-up";
            this.validate_button.UseVisualStyleBackColor = true;
            this.validate_button.Click += new System.EventHandler(this.validate_button_Click);
            // 
            // cleanup_button
            // 
            this.cleanup_button.Location = new System.Drawing.Point(442, 189);
            this.cleanup_button.Name = "cleanup_button";
            this.cleanup_button.Size = new System.Drawing.Size(189, 33);
            this.cleanup_button.TabIndex = 5;
            this.cleanup_button.Text = "Payment Clean-up";
            this.cleanup_button.UseVisualStyleBackColor = true;
            this.cleanup_button.Click += new System.EventHandler(this.cleanup_button_Click);
            // 
            // information_dataGridView1
            // 
            this.information_dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.information_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.information_dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.information_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.information_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.information_dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.information_dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.information_dataGridView1.Name = "information_dataGridView1";
            this.information_dataGridView1.Size = new System.Drawing.Size(1036, 204);
            this.information_dataGridView1.TabIndex = 6;
            // 
            // ref_textBox1
            // 
            this.ref_textBox1.Location = new System.Drawing.Point(142, 28);
            this.ref_textBox1.Name = "ref_textBox1";
            this.ref_textBox1.Size = new System.Drawing.Size(266, 20);
            this.ref_textBox1.TabIndex = 7;
            // 
            // ref_label1
            // 
            this.ref_label1.AutoSize = true;
            this.ref_label1.Location = new System.Drawing.Point(24, 31);
            this.ref_label1.Name = "ref_label1";
            this.ref_label1.Size = new System.Drawing.Size(100, 13);
            this.ref_label1.TabIndex = 8;
            this.ref_label1.Text = "Reference Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.env_label3);
            this.groupBox1.Controls.Add(this.env_textBox3);
            this.groupBox1.Controls.Add(this.own_label2);
            this.groupBox1.Controls.Add(this.own_textBox2);
            this.groupBox1.Controls.Add(this.formatzeros_checkBox3);
            this.groupBox1.Controls.Add(this.generateremit_checkBox2);
            this.groupBox1.Controls.Add(this.complete_checkBox1);
            this.groupBox1.Controls.Add(this.ref_textBox1);
            this.groupBox1.Controls.Add(this.ref_label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(652, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 191);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            // 
            // env_label3
            // 
            this.env_label3.AutoSize = true;
            this.env_label3.Location = new System.Drawing.Point(55, 57);
            this.env_label3.Name = "env_label3";
            this.env_label3.Size = new System.Drawing.Size(69, 13);
            this.env_label3.TabIndex = 15;
            this.env_label3.Text = "Environment:";
            // 
            // env_textBox3
            // 
            this.env_textBox3.Location = new System.Drawing.Point(142, 54);
            this.env_textBox3.Name = "env_textBox3";
            this.env_textBox3.Size = new System.Drawing.Size(266, 20);
            this.env_textBox3.TabIndex = 14;
            // 
            // own_label2
            // 
            this.own_label2.AutoSize = true;
            this.own_label2.Location = new System.Drawing.Point(62, 83);
            this.own_label2.Name = "own_label2";
            this.own_label2.Size = new System.Drawing.Size(62, 13);
            this.own_label2.TabIndex = 13;
            this.own_label2.Text = "Owner Key:";
            // 
            // own_textBox2
            // 
            this.own_textBox2.Location = new System.Drawing.Point(142, 80);
            this.own_textBox2.Name = "own_textBox2";
            this.own_textBox2.Size = new System.Drawing.Size(266, 20);
            this.own_textBox2.TabIndex = 12;
            // 
            // formatzeros_checkBox3
            // 
            this.formatzeros_checkBox3.AutoSize = true;
            this.formatzeros_checkBox3.Location = new System.Drawing.Point(27, 158);
            this.formatzeros_checkBox3.Name = "formatzeros_checkBox3";
            this.formatzeros_checkBox3.Size = new System.Drawing.Size(148, 17);
            this.formatzeros_checkBox3.TabIndex = 11;
            this.formatzeros_checkBox3.Text = "Format of the key at zeros";
            this.formatzeros_checkBox3.UseVisualStyleBackColor = true;
            // 
            // generateremit_checkBox2
            // 
            this.generateremit_checkBox2.AutoSize = true;
            this.generateremit_checkBox2.Location = new System.Drawing.Point(27, 135);
            this.generateremit_checkBox2.Name = "generateremit_checkBox2";
            this.generateremit_checkBox2.Size = new System.Drawing.Size(168, 17);
            this.generateremit_checkBox2.TabIndex = 10;
            this.generateremit_checkBox2.Text = "Generate Remittance Advices";
            this.generateremit_checkBox2.UseVisualStyleBackColor = true;
            // 
            // complete_checkBox1
            // 
            this.complete_checkBox1.AutoSize = true;
            this.complete_checkBox1.Location = new System.Drawing.Point(27, 112);
            this.complete_checkBox1.Name = "complete_checkBox1";
            this.complete_checkBox1.Size = new System.Drawing.Size(132, 17);
            this.complete_checkBox1.TabIndex = 9;
            this.complete_checkBox1.Text = "Complete Invoice Only";
            this.complete_checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 241);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 239);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.information_dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errorlogs_dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1045, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Error Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorlogs_dataGridView1
            // 
            this.errorlogs_dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorlogs_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.errorlogs_dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.errorlogs_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.errorlogs_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.errorlogs_dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.errorlogs_dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.errorlogs_dataGridView1.Name = "errorlogs_dataGridView1";
            this.errorlogs_dataGridView1.Size = new System.Drawing.Size(1036, 204);
            this.errorlogs_dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Environment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1078, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cleanup_button);
            this.Controls.Add(this.validate_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Clean-up Process";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.information_dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorlogs_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button validate_button;
        private System.Windows.Forms.Button cleanup_button;
        private System.Windows.Forms.DataGridView information_dataGridView1;
        private System.Windows.Forms.TextBox ref_textBox1;
        private System.Windows.Forms.Label ref_label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox formatzeros_checkBox3;
        private System.Windows.Forms.CheckBox generateremit_checkBox2;
        private System.Windows.Forms.CheckBox complete_checkBox1;
        private System.Windows.Forms.Label own_label2;
        private System.Windows.Forms.TextBox own_textBox2;
        private System.Windows.Forms.Label env_label3;
        private System.Windows.Forms.TextBox env_textBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView errorlogs_dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

