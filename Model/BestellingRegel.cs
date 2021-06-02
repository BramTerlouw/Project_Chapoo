namespace Model_Chapoo
{
    public class BestellingRegel
    {
        public int BestellingID { get; private set; }

        public int RegelNR { get; private set; }

        public int MenuItemID { get; private set; }

        public BestellingRegel(int id, int nr, int itemid)
        {
            BestellingID = id;
            RegelNR = nr;
            MenuItemID = itemid;
        }

        public string[] dataGrid(BestellingRegel regel)
        {
            return new string[]
            {
                BestellingID.ToString(),
                RegelNR.ToString(),
                MenuItemID.ToString()
            };
        }
    }
}
