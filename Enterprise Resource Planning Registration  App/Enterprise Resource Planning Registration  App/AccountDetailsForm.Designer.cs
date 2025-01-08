namespace Enterprise_Resource_Planning_Registration__App
{
    partial class AccountDetailsForm
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
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSalary = new TextBox();
            label6 = new Label();
            txtIFSCCode = new TextBox();
            label5 = new Label();
            txtAccountNumber = new TextBox();
            label4 = new Label();
            txtBankName = new TextBox();
            label3 = new Label();
            btnClear = new Button();
            btnSavenext = new Button();
            txtPAN = new TextBox();
            label7 = new Label();
            txtAadhaar = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MingLiU-ExtB", 19F, FontStyle.Italic);
            label2.Location = new Point(8, 63);
            label2.Name = "label2";
            label2.Size = new Size(798, 32);
            label2.TabIndex = 5;
            label2.Text = "*************************************************";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(815, 37);
            label1.TabIndex = 4;
            label1.Text = "Enterprise Resource Planning Registration ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Ivory;
            groupBox1.Controls.Add(txtAadhaar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPAN);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtIFSCCode);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAccountNumber);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBankName);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(12, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 507);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Information";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(197, 281);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(285, 52);
            txtSalary.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 284);
            label6.Name = "label6";
            label6.Size = new Size(169, 37);
            label6.TabIndex = 6;
            label6.Text = "Salary :";
            // 
            // txtIFSCCode
            // 
            txtIFSCCode.Location = new Point(268, 210);
            txtIFSCCode.Name = "txtIFSCCode";
            txtIFSCCode.Size = new Size(285, 52);
            txtIFSCCode.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 213);
            label5.Name = "label5";
            label5.Size = new Size(226, 37);
            label5.TabIndex = 4;
            label5.Text = "IFSC Code :";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(349, 134);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(417, 52);
            txtAccountNumber.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 137);
            label4.Name = "label4";
            label4.Size = new Size(321, 37);
            label4.TabIndex = 2;
            label4.Text = "Account Number :";
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(268, 59);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(417, 52);
            txtBankName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 62);
            label3.Name = "label3";
            label3.Size = new Size(226, 37);
            label3.TabIndex = 0;
            label3.Text = "Bank Name :";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(481, 632);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 57);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSavenext
            // 
            btnSavenext.BackColor = Color.Lime;
            btnSavenext.Location = new Point(214, 632);
            btnSavenext.Name = "btnSavenext";
            btnSavenext.Size = new Size(206, 57);
            btnSavenext.TabIndex = 7;
            btnSavenext.Text = "Save/Next";
            btnSavenext.UseVisualStyleBackColor = false;
            btnSavenext.Click += btnSavenext_Click;
            // 
            // txtPAN
            // 
            txtPAN.Location = new Point(235, 349);
            txtPAN.Name = "txtPAN";
            txtPAN.Size = new Size(355, 52);
            txtPAN.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 352);
            label7.Name = "label7";
            label7.Size = new Size(207, 37);
            label7.TabIndex = 8;
            label7.Text = "Pan Card :";
            // 
            // txtAadhaar
            // 
            txtAadhaar.Location = new Point(311, 422);
            txtAadhaar.Name = "txtAadhaar";
            txtAadhaar.Size = new Size(374, 52);
            txtAadhaar.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 425);
            label8.Name = "label8";
            label8.Size = new Size(283, 37);
            label8.TabIndex = 10;
            label8.Text = "Aadhaar Card :";
            // 
            // AccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(818, 701);
            Controls.Add(btnClear);
            Controls.Add(btnSavenext);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MingLiU-ExtB", 22.2F, FontStyle.Italic);
            Margin = new Padding(7, 6, 7, 6);
            Name = "AccountDetailsForm";
            Text = "AccountDetailsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAccountNumber;
        private Label label4;
        private TextBox txtBankName;
        private Label label3;
        private TextBox txtIFSCCode;
        private Label label5;
        private TextBox txtSalary;
        private Label label6;
        private Button btnClear;
        private Button btnSavenext;
        private TextBox txtAadhaar;
        private Label label8;
        private TextBox txtPAN;
        private Label label7;
    }
}