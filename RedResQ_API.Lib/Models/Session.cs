using System;

namespace RedResQ_API.Lib.Models
{
    public class Session
    {
        #region Instance variables

        private int _id;
        private string _deviceId;
        private Person _person;

        #endregion

        #region Constructor

        public Session(int id, string deviceId,Person person)
        {
            Id = id;
            _deviceId = deviceId;
            Person = person;
        }

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string DeviceId
        {
            get => _deviceId;
            private set => _deviceId = value;
        }

        public Person Person
        {
            get => _person;
            private set => _person = value;
        }

        #endregion
    }
}