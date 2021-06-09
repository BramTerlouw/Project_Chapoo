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
            InitializeComponent();
            this._main = main;
            this._medewerker = medewerker;
            this._service = new MedewerkerService();

            // populate all
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
            _medewerkers = _service.GetAllEmployees();
            foreach (Medewerker werker in _medewerkers)
            {
                dgvMedewerkers.Rows.Add(werker.dataGridNoWW(werker));
            }
        }

        public void PopulateCMBIds()
        {
            List<int> medewerkerIDs = _service.GetEmployeeIds();
            foreach (int id in medewerkerIDs)
            {
                cmbSelectmedewerker.Items.Add(id);
                cmbSelectMedewerkerVerwijderen.Items.Add(id);
            }
        }

        public void PopulateCMBFields()
        {
            List<string> fields = _service.GetColumns();
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

            if (_medewerker.Rol != "Eigenaar")
            {
                btnMedewerkerAanpassen.Hide();
                btnMedewerkerToevoegen.Hide();
                btnMedewerkerVerwijderen.Hide();
            }
        }

        private void btnRefreshMedewerkers_Click(object sender, EventArgs e)
        {
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
            dtpMedewerkerAanpassen.Hide();
        }

        private void cmbSelectmedewerker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbSelectmedewerker.SelectedItem;
            dgvMedewerkerAanpassen.Rows.Clear();

            Medewerker medewerker = _service.GetMedewerker(id);
            dgvMedewerkerAanpassen.Rows.Add(medewerker.dataGridWW(medewerker));
        }

        private void cmbSelectVeld_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectVeld.SelectedItem.ToString() == "MedewerkerGeboorteDatum")
            {
                dtpMedewerkerAanpassen.Show();
                txtNieuweMedewerkerWaarde.Hide();
            }
            else
            {
                dtpMedewerkerAanpassen.Hide();
                txtNieuweMedewerkerWaarde.Show();
            }
        }

        private void btnMedewerkerAanpassingDB_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNieuweMedewerkerWaarde.Text))
            {
                MessageBox.Show("Vul alle velden!");
                return;
            }

            int id = (int)cmbSelectmedewerker.SelectedItem;
            string column = (string)cmbSelectVeld.SelectedItem;

            string waarde;
            if (column == "MedewerkerGeboorteDatum")
                waarde = dtpMedewerkerAanpassen.Value.Date.ToString();
            else
                waarde = CheckValueEmployeeAdjustment(column, txtNieuweMedewerkerWaarde.Text);

            if (waarde == "wrong")
            {
                MessageBox.Show("Foutieve invoer!");
                return;
            }

            _service.UpdateEmployee(id, column, waarde);
            txtNieuweMedewerkerWaarde.Clear();
            MessageBox.Show("Medewerker aangepast!");
        }

        private string CheckValueEmployeeAdjustment(string column, string waarde)
        {
            switch (column)
            {
                case "MedewerkerNaam":
                    return waarde;
                case "MedewerkerGeslacht":
                    string tempGeslacht = waarde.ToLower();
                    if (tempGeslacht == "male" || tempGeslacht == "female")
                        return waarde;
                    else
                        return "wrong";
                case "Rol":
                    string tempRol = waarde.ToLower();
                    if (tempRol == "chef" || tempRol == "bediende" || tempRol == "barman" || tempRol == "eigenaar")
                        return waarde;
                    else
                        return "wrong";
                case "Wachtwoord":
                    int wachtwoord;
                    if (int.TryParse(waarde, out wachtwoord) && waarde.Length == 4)
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
            pnlMedewerkerVerwijderen.Show();
        }

        private void cmbSelectMedewerkerVerwijderen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbSelectMedewerkerVerwijderen.SelectedItem;
            dgvMedewerkerVerwijderen.Rows.Clear();

            Medewerker medewerker = _service.GetMedewerker(id);
            dgvMedewerkerVerwijderen.Rows.Add(medewerker.dataGridWW(medewerker));
        }

        private void btnVerwijderMedewerkerDB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze medewerker wilt verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)cmbSelectMedewerkerVerwijderen.SelectedItem;
                _service.RemoveEmployee(id);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }






        // Medewerker toevoegen
        private void btnMedewerkerToevoegen_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Vul alle velden in!");
                return;
            }
            else if (_service.CheckForExistende(txtToevoegenNaam.Text) == false)
            {
                txtToevoegenNaam.ReadOnly = true;
                btnToevoegenControleren.Hide();

                cmbToevoegenRol.Show();
                txtToevoegenWW.Show();
                btnAddMedewerker.Show();
                lblToevoegenRol.Show();
                lblToevoegenWW.Show();
            }
            else
                MessageBox.Show("A user already exists with this name");
        }

        private void btnAddMedewerker_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtToevoegenWW.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }

            if (CheckWWAddedEmployee(txtToevoegenWW.Text) == true)
            {
                string name = txtToevoegenNaam.Text;
                string geboorte = dtpToevoegenDatum.Value.Date.ToString();
                string geslacht = cmbToevoegenGeslacht.SelectedItem.ToString();
                string rol = cmbToevoegenRol.SelectedItem.ToString();
                string wachtwoord = txtToevoegenWW.Text;

                _service.AddEmployee(name, geboorte, geslacht, rol, wachtwoord);
                MessageBox.Show("Medewerker toegevoegd!");

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
            int ww;
            if (!int.TryParse(txtToevoegenWW.Text, out ww))
            {
                MessageBox.Show("Wachtwoord moet uit cijfers bestaan!");
                return false;
            }

            if (wachtwoord.ToString().Length != 4)
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
            dtpMedewerkerAanpassen.Hide();
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
            lblToevoegenWW.Hide();
        }

        private void btnClodeMedewerkerVerwijderen_Click(object sender, EventArgs e)
        {
            pnlMedewerkerVerwijderen.Hide();
        }

        private void btnMedewerkersTerug_Click(object sender, EventArgs e)
        {
            this.Close();
            _main.Show();
        }

        
    }
}
