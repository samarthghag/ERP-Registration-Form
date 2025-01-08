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
    public partial class DepartmentInformationForm : Form
    {
        public DepartmentInformationForm()
        {
            InitializeComponent();
            GenerateEmployeeID(); // Generate Employee ID when the form loads
        }

        private void GenerateEmployeeID()
        {
            Random random = new Random();
            int employeeID = random.Next(1000, 9999); // Generates a 4-digit random number
            txtEmployeeID.Text = "EMP" + employeeID; // Prefix with "EMP"
            txtEmployeeID.ReadOnly = true; // Make the field read-only
        }

        private void btnSavenext_Click(object sender, EventArgs e)
        {
            // Validate Department Name
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Please enter the Department Name.", "Validation Error");
                return;
            }

            // Validate Role
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Please enter the Role.", "Validation Error");
                return;
            }

            // Save Data to Text File
            SaveToTextFile();

            // Navigate to the Next Form (Account Details)
            AccountDetailsForm accountDetailsForm = new AccountDetailsForm();
            accountDetailsForm.Show();
            this.Hide();
        }

        private void SaveToTextFile()
        {
            string data = $"Department Name: {txtDepartmentName.Text}, " +
                          $"Role: {txtRole.Text}, " +
                          $"Employee ID: {txtEmployeeID.Text}, " +
                          $"Joining Date: {dtpJoiningDate.Value.ToShortDateString()}";

            // Save to a single text file
            System.IO.File.AppendAllText("dataofDep.txt", data + Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields except Employee ID
            txtDepartmentName.Clear();
            txtRole.Clear();
            dtpJoiningDate.Value = DateTime.Now;

            // Regenerate Employee ID
            GenerateEmployeeID();
        }
    }
}
