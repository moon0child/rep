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
               RegistrationActions.Register("Nastea", "Pantelei", "nastiushkaemaildemodemo@mailinator.com", "passwordnew111");


          }
     }
}
