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
    public partial class MiscellaneousForm : Form
    {
        public MiscellaneousForm()
        {
            InitializeComponent();
            // Populate Marital Status dropdown
            cmbMaritalStatus.Items.AddRange(new string[] { "Single", "Married", "Divorced", "Widowed" });

            // Populate Blood Group dropdown
            cmbBloodGroup.Items.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            // Populate Hobbies ListBox
            lstHobbies.Items.AddRange(new string[] { "Reading Manga", "Traveling", "Sports", "Music", "Gaming", "Watching Anime" });
        }

        private void btnSavenext_Click(object sender, EventArgs e)
        {
            if (ValidateMiscellaneousSection())
            {
                string miscellaneousData = GetMiscellaneousData();

                // Save the data or process further
                SaveMiscellaneousData(miscellaneousData);

                MessageBox.Show("Miscellaneous information saved successfully!", "Success");

                // Optionally close the form or navigate to another
                this.Close();
            }
        }

        private void SaveMiscellaneousData(string miscellaneousData)
        {
            System.IO.File.WriteAllText("MiscellaneousData.txt", miscellaneousData);
        }

        private string GetMiscellaneousData()
        {
            string selectedHobbies = string.Join(", ", GetSelectedHobbies());
            return $"Emergency Contact: {txtEmergencyContact.Text}, " +
                   $"Hobbies: {selectedHobbies}, " +
                   $"Marital Status: {cmbMaritalStatus.SelectedItem}, " +
                   $"Blood Group: {cmbBloodGroup.SelectedItem}";
        }

        private List<string> GetSelectedHobbies()
        {
            List<string> selectedHobbies = new List<string>();
            foreach (var item in lstHobbies.SelectedItems)
            {
                selectedHobbies.Add(item.ToString());
            }
            return selectedHobbies;
        }

        private bool ValidateMiscellaneousSection()
        {
            // Validate Emergency Contact
            if (string.IsNullOrWhiteSpace(txtEmergencyContact.Text))
            {
                MessageBox.Show("Please enter an emergency contact number.", "Validation Error");
                txtEmergencyContact.Focus();
                return false;
            }

            if (txtEmergencyContact.Text.Length != 10 || !long.TryParse(txtEmergencyContact.Text, out _))
            {
                MessageBox.Show("Please enter a valid 10-digit emergency contact number.", "Validation Error");
                txtEmergencyContact.Focus();
                return false;
            }

            // Validate Hobbies
            if (lstHobbies.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one hobby.", "Validation Error");
                lstHobbies.Focus();
                return false;
            }

            // Validate Marital Status
            if (cmbMaritalStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your marital status.", "Validation Error");
                cmbMaritalStatus.Focus();
                return false;
            }

            // Validate Blood Group
            if (cmbBloodGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your blood group.", "Validation Error");
                cmbBloodGroup.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmergencyContact.Clear();
            lstHobbies.ClearSelected();
            cmbMaritalStatus.SelectedIndex = -1;
            cmbBloodGroup.SelectedIndex = -1;
        }
    }
}
