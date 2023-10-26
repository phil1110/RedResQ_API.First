namespace RedResQ_API.Lib.Models
{
    public class Role
    {
        #region Constructor

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion

        #region Properties

        public int Id { get; private set; }
        
        public string Name { get; private set; }

        #endregion
    }
}