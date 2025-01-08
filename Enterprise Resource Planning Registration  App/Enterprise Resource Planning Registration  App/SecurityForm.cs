using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Resource_Planning_Registration__App
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
            cmbSecQues.Items.AddRange(new string[]
            {
                "What is your pet's name?",
                "What is your mother's maiden name?",
                "What was the name of your first school?",
                "What is your favorite color?"
             });
        }

        private void btnSavenext_Click(object sender, EventArgs e)
        {
            if (ValidateSecuritySection())
            {
                string securityData = GetSecurityData();

                // Example of where to save security data
                SaveSecurityData(securityData);

                MessageBox.Show("Security section validated and saved!", "Success");

                // Navigate to the next form (Miscellaneous Form)
                MiscellaneousForm miscellaneousForm = new MiscellaneousForm();
                miscellaneousForm.Show();
                this.Hide();
            }
        }

        private void SaveSecurityData(string securityData)
        {
            // Placeholder for saving data to a file or database
            // Example: Save to a local text file
            System.IO.File.WriteAllText("SecurityData.txt", securityData);
        }

        private string GetSecurityData()
        {
            return $"Username: {txtUsername.Text}, Password: [Hidden], " +
                   $"Security Question: {cmbSecQues.SelectedItem}, Security Answer: {txtSecAns.Text}";
        }

        private bool ValidateSecuritySection()
        {
            // Validate Username
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error");
                txtUsername.Focus();
                return false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error");
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error");
                txtPassword.Focus();
                return false;
            }

            // Validate Security Question
            if (cmbSecQues.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a security question.", "Validation Error");
                cmbSecQues.Focus();
                return false;
            }

            // Validate Security Answer
            if (string.IsNullOrWhiteSpace(txtSecAns.Text))
            {
                MessageBox.Show("Please provide an answer to the security question.", "Validation Error");
                txtSecAns.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbSecQues.SelectedIndex = -1;
            txtSecAns.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
