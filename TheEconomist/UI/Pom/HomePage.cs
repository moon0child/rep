using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEconomist.UI.Pom.Base;
using TheEconomist.UI.Pom.Popups;

namespace TheEconomist.UI.Pom
{
     public class HomePage : BasePages
     {
          public HomePage(IWebDriver driver) : base(driver)
          {
          }
          public IWebElement loginButton => Driver.FindElement(By.XPath("//a[@href='/api/auth/login']"));
          public IWebElement myEconomist => Driver.FindElement(By.XPath("//div[text()='My Economist']"));
          public IWebElement accountButton=> Driver.FindElement(By.XPath("//span[text()='Account']"));
          public CookiePopup CookiePopup => new CookiePopup(Driver);
     }
}
