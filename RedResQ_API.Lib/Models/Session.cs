using System;

namespace RedResQ_API.Lib.Models
{
    public class Session
    {
        #region Instance variables

        private string _id;
        private DateTime _creationTime;
        private Person _person;

        #endregion

        #region Constructor

        public Session(string id, Person person)
        {
            Id = id;
            CreationTime = DateTime.Now;
            Person = person;
        }

        #endregion

        #region Properties

        public string Id
        {
            get => _id;
            private set => _id = value;
        }

        public DateTime CreationTime
        {
            get => _creationTime;
            private set => _creationTime = value;
        }

        public Person Person
        {
            get => _person;
            private set => _person = value;
        }

        #endregion
    }
}