using System;
using System.Collections.Generic;
using System.Text;
using Model_Chapoo;
using DAL_Chapoo;

namespace Service_Chapoo
{
    public class LoginService
    {
        // fields
        private LoginDAO _dao;

        // ctor
        public LoginService()
        {
            _dao = new LoginDAO();
        }

        // check if there is a user with the id and password
        public bool CredentialsLegitimate(int id, int wachtwoord)
        {
            int users = _dao.VerifyLoginAttemptDB(id, wachtwoord); // get the amount of users with the credentials
            if (users == 1) // when a user exists return true
                return true;
            else
                return false;
        }
    }
}
