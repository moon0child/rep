using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEconomist.UI.Pom;
using OpenQA.Selenium;

namespace TheEconomist.UI.Actions
{
     public class HomeActions
     {
          private readonly HomePage homePage;

          public HomeActions(IWebDriver driver)
          {
               homePage = new HomePage(driver);
          }
          public void Navigate(string url)
          {
               homePage.Navigate(url);
          }
          public void AcceptCookie()
          {
               homePage.CookiePopup.AcceptCookie.Click();
               homePage.SwitchToDefault();
          }

          public void EconomistAccount()
          {
               homePage.myEconomist.Click();
               homePage.accountButton.Click();
          }
     }
}
