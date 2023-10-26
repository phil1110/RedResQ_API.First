using System;

namespace RedResQ_API.Lib.Models
{
    public class Session
    {
        #region Constructor

        public Session(int id, string deviceId,Person person)
        {
            Id = id;
            DeviceId = deviceId;
            Person = person;
        }

        #endregion

        #region Properties

        public int Id { get; private set; }

        public string DeviceId { get; private set; }

        public Person Person { get; private set; }

        #endregion
    }
}