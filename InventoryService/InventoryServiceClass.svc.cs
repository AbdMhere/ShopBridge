using System;
using System.Collections.Generic;

namespace InventoryService
{
    /// <summary>
    /// Service class
    /// NOTE:All the methods here GETDATA,ADD,MODIFY and DELETE 
    /// used a local data list for demonstration 
    /// instead we can also use ADO connection to work with SQL databases as needed.
    /// </summary>
    public class InventoryServiceClass : IInventoryService
    {
        public List<Inventory> GetData()
        {
            return PopulateInventoryData();
        }

        /// <summary>
        /// AddData
        /// </summary>
        /// <param name="composite"></param>
        /// <returns>true if successful</returns>
        public bool AddData(Inventory composite)
        {
            List<Inventory> lstinventory = new List<Inventory>();
            try
            {
                lstinventory.Add(composite);
            }
            catch (Exception ex)
            {
                //Log exception ex
            }
            finally
            {
                //Clean up like close connections
            }
            return true;
        }

        /// <summary>
        /// ModifyData
        /// </summary>
        /// <param name="composite"></param>
        /// <returns>true if successful</returns>
        public bool ModifyData(Inventory composite)
        {
            List<Inventory> lstinventory = PopulateInventoryData();
            try
            {
                var inv = lstinventory.Find(i => i.Name == composite.Name);
                inv.Description = composite.Description;
                inv.Category = composite.Category;
                inv.Price = composite.Price;
            }
            catch (Exception ex)
            {
                //Log exception ex
            }
            finally
            {
                //Clean up like close connections
            }
            return true;
        }

        /// <summary>
        /// DeleteData
        /// </summary>
        /// <param name="composite"></param>
        /// <returns>true if successful</returns>
        public bool DeleteData(Inventory composite)
        {
            try
            {
                List<Inventory> lstinventory = PopulateInventoryData();
                lstinventory.Remove(composite);
            }
            catch (Exception ex)
            {
                //Log exception ex
            }
            finally
            {
                //Clean up like close connections
            }
            return true;
        }

        /// <summary>
        /// PopulateInventoryData
        /// </summary>
        /// <returns>List<Inventory></returns>
        private List<Inventory> PopulateInventoryData()
        {
            List<Inventory> lstinventory = new List<Inventory>();

            Inventory inventory1 = new Inventory();

            inventory1.Name = "Samsung";

            inventory1.Description = "Samsung Television";

            inventory1.Price = 10000;

            inventory1.Category = "Television";

            lstinventory.Add(inventory1);

            Inventory inventory2 = new Inventory();

            inventory2.Name = "WhrilPool";

            inventory2.Description = "WhrilPool Refrigerator";

            inventory2.Price = 20000;

            inventory2.Category = "Refrigerator";

            lstinventory.Add(inventory2);

            return lstinventory;
        }
    }
}
