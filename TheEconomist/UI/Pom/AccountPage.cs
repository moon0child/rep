using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEconomist.UI.Pom
{
     public class AccountPage : HomePage
     {
          public AccountPage(IWebDriver driver) : base(driver)
          {
          } 
          public IWebElement firstName => Driver.FindElement(By.XPath("//input[contains(@type,'firstname')]"));
          public IWebElement lastName => Driver.FindElement(By.XPath("//input[contains(@type,'lastname')]"));
          public IWebElement email => Driver.FindElement(By.XPath("//input[contains(@name,'Email')]"));
          public IWebElement phoneNumber => Driver.FindElement(By.XPath("//input[contains(@type,'phone')]"));

         
          public IWebElement GetFieldFirstName(string firstname)
          {

               return Driver.FindElement(By.XPath($"//input[@autocomplete='{firstname}']"));
          }

          public IWebElement GetFieldLastname(string lastname)
          {
               return Driver.FindElement(By.XPath($"//input[@autocomplete='{lastname}']"));
          }
          public IWebElement GetFieldEmail(string email)
          {
               return Driver.FindElement(By.XPath($"//input[@autocomplete='{email}']"));
          }

     }
}
