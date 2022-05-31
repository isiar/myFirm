namespace MyFirm
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public int PostCode { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return "ors." + City + " str." + Street + " no." + Number + "cod postal " + PostCode + ", " + Country;
        }
    }
}