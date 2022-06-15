using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTest.Tests.Base;

namespace MyTest.Tests
{
     [TestClass]
     public class EconomistTest : EconomistBase
     {
          [TestMethod]
          public void RegistrationTest()
          {
               HomeActions.Navigate("https://www.economist.com/");
               HomeActions.AcceptCookie();
               RegistrationActions.InitRegistration();
               RegistrationActions.Register("Nastea", "Pantelei", "nastikaemaildemo2@mailinator.com", "passwordnew111");
               HomeActions.EconomistAccount();
               Assert.IsTrue(AccountActions.GetFirstname("Nastea"));
               Assert.IsTrue(AccountActions.GetLastname("Pantelei"));
               Assert.IsTrue(AccountActions.GetEmail("nastikaemaildemo2@mailinator.com"));


          }
     }
}
