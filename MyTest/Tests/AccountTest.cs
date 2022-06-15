using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTest.Tests.Base;

namespace MyTest.Tests
{
     [TestClass]
     public class AccountTest : EconomistBase
     {

          [TestMethod]
          public void AccountFields()

          {

               HomeActions.Navigate("https://www.economist.com/");
               HomeActions.AcceptCookie();
               RegistrationActions.InitRegistration();
               RegistrationActions.Register("Nastea", "Pantelei", "nastikaemaildemo1@mailinator.com", "passwordnew111");
               HomeActions.EconomistAccount();
               Assert.IsTrue(AccountActions.GetFirstname("Nastea"));
               Assert.IsTrue(AccountActions.GetLastname("Pantelei"));
               Assert.IsTrue(AccountActions.GetEmail("nastikaemaildemo1@mailinator.com"));


          }
     }
}
