using System;
using System.Collections.Generic;
using System.Text;

namespace Model_Chapoo
{
    public class Medewerker
    {
        // fields
        private int _medewerkerID;
        private string _naam;
        private string _geboorteDatum;
        private string _geslacht;
        private string _wachtwoord;

        // propertie
        private string _rol;
        public string Rol
        {
            get { return _rol; }
        }

        // ctor
        public Medewerker(int id, string naam, string geboorte, string geslacht, string rol, string wachtwoord)
        {
            _medewerkerID = id;
            _naam = naam;
            _geboorteDatum = geboorte;
            _geslacht = geslacht;
            _rol = rol;
            _wachtwoord = wachtwoord;
        }

        // make a array of th properties and fields of employee for dgv
        public string[] dataGridWW(Medewerker medewerker)
        {
            return new string[]
            {
                _medewerkerID.ToString(),
                _naam,
                _geboorteDatum,
                _geslacht,
                _rol,
                _wachtwoord

            };
        }

        public string[] dataGridNoWW(Medewerker medewerker)
        {
            return new string[]
            {
                _medewerkerID.ToString(),
                _naam,
                _geboorteDatum,
                _geslacht,
                _rol,
            };
        }
    }
}
