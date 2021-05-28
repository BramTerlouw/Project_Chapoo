﻿using System;
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
            _medewerkers = _service.GetAllEmployees();
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

        


        



        // Medewerker aanpassen
        private void btnMedewerkerAanpassen_Click(object sender, EventArgs e)
        {
            pnlMedewerkerAanpassen.Show();
        }

        private void cmbSelectmedewerker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbSelectmedewerker.SelectedItem;
            dgvMedewerkerAanpassen.Rows.Clear();

            Medewerker medewerker = _service.GetMedewerker(id);
            dgvMedewerkerAanpassen.Rows.Add(medewerker.dataGridWW(medewerker));
        }

        private void btnMedewerkerAanpassingDB_Click(object sender, EventArgs e)
        {
            int id = (int)cmbSelectmedewerker.SelectedItem;
            string column = (string)cmbSelectVeld.SelectedItem;
            string waarde = txtNieuweMedewerkerWaarde.Text;

            _service.UpdateEmployee(id, column, waarde);
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
            txtToevoegenRol.Hide();
            txtToevoegenWW.Hide();
            btnAddMedewerker.Hide();
            lblToevoegenRol.Hide();
            lblToevoegenWW.Hide();
        }

        private void btnToevoegenControleren_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtToevoegenNaam.Text) || String.IsNullOrEmpty(txtToevoegenGeslacht.Text) || dtpToevoegenDatum.Value == null)
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }
            else if (_service.CheckForExistende(txtToevoegenNaam.Text) == false)
            {
                txtToevoegenNaam.ReadOnly = true;
                txtToevoegenGeslacht.ReadOnly = true;
                lblToevoegenDatum.Text = dtpToevoegenDatum.Value.ToString();
                dtpToevoegenDatum.Hide();

                txtToevoegenRol.Show();
                txtToevoegenWW.Show();
                btnAddMedewerker.Show();
                lblToevoegenRol.Show();
                lblToevoegenWW.Show();
            }
            else
            {
                MessageBox.Show("A user already exists with this name");
            }
        }

        private void btnAddMedewerker_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtToevoegenRol.Text) || String.IsNullOrEmpty(txtToevoegenWW.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }

            // check input
            int wachtwoord;
            if (!int.TryParse(txtToevoegenWW.Text, out wachtwoord))
            {
                MessageBox.Show("Wachtwoord moet uit cijfers bestaan!");
                return;
            }

            if (wachtwoord.ToString().Length != 4)
            {
                MessageBox.Show("Wachtwoord moet 4 cijfers lang zijn!");
                return;
            }

            string name = txtToevoegenNaam.Text;
            string geboorte = lblToevoegenDatum.Text;
            string geslacht = txtToevoegenGeslacht.Text;
            string rol = txtToevoegenRol.Text;

            _service.AddEmployee(name, geboorte, geslacht, rol, wachtwoord.ToString());
            MessageBox.Show("Medewerker toegevoegd!");
        }

        
        



        
        // close panels
        private void button1_Click(object sender, EventArgs e)
        {
            pnlMedewerkerAanpassen.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMedewerkerToevoegen.Hide();
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
