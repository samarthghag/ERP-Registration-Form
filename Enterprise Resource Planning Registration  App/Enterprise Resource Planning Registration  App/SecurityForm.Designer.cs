namespace Enterprise_Resource_Planning_Registration__App
{
    partial class SecurityForm
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtSecAns = new TextBox();
            label6 = new Label();
            cmbSecQues = new ComboBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            btnClear = new Button();
            btnSavenext = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(815, 37);
            label1.TabIndex = 0;
            label1.Text = "Enterprise Resource Planning Registration ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MingLiU-ExtB", 19F, FontStyle.Italic);
            label2.Location = new Point(30, 57);
            label2.Name = "label2";
            label2.Size = new Size(798, 32);
            label2.TabIndex = 6;
            label2.Text = "*************************************************";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(txtSecAns);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbSecQues);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(809, 385);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Security Infromation";
            // 
            // txtSecAns
            // 
            txtSecAns.Location = new Point(201, 286);
            txtSecAns.Name = "txtSecAns";
            txtSecAns.Size = new Size(571, 52);
            txtSecAns.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 289);
            label6.Name = "label6";
            label6.Size = new Size(169, 37);
            label6.TabIndex = 6;
            label6.Text = "Answer :";
            // 
            // cmbSecQues
            // 
            cmbSecQues.FormattingEnabled = true;
            cmbSecQues.Location = new Point(372, 216);
            cmbSecQues.Name = "cmbSecQues";
            cmbSecQues.Size = new Size(431, 45);
            cmbSecQues.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 219);
            label5.Name = "label5";
            label5.Size = new Size(378, 37);
            label5.TabIndex = 4;
            label5.Text = "Security Question :";
            label5.Click += label5_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(258, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(385, 52);
            txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 141);
            label4.Name = "label4";
            label4.Size = new Size(207, 37);
            label4.TabIndex = 2;
            label4.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(258, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(369, 52);
            txtUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 60);
            label3.Name = "label3";
            label3.Size = new Size(226, 37);
            label3.TabIndex = 0;
            label3.Text = "User Name :";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(466, 515);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 57);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSavenext
            // 
            btnSavenext.BackColor = Color.Lime;
            btnSavenext.Location = new Point(199, 515);
            btnSavenext.Name = "btnSavenext";
            btnSavenext.Size = new Size(206, 57);
            btnSavenext.TabIndex = 9;
            btnSavenext.Text = "Save/Next";
            btnSavenext.UseVisualStyleBackColor = false;
            btnSavenext.Click += btnSavenext_Click;
            // 
            // SecurityForm
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(840, 579);
            Controls.Add(btnClear);
            Controls.Add(btnSavenext);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MingLiU-ExtB", 22.2F, FontStyle.Italic);
            Margin = new Padding(7, 6, 7, 6);
            Name = "SecurityForm";
            Text = "SecurityForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private ComboBox cmbSecQues;
        private Label label5;
        private TextBox txtSecAns;
        private Label label6;
        private Button btnClear;
        private Button btnSavenext;
    }
}