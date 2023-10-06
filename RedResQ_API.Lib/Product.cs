using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;

namespace RedResQ_API.Lib
{
    public class Product
    {
        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            private set => _id = value;
            get => _id;
        }

        public string Name
        {
            private set => _name = value;
            get => _name;
        }

        public override string ToString()
        {
            return $"The product {_name} has the following ID: {_id}";
        }
    }
}