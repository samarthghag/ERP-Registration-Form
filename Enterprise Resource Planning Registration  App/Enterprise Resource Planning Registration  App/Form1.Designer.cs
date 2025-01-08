namespace Enterprise_Resource_Planning_Registration__App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            groupbox = new GroupBox();
            txtAddress = new TextBox();
            label8 = new Label();
            cmdGender = new ComboBox();
            label7 = new Label();
            dtpDOB = new DateTimePicker();
            label6 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            btnSavenext = new Button();
            button2 = new Button();
            groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(815, 37);
            label1.TabIndex = 0;
            label1.Text = "Enterprise Resource Planning Registration ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MingLiU-ExtB", 19F, FontStyle.Italic);
            label2.Location = new Point(1, 64);
            label2.Name = "label2";
            label2.Size = new Size(798, 32);
            label2.TabIndex = 1;
            label2.Text = "*************************************************";
            // 
            // groupbox
            // 
            groupbox.BackColor = SystemColors.ActiveCaptionText;
            groupbox.Controls.Add(txtAddress);
            groupbox.Controls.Add(label8);
            groupbox.Controls.Add(cmdGender);
            groupbox.Controls.Add(label7);
            groupbox.Controls.Add(dtpDOB);
            groupbox.Controls.Add(label6);
            groupbox.Controls.Add(txtPhone);
            groupbox.Controls.Add(label5);
            groupbox.Controls.Add(txtEmail);
            groupbox.Controls.Add(label4);
            groupbox.Controls.Add(txtName);
            groupbox.Controls.Add(label3);
            groupbox.ForeColor = SystemColors.Control;
            groupbox.Location = new Point(12, 110);
            groupbox.Name = "groupbox";
            groupbox.Size = new Size(787, 466);
            groupbox.TabIndex = 2;
            groupbox.TabStop = false;
            groupbox.Text = "Personal Information";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(225, 392);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(550, 52);
            txtAddress.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 395);
            label8.Name = "label8";
            label8.Size = new Size(188, 37);
            label8.TabIndex = 10;
            label8.Text = "Address :";
            // 
            // cmdGender
            // 
            cmdGender.FormattingEnabled = true;
            cmdGender.Location = new Point(624, 60);
            cmdGender.Name = "cmdGender";
            cmdGender.Size = new Size(151, 45);
            cmdGender.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 60);
            label7.Name = "label7";
            label7.Size = new Size(169, 37);
            label7.TabIndex = 8;
            label7.Text = "Gender :";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(339, 305);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(371, 52);
            dtpDOB.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Location = new Point(31, 315);
            label6.Name = "label6";
            label6.Size = new Size(302, 37);
            label6.TabIndex = 6;
            label6.Text = "Date of Birth :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(182, 227);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(293, 52);
            txtPhone.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 230);
            label5.Name = "label5";
            label5.Size = new Size(150, 37);
            label5.TabIndex = 4;
            label5.Text = "Phone :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 52);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 143);
            label4.Name = "label4";
            label4.Size = new Size(150, 37);
            label4.TabIndex = 2;
            label4.Text = "Email :";
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 52);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 60);
            label3.Name = "label3";
            label3.Size = new Size(131, 37);
            label3.TabIndex = 0;
            label3.Text = "Name :";
            // 
            // btnSavenext
            // 
            btnSavenext.BackColor = Color.Lime;
            btnSavenext.Location = new Point(194, 591);
            btnSavenext.Name = "btnSavenext";
            btnSavenext.Size = new Size(206, 57);
            btnSavenext.TabIndex = 3;
            btnSavenext.Text = "Save/Next";
            btnSavenext.UseVisualStyleBackColor = false;
            btnSavenext.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(461, 591);
            button2.Name = "button2";
            button2.Size = new Size(121, 57);
            button2.TabIndex = 4;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(815, 660);
            Controls.Add(button2);
            Controls.Add(btnSavenext);
            Controls.Add(groupbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MingLiU-ExtB", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "ERP Registration Form";
            groupbox.ResumeLayout(false);
            groupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupbox;
        private Label label3;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private DateTimePicker dtpDOB;
        private Label label6;
        private Label label7;
        private ComboBox cmdGender;
        private Label label8;
        private TextBox txtAddress;
        private Button btnSavenext;
        private Button button2;
    }
}
