using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoryService;

namespace InventoryServiceUT
{
    [TestClass]
    public class InventoryServiceClassUT
    {
        InventoryServiceClass svc;

        [TestInitialize]
        public void Initialize()
        {
            svc = new InventoryServiceClass();
        }

        [TestMethod]
        public void TestGetData()
        {
            var dt = svc.GetData();
            Assert.AreEqual(2, dt.Count);
        }

        [TestMethod]
        public void TestAddData()
        {
            Inventory composite = new Inventory();
            Assert.IsTrue(svc.AddData(composite));
        }

        [TestMethod]
        public void TestModifyData()
        {
            Inventory composite = new Inventory();
            Assert.IsTrue(svc.ModifyData(composite));
        }

        [TestMethod]
        public void TestDeleteData()
        {
            Inventory composite = new Inventory();
            Assert.IsTrue(svc.DeleteData(composite));
        }
    }
}
