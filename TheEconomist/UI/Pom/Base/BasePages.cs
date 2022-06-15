 
using OpenQA.Selenium;

namespace TheEconomist.UI.Pom.Base
{
     public class BasePages
     {
          protected IWebDriver Driver;

          protected BasePages(IWebDriver driver)
          {
               Driver = driver;
          }

          public void Navigate(string url) { Driver.Navigate().GoToUrl(url); }

          public void SwitchToDefault()
          {
               Driver.SwitchTo().DefaultContent();
          }
     }
}
