using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APITest;
using APITest.BusinessLogic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UserObjectNotNullTest()
        {
            User user = new User();
            UserLogic logic = new UserLogic();
            user = logic.GetUser();
            Assert.IsNotNull(user);

        }

        [TestMethod]
        public void UserIsAdmin()
        {
            User user = new User();
            UserLogic logic = new UserLogic();
            user = logic.GetUser();
            

            Assert.IsNotNull(user.UserRole);
            Assert.AreEqual("Administrator", user.UserRole.Name);


        }
    }
}
