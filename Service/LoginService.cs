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
            int users = _dao.VerifyLoginAttemptDB(id, wachtwoord);
            if (users == 1)
                return true;
            else
                return false;
        }
    }
}
