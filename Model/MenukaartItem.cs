using System;
using System.Collections.Generic;
using System.Text;

namespace Model_Chapoo
{
    public class MenukaartItem
    {
        //fields
        public int Id { get; set; }

        // properties
        private string _soort;
        public string Soort
        {
            get { return _soort; }
        }

        private string _naam;
        public string Naam
        {
            get { return _naam; }
        }

        private bool _alcohol;
        public bool Alcohol
        {
            get { return _alcohol; }
        }

        private float _prijs;
        public float Prijs
        {
            get { return _prijs; }
        }


        // ctor
        public MenukaartItem(int id, string soort, string naam, bool alcohol, float prijs)
        {
            Id = id;
            _soort = soort;
            _naam = naam;
            _alcohol = alcohol;
            _prijs = prijs;
        }

        // turn into string array for dgv
        public string[] dataGrid(MenukaartItem menuItem)
        {
            return new string[]
            {
                Id.ToString(),
                _soort,
                _naam,
                _alcohol.ToString(),
                _prijs.ToString("0.00")

            };
        }

        public string[] dataGridNoAlc(MenukaartItem menuItem)
        {
            return new string[]
            {
                Id.ToString(),
                _soort,
                _naam,
                _prijs.ToString("0.00")

            };
        }
    }
}
