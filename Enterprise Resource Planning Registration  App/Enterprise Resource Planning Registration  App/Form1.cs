using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Enterprise_Resource_Planning_Registration__App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmdGender.Items.AddRange(new string[] { " ", "MALE", "FEMALE" });
            cmdGender.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please correct the highlighted fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save data to file
            SaveDataToFile();

            // Navigate to next form
            DepartmentInformationForm departmentForm = new DepartmentInformationForm();
            departmentForm.Show();
            this.Hide();
        }

        private void SaveDataToFile()
        {
            // Prepare data to save
            string data = $"Name: {txtName.Text}\n" +
                          $"Email: {txtEmail.Text}\n" +
                          $"Phone: {txtPhone.Text}\n" +
                          $"Date of Birth: {dtpDOB.Value.ToShortDateString()}\n" +
                          $"Gender: {cmdGender.SelectedItem}\n" +
                          $"Address: {txtAddress.Text}\n" +
                          "---------------------------------------------\n";

            // Save to file
            string filePath = "data.txt";
            File.AppendAllText(filePath, data);

            MessageBox.Show("Personal Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Validate Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error");
                isValid = false;
            }

            // Validate Email
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error");
                isValid = false;
            }

            // Validate Phone
            if (!Regex.IsMatch(txtPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be 10 digits.", "Validation Error");
                isValid = false;
            }

            // Validate Gender
            if (cmdGender.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a gender.", "Validation Error");
                isValid = false;
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error");
                isValid = false;
            }

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            dtpDOB.Value = DateTime.Now;
            cmdGender.SelectedIndex = -1;
            txtAddress.Clear();
        }
    }
}
