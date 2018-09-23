using System;
using System.Runtime.Serialization;

namespace MineSweeperServer {

    [DataContract]
    public class PlayerExistsFault
    {
        [DataMember]
        public string Message { get; set; }
    }
}