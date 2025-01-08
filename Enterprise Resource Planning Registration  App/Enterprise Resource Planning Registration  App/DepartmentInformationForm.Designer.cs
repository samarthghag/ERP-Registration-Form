namespace Enterprise_Resource_Planning_Registration__App
{
    partial class DepartmentInformationForm
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
            dtpJoiningDate = new DateTimePicker();
            label6 = new Label();
            txtEmployeeID = new TextBox();
            label5 = new Label();
            txtRole = new TextBox();
            label4 = new Label();
            txtDepartmentName = new TextBox();
            label3 = new Label();
            btnClear = new Button();
            btnSavenext = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MingLiU-ExtB", 19F, FontStyle.Italic);
            label2.Location = new Point(-2, 64);
            label2.Name = "label2";
            label2.Size = new Size(798, 32);
            label2.TabIndex = 3;
            label2.Text = "*************************************************";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 9);
            label1.Name = "label1";
            label1.Size = new Size(815, 37);
            label1.TabIndex = 2;
            label1.Text = "Enterprise Resource Planning Registration ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(dtpJoiningDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmployeeID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtRole);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDepartmentName);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 373);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = " Department Information";
            // 
            // dtpJoiningDate
            // 
            dtpJoiningDate.Location = new Point(324, 283);
            dtpJoiningDate.Name = "dtpJoiningDate";
            dtpJoiningDate.Size = new Size(374, 52);
            dtpJoiningDate.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 293);
            label6.Name = "label6";
            label6.Size = new Size(283, 37);
            label6.TabIndex = 6;
            label6.Text = "Joining Date :";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(292, 215);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(267, 52);
            txtEmployeeID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 218);
            label5.Name = "label5";
            label5.Size = new Size(264, 37);
            label5.TabIndex = 4;
            label5.Text = "Employee ID :";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(159, 138);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(267, 52);
            txtRole.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 141);
            label4.Name = "label4";
            label4.Size = new Size(131, 37);
            label4.TabIndex = 2;
            label4.Text = "Role :";
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(378, 64);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(352, 52);
            txtDepartmentName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 67);
            label3.Name = "label3";
            label3.Size = new Size(340, 37);
            label3.TabIndex = 0;
            label3.Text = "Department Name :";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(485, 489);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 57);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSavenext
            // 
            btnSavenext.BackColor = Color.Lime;
            btnSavenext.Location = new Point(218, 489);
            btnSavenext.Name = "btnSavenext";
            btnSavenext.Size = new Size(206, 57);
            btnSavenext.TabIndex = 5;
            btnSavenext.Text = "Save/Next";
            btnSavenext.UseVisualStyleBackColor = false;
            btnSavenext.Click += btnSavenext_Click;
            // 
            // DepartmentInformationForm
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(809, 567);
            Controls.Add(btnClear);
            Controls.Add(btnSavenext);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MingLiU-ExtB", 22.2F, FontStyle.Italic);
            Margin = new Padding(7, 6, 7, 6);
            Name = "DepartmentInformationForm";
            Text = "DepartmentInformationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtDepartmentName;
        private Label label6;
        private TextBox txtEmployeeID;
        private Label label5;
        private TextBox txtRole;
        private Label label4;
        private DateTimePicker dtpJoiningDate;
        private Button btnClear;
        private Button btnSavenext;
    }
}