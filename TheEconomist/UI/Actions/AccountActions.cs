using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEconomist.UI.Pom;

namespace TheEconomist.UI.Actions
{
      
     public class AccountActions
     {
          private  AccountPage accountPage;
       

          public AccountActions(IWebDriver driver)
          {
               accountPage = new AccountPage(driver);
          }

          public bool GetFirstname(string firstname)
          {
               return accountPage.GetFieldFirstName(firstname).Displayed;
          }
           
          public bool GetLastname(string lastname)
          {
               return accountPage.GetFieldLastname(lastname).Displayed;
          }
          public bool GetEmail(string email)
          {
               return accountPage.GetFieldEmail(email).Displayed;
          }
           
     }
}
