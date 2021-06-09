using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model_Chapoo;
using Service_Chapoo;

namespace UI
{
    public partial class Medewerkers_Main : Form
    {
        // fields
        private Administratie_Main _main;
        private List<Medewerker> _medewerkers;
        private MedewerkerService _service;
        private Medewerker _medewerker;



        // ctor
        public Medewerkers_Main(Administratie_Main main, Medewerker medewerker)
        {
            // set main menu, logged employee and connection to service layer
            InitializeComponent();
            this._main = main;
            this._medewerker = medewerker;
            this._service = new MedewerkerService();

            // populate all grids and cmbs
            PopulateGridEmployees();
            PopulateCMBIds();
            PopulateCMBFields();

            // hide modify panels
            HideItems();

            // set selected index to zero
            cmbSelectmedewerker.SelectedIndex = 0;
            cmbSelectVeld.SelectedIndex = 0;
            cmbSelectMedewerkerVerwijderen.SelectedIndex = 0;
        }






        // Populate and Hide
        private void PopulateGridEmployees()
        {
            _medewerkers = _service.GetAllEmployees(); // get all empoyees and populate dgv
            foreach (Medewerker werker in _medewerkers)
            {
                dgvMedewerkers.Rows.Add(werker.dataGridNoWW(werker));
            }
        }

        public void PopulateCMBIds()
        {
            List<int> medewerkerIDs = _service.GetEmployeeIds(); // get all ids and populate cmbs
            foreach (int id in medewerkerIDs)
            {
                cmbSelectmedewerker.Items.Add(id);
                cmbSelectMedewerkerVerwijderen.Items.Add(id);
            }
        }

        public void PopulateCMBFields()
        {
            List<string> fields = _service.GetColumns(); // get all columns from db and populate cmb
            foreach (string name in fields)
            {
                cmbSelectVeld.Items.Add(name);
            }
        }

        private void HideItems()
        {
            pnlMedewerkerToevoegen.Hide();
            pnlMedewerkerAanpassen.Hide();
            pnlMedewerkerVerwijderen.Hide();

            if (_medewerker.Rol != "Eigenaar") // when logged in as owner, show extra adjust buttons
            {
                btnMedewerkerAanpassen.Hide();
                btnMedewerkerToevoegen.Hide();
                btnMedewerkerVerwijderen.Hide();
            }
        }

        private void btnRefreshMedewerkers_Click(object sender, EventArgs e)
        {
            // refresh and clear
            _medewerkers.Clear();
            cmbSelectmedewerker.Items.Clear();
            cmbSelectMedewerkerVerwijderen.Items.Clear();
            cmbSelectVeld.Items.Clear();
            dgvMedewerkers.Rows.Clear();
            dgvMedewerkerVerwijderen.Rows.Clear();
            dgvMedewerkerAanpassen.Rows.Clear();
            PopulateGridEmployees();
            PopulateCMBIds();
            PopulateCMBFields();
        }








        // Medewerker aanpassen
        private void btnMedewerkerAanpassen_Click(object sender, EventArgs e)
        {
            pnlMedewerkerAanpassen.Show();
            dtpMedewerkerAanpassen.Hide(); // show panel employee adjustment
        }

        private void cmbSelectmedewerker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbSelectmedewerker.SelectedItem; // when the selected index is changed, adjust the dgv to show the employee connected to newly chosen id
            dgvMedewerkerAanpassen.Rows.Clear();

            Medewerker medewerker = _service.GetMedewerker(id);
            dgvMedewerkerAanpassen.Rows.Add(medewerker.dataGridWW(medewerker));
        }

        private void cmbSelectVeld_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectVeld.SelectedItem.ToString() == "MedewerkerGeboorteDatum") // if this value is chosen, show a datetimepicker
            {
                dtpMedewerkerAanpassen.Show();
                txtNieuweMedewerkerWaarde.Hide();
            }
            else // else show a regular textfield for input
            {
                dtpMedewerkerAanpassen.Hide();
                txtNieuweMedewerkerWaarde.Show();
            }
        }

        private void btnMedewerkerAanpassingDB_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNieuweMedewerkerWaarde.Text))
            {
                MessageBox.Show("Vul alle velden!"); // if the fields is empty, display error message and return
                return;
            }

            int id = (int)cmbSelectmedewerker.SelectedItem; // get the values
            string column = (string)cmbSelectVeld.SelectedItem;

            string waarde; // if column is MedewerkerGeboorteDatum then get value fro m datetimepicker
            if (column == "MedewerkerGeboorteDatum")
                waarde = dtpMedewerkerAanpassen.Value.Date.ToString();
            else // else get from textbox
                waarde = CheckValueEmployeeAdjustment(column, txtNieuweMedewerkerWaarde.Text); // use this method to check input

            if (waarde == "wrong")
            {
                MessageBox.Show("Foutieve invoer!"); // display error when input is wrong
                return;
            }

            _service.UpdateEmployee(id, column, waarde);
            txtNieuweMedewerkerWaarde.Clear();
            MessageBox.Show("Medewerker aangepast!"); // adjust employee and show confirmation
        }

        private string CheckValueEmployeeAdjustment(string column, string waarde)
        {
            switch (column) // switch on column, depending on the column, check input
            {
                case "MedewerkerNaam":
                    return waarde;
                case "MedewerkerGeslacht":
                    string tempGeslacht = waarde.ToLower();
                    if (tempGeslacht == "male" || tempGeslacht == "female") // check if gender is male or female
                        return waarde;
                    else
                        return "wrong";
                case "Rol":
                    string tempRol = waarde.ToLower();
                    if (tempRol == "chef" || tempRol == "bediende" || tempRol == "barman" || tempRol == "eigenaar") // check if function is a valid function
                        return waarde;
                    else
                        return "wrong";
                case "Wachtwoord":
                    int wachtwoord;
                    if (int.TryParse(waarde, out wachtwoord) && waarde.Length == 4) // check the password for its length and if it contains numbers only
                        return waarde;
                    else
                        return "wrong";
                default:
                    return "wrong";
            }
        }








        // Medewerker verwijderen
        private void btnMedewerkerVerwijderen_Click(object sender, EventArgs e)
        {
            pnlMedewerkerVerwijderen.Show(); // show employee removal panel
        }

        private void cmbSelectMedewerkerVerwijderen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbSelectMedewerkerVerwijderen.SelectedItem;
            dgvMedewerkerVerwijderen.Rows.Clear(); // when selected index is changed, change the dgv with it

            Medewerker medewerker = _service.GetMedewerker(id);
            dgvMedewerkerVerwijderen.Rows.Add(medewerker.dataGridWW(medewerker));
        }

        private void btnVerwijderMedewerkerDB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze medewerker wilt verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) // when user presses yes, remove employee
            {
                int id = (int)cmbSelectMedewerkerVerwijderen.SelectedItem;
                _service.RemoveEmployee(id);
            }
            else if (dialogResult == DialogResult.No) // when user presses no, dont do anything
            {
                return;
            }
        }






        // Medewerker toevoegen
        private void btnMedewerkerToevoegen_Click(object sender, EventArgs e)
        {
            // show and hide panels
            pnlMedewerkerToevoegen.Show();
            cmbToevoegenRol.Hide();
            txtToevoegenWW.Hide();
            btnAddMedewerker.Hide();
            lblToevoegenRol.Hide();
            lblToevoegenWW.Hide();
        }

        private void btnToevoegenControleren_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtToevoegenNaam.Text))
            {
                MessageBox.Show("Vul alle velden in!"); // if fields is empty, display an error
                return;
            }
            else if (_service.CheckForExistende(txtToevoegenNaam.Text) == false) // check if a user exists with that name, of not then show next input fields
            {
                txtToevoegenNaam.ReadOnly = true; // set name to readonly so it cant be changed after checking
                btnToevoegenControleren.Hide();

                cmbToevoegenRol.Show();
                txtToevoegenWW.Show();
                btnAddMedewerker.Show();
                lblToevoegenRol.Show();
                lblToevoegenWW.Show();
            }
            else
                MessageBox.Show("A user already exists with this name"); // display error when name is already in use
        }

        private void btnAddMedewerker_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtToevoegenWW.Text))
            {
                MessageBox.Show("Vul alle velden in!"); // when field is empty show error message
                return;
            }

            if (CheckWWAddedEmployee(txtToevoegenWW.Text) == true) // use method to validate password
            {
                // get all values
                string name = txtToevoegenNaam.Text;
                string geboorte = dtpToevoegenDatum.Value.Date.ToString();
                string geslacht = cmbToevoegenGeslacht.SelectedItem.ToString();
                string rol = cmbToevoegenRol.SelectedItem.ToString();
                string wachtwoord = txtToevoegenWW.Text;

                // add the employee by calling the service layer and passing all the values
                _service.AddEmployee(name, geboorte, geslacht, rol, wachtwoord);
                MessageBox.Show("Medewerker toegevoegd!");

                // reset the panel
                txtToevoegenNaam.ReadOnly = false;
                txtToevoegenNaam.Clear();
                btnToevoegenControleren.Show();
                cmbToevoegenRol.Hide();
                txtToevoegenWW.Hide();
                btnAddMedewerker.Hide();
                lblToevoegenRol.Hide();
                lblToevoegenWW.Hide();
            }
        }

        private bool CheckWWAddedEmployee(string wachtwoord)
        {
            int ww; // try to parse it to check if its a valid integer
            if (!int.TryParse(txtToevoegenWW.Text, out ww))
            {
                MessageBox.Show("Wachtwoord moet uit cijfers bestaan!");
                return false;
            }

            if (wachtwoord.ToString().Length != 4) // check the password for the right length
            {
                MessageBox.Show("Wachtwoord moet 4 cijfers lang zijn!");
                return false;
            }
            return true;
        }





        // close panels
        private void button1_Click(object sender, EventArgs e)
        {
            pnlMedewerkerAanpassen.Hide();
            dtpMedewerkerAanpassen.Hide(); // hide the panels
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMedewerkerToevoegen.Hide();
            txtToevoegenNaam.ReadOnly = false;
            txtToevoegenNaam.Clear();
            btnToevoegenControleren.Show();

            cmbToevoegenRol.Hide();
            txtToevoegenWW.Hide();
            btnAddMedewerker.Hide();
            lblToevoegenRol.Hide();
            lblToevoegenWW.Hide(); // hide and reset the panel
        }

        private void btnClodeMedewerkerVerwijderen_Click(object sender, EventArgs e)
        {
            pnlMedewerkerVerwijderen.Hide(); // hide panel for removal of empolyee
        }

        private void btnMedewerkersTerug_Click(object sender, EventArgs e)
        {
            this.Close();
            _main.Show(); // close this form and open main menu
        }

        
    }
}
