using OpenQA.Selenium; 
using TheEconomist.UI.Pom;

namespace TheEconomist.UI.Actions
{
      
     public class AccountActions
     {
          private  AccountPage AccountPage;
       

          public AccountActions(IWebDriver driver)
          {
               AccountPage = new AccountPage(driver);
          }
           
          public bool GetFirstname(string FirstName)
          {
               return AccountPage.GetField(FirstName).Displayed;
          }
           
          public bool GetLastname(string LastName)
          {
               return AccountPage.GetField(LastName).Displayed;
          }
          public bool GetEmail(string Email)
          {
               return AccountPage.GetField(Email).Displayed;
          }
           
     }
}
