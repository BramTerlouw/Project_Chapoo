using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Service_Chapoo;
using Model_Chapoo;

namespace UI
{
    public partial class Login : Form
    {
        // fields
        private LoginService _servicelogin;
        private MedewerkerService _serviceMedewerker;
        
        public Login()
        {
            InitializeComponent();
            _servicelogin = new LoginService();
            _serviceMedewerker = new MedewerkerService();
        }

        
        
        // login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (VerifyLoginAttempt() == false) // use method to verify the user input
                return;
            Bestelling bestelling = new Bestelling();
            int id = int.Parse(txtLoginID.Text);
            int wachtwoord = int.Parse(txtLoginWachtwoord.Text); // parse input to integer values
            bestelling.MedewerkerID = id;
            if (_servicelogin.CredentialsLegitimate(id, wachtwoord) == true) // check credentials, when true pass login screen to new main menu, clear fields and hide loginscreen
            {
                new HoofdMenu(this, _serviceMedewerker.GetMedewerker(id)).Show();
                this.Hide();
                txtLoginID.Clear();
                txtLoginWachtwoord.Clear();
            }
            else
            {
                MessageBox.Show("Wrong!"); // give error when credentials are wrong
            }
        }




        // main method that summarizes all check methods into one
        public bool VerifyLoginAttempt()
        {
            if (CheckAllFieldsFilled() == false)
            {
                MessageBox.Show("Fill all fields!");
                return false;
            }
            else if (CheckID() == false)
            {
                MessageBox.Show("ID contains letters");
                return false;
            }
            else if (CheckPassword() == false)
            {
                MessageBox.Show("Password is wrong length or contains letters!");
                return false;
            }
            else
                return true;
        }




        // individual methods for checking the logging in
        public bool CheckAllFieldsFilled()
        {
            // if the textfields are empty, return false
            if (String.IsNullOrEmpty(txtLoginID.Text) || String.IsNullOrEmpty(txtLoginWachtwoord.Text))
                return false;
            else
                return true;
        }

        public bool CheckID()
        {
            int id; // if it won't parse, it is not a valid id (letters etc.)
            if (!int.TryParse(txtLoginID.Text, out id))
                return false;
            else
                return true;
        }

        public bool CheckPassword()
        {
            int wachtwoord; // password can only contain numbers and must be 4 digits long
            if (!int.TryParse(txtLoginWachtwoord.Text, out wachtwoord) || wachtwoord.ToString().Length != 4)
                return false;
            else
                return true;
        }
    }
}
