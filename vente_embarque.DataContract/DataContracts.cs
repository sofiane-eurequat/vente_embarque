using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace vente_embarque.DataContract
{
    public class DataContracts
    {
        [DataContract]
        public abstract class Response
        {
            [DataMember]
            public bool Success { get; set; }

            [DataMember]
            public string Message { get; set; }
        }
    }

    [DataContract]
    public class StockResponse:DataContracts.Response
    {
        [DataMember]
       
    }
}
