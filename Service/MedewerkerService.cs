using System;
using System.Collections.Generic;
using System.Text;
using DAL_Chapoo;
using Model_Chapoo;

namespace Service_Chapoo
{
    public class MedewerkerService
    {
        // fields
        private MedewerkerDAO _dao;

        // ctor
        public MedewerkerService()
        {
            _dao = new MedewerkerDAO();
        }

        // methods
        public List<Medewerker> GetAllEmployees()
        {
            return _dao.GetAllEmployeesDB();
        }

        public bool CheckForExistende(string name)
        {
            return _dao.CheckForUserExistence(name);
        }

        public void AddEmployee(string name, string date, string gender, string function, string ww)
        {
            _dao.AddEmployee(name, date, gender, function, ww);
        }

        public List<int> GetEmployeeIds()
        {
            return _dao.GetEmployeeIdsDB();
        }

        public Medewerker GetMedewerker(int id)
        {
            return _dao.GetEmployeeDB(id);
        }

        public List<String> GetColumns()
        {
            return _dao.GetColumnsDB();
        }

        public void UpdateEmployee(int id, string column, string waarde)
        {
            _dao.UpdateEmployeeDB(id, column, waarde);
        }

        public void RemoveEmployee(int id)
        {
            _dao.RemoveEmployeeDB(id);
        }
    }
}
