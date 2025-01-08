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
    public partial class AccountDetailsForm : Form
    {
        public AccountDetailsForm()
        {
            InitializeComponent();
        }

        private void btnSavenext_Click(object sender, EventArgs e)
        {
            // Validate Bank Name
            if (string.IsNullOrWhiteSpace(txtBankName.Text))
            {
                MessageBox.Show("Please enter the Bank Name.", "Validation Error");
                return;
            }

            // Validate Account Number
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text) || txtAccountNumber.Text.Length <= 14)
            {
                MessageBox.Show("Please enter a valid Account Number  14 digits.", "Validation Error");
                return;
            }

            // Validate IFSC Code
            if (string.IsNullOrWhiteSpace(txtIFSCCode.Text) || txtIFSCCode.Text.Length != 7)
            {
                MessageBox.Show("Please enter a valid 7-character IFSC Code.", "Validation Error");
                return;
            }

            // Validate Salary
            if (string.IsNullOrWhiteSpace(txtSalary.Text) || !decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Please enter a valid Salary amount.", "Validation Error");
                return;
            }

            // Validate Pan Card Number
            if (string.IsNullOrWhiteSpace(txtPAN.Text) || txtPAN.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-character Pan Card Number.", "Validation Error");
                return;
            }

            // Validate Aadhar Card Number
            if (string.IsNullOrWhiteSpace(txtAadhaar.Text) || txtAadhaar.Text.Length != 12)
            {
                MessageBox.Show("Please enter a valid 12-character Aadhar Card Number.", "Validation Error");
                return;
            }

            // Save Data to Text File
            SaveToTextFile();

            //  Navigate to the Next Form (Security Form)
            SecurityForm securityForm = new SecurityForm();
            securityForm.Show();
            this.Hide();

            /* Navigate to the Next Form (Miscellaneous Form)
            MiscellaneousForm miscellaneousForm = new MiscellaneousForm();
            miscellaneousForm.Show();
            this.Hide();*/
        }

        private void SaveToTextFile()
        {
            string data = $"Bank Name: {txtBankName.Text}, " +
                          $"Account Number: {txtAccountNumber.Text}, " +
                          $"IFSC Code: {txtIFSCCode.Text}, " +
                          $"Salary: {txtSalary.Text} , " +
                          $"PAN Card Number: {txtPAN.Text} , " +
                          $"Aadhar Card Number: {txtAadhaar.Text}";

            // Save to a single text file
            System.IO.File.AppendAllText("dataofAcc.txt", data + Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtBankName.Clear();
            txtAccountNumber.Clear();
            txtIFSCCode.Clear();
            txtSalary.Clear();
        }
    }
}
