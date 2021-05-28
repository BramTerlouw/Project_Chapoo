using System;

namespace Model_Chapoo
{
    public class VoorraadItem
    {
        // fields
        private int _id;
        private string _naam;
        private int _aantal;

        // ctor
        public VoorraadItem(int id, string naam, int aantal)
        {
            _id = id;
            _naam = naam;
            _aantal = aantal;
        }

        // change voorraaditem to array for dgv
        public string[] dataGrid(VoorraadItem item)
        {
            return new string[]
            {
                item._id.ToString(),
                item._naam,
                item._aantal.ToString()
            };
        }
    }
}
