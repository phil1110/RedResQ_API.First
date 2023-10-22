namespace RedResQ_API.Lib.Models
{
    public class Location
    {
        #region Instance variables

        private int _id;
        private string _country;
        private string _region;
        private string _place;
        private string _postalCode;

        #endregion

        #region Constructor

        public Location(int id, string country, string region, string place, string postalCode)
        {
            Id = id;
            Country = country;
            Region = region;
            Place = place;
            PostalCode = postalCode;
        }

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Country
        {
            get => _country;
            private set => _country = value;
        }

        public string Region
        {
            get => _region;
            private set => _region = value;
        }

        public string Place
        {
            get => _place;
            private set => _place = value;
        }

        public string PostalCode
        {
            get => _postalCode;
            private set => _postalCode = value;
        }

        #endregion
    }
}