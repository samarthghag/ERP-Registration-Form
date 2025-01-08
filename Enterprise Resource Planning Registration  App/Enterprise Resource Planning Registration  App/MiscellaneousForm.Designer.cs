namespace Enterprise_Resource_Planning_Registration__App
{
    partial class MiscellaneousForm
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
            cmbBloodGroup = new ComboBox();
            cmbMaritalStatus = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            lstHobbies = new ListBox();
            label4 = new Label();
            txtEmergencyContact = new TextBox();
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
            label2.Location = new Point(-5, 57);
            label2.Name = "label2";
            label2.Size = new Size(798, 32);
            label2.TabIndex = 8;
            label2.Text = "*************************************************";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-5, 9);
            label1.Name = "label1";
            label1.Size = new Size(815, 37);
            label1.TabIndex = 7;
            label1.Text = "Enterprise Resource Planning Registration ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(cmbBloodGroup);
            groupBox1.Controls.Add(cmbMaritalStatus);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lstHobbies);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmergencyContact);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.SaddleBrown;
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 468);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miscellaneous Information";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Location = new Point(276, 362);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(200, 45);
            cmbBloodGroup.TabIndex = 7;
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Location = new Point(321, 292);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new Size(200, 45);
            cmbMaritalStatus.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 365);
            label6.Name = "label6";
            label6.Size = new Size(264, 37);
            label6.TabIndex = 5;
            label6.Text = "Blood Group :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 295);
            label5.Name = "label5";
            label5.Size = new Size(321, 37);
            label5.TabIndex = 4;
            label5.Text = "Marital Status :";
            // 
            // lstHobbies
            // 
            lstHobbies.FormattingEnabled = true;
            lstHobbies.ItemHeight = 37;
            lstHobbies.Location = new Point(200, 122);
            lstHobbies.Name = "lstHobbies";
            lstHobbies.Size = new Size(448, 115);
            lstHobbies.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 161);
            label4.Name = "label4";
            label4.Size = new Size(188, 37);
            label4.TabIndex = 2;
            label4.Text = "Hobbies :";
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Location = new Point(390, 45);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(385, 52);
            txtEmergencyContact.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(378, 37);
            label3.TabIndex = 0;
            label3.Text = "Emergency Contact :";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(470, 583);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 57);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSavenext
            // 
            btnSavenext.BackColor = Color.Lime;
            btnSavenext.Location = new Point(203, 583);
            btnSavenext.Name = "btnSavenext";
            btnSavenext.Size = new Size(206, 57);
            btnSavenext.TabIndex = 11;
            btnSavenext.Text = "Save/Next";
            btnSavenext.UseVisualStyleBackColor = false;
            btnSavenext.Click += btnSavenext_Click;
            // 
            // MiscellaneousForm
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(804, 649);
            Controls.Add(btnClear);
            Controls.Add(btnSavenext);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MingLiU-ExtB", 22.2F, FontStyle.Italic);
            Margin = new Padding(7, 6, 7, 6);
            Name = "MiscellaneousForm";
            Text = "MiscellaneousForm";
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
        private Label label4;
        private TextBox txtEmergencyContact;
        private Label label6;
        private Label label5;
        private ListBox lstHobbies;
        private ComboBox cmbBloodGroup;
        private ComboBox cmbMaritalStatus;
        private Button btnClear;
        private Button btnSavenext;
    }
}