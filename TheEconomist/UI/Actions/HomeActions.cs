 
using TheEconomist.UI.Pom;
using OpenQA.Selenium;

namespace TheEconomist.UI.Actions
{
     public class HomeActions
     {
          private readonly HomePage HomePage;

          public HomeActions(IWebDriver driver)
          {
               HomePage = new HomePage(driver);
          }
          public void Navigate(string url)
          {
               HomePage.Navigate(url);
          }
          public void AcceptCookie()
          {
               HomePage.CookiePopup.AcceptCookie.Click();
               HomePage.SwitchToDefault();
          }

          public void EconomistAccount()
          {
               HomePage.MyEconomist.Click();
               HomePage.AccountButton.Click();
          }
     }
}
