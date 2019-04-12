using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVc_2;
using System.Web;
using MVc_2.Controllers;
using MVc_2.Models;

namespace UnityTestOnlineStore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController hc = new HomeController();
            LoginViewModel LVM = new LoginViewModel();
            var Customer = LVM as LoginViewModel;
            LoginViewModel loginView = (LoginViewModel)LVM;
            Assert.AreEqual(LVM, loginView);
        }
    }
}
