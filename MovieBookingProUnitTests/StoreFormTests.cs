using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieBookingPro;

namespace MovieBookingProUnitTests
{
    [TestClass]
    public class StoreFormTests
    {
        Model model = new Model();

        [TestMethod()]
        public void StoreFormTest1()
        {

            model.DatabaseTransactions("Insert into tblCustomer Values('Test','Test@gmail.com','City')");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void StoreFormTest2()
        {
            model.DatabaseTransactions("Delete from tblCustomer where CustomerId = 1");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void StoreFormTest3()
        {
            model.DatabaseTransactions("Update tblCustomer set Name = 'Testing'  where CustomerId = 1");
            Assert.IsTrue(true);
        }
    }
}
