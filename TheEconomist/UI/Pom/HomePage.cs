using OpenQA.Selenium;
using TheEconomist.UI.Pom.Base;
using TheEconomist.UI.Pom.Popups;

namespace TheEconomist.UI.Pom
{
     public class HomePage : BasePages
     {
          public HomePage(IWebDriver driver) : base(driver)
          {
          }
          public IWebElement LoginButton => Driver.FindElement(By.XPath("//a[@href='/api/auth/login']"));
          public IWebElement MyEconomist => Driver.FindElement(By.XPath("//div[text()='My Economist']"));
          public IWebElement AccountButton=> Driver.FindElement(By.XPath("//span[text()='Account']"));
          public CookiePopup CookiePopup => new CookiePopup(Driver);
     }
}
