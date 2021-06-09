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
            _dao = new MedewerkerDAO(); // connection to DAL layer
        }

        // methods
        public List<Medewerker> GetAllEmployees()
        {
            return _dao.GetAllEmployeesDB(); // return list of all employees
        }

        public bool CheckForExistende(string name)
        {
            return _dao.CheckForUserExistence(name); // return a bool, check the existence of a user
        }

        public void AddEmployee(string name, string date, string gender, string function, string ww)
        {
            _dao.AddEmployee(name, date, gender, function, ww); // add a employee
        }

        public List<int> GetEmployeeIds()
        {
            return _dao.GetEmployeeIdsDB(); // return a list of ids
        }

        public Medewerker GetMedewerker(int id)
        {
            return _dao.GetEmployeeDB(id); // return a single employee
        }

        public List<String> GetColumns()
        {
            return _dao.GetColumnsDB(); // return a list with all the columns
        }

        public void UpdateEmployee(int id, string column, string waarde)
        {
            _dao.UpdateEmployeeDB(id, column, waarde); // update a employee
        }

        public void RemoveEmployee(int id)
        {
            _dao.RemoveEmployeeDB(id); // remove a employee
        }
    }
}
