using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace InventoryService
{
    /// <summary>
    /// InventoryService Interface
    /// </summary>
    [ServiceContract]
    public interface IInventoryService
    {

        [OperationContract]
        List<Inventory> GetData();

        [OperationContract]
        bool AddData(Inventory composite);

        [OperationContract]
        bool ModifyData(Inventory composite);

        [OperationContract]
        bool DeleteData(Inventory composite);

    }


    [DataContract]
    public class Inventory
    {
        [DataMember]
        public string Name
        {
            get; set;
        }

        [DataMember]
        public string Description
        {
            get; set;
        }

        [DataMember]
        public Int32 Price
        {
            get; set;
        }

        [DataMember]
        public string Category
        {
            get; set;
        }
    }
}
