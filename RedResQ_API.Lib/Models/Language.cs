namespace RedResQ_API.Lib.Models
{
    public class Language
    {
        #region Instance variables

        private int _id;
        private string _name;

        #endregion

        #region Constructor

        public Language(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        #endregion
    }
}