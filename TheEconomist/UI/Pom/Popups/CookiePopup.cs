using OpenQA.Selenium;
using TheEconomist.UI.Pom.Base;
  

namespace TheEconomist.UI.Pom.Popups
{
     public class CookiePopup : BasePages
     {
          public CookiePopup(IWebDriver driver) : base(driver)
          {
               Driver.SwitchTo().DefaultContent().SwitchTo().Frame(Frame);
          }
          public IWebElement AcceptCookie => Driver.FindElement(By.XPath("//button[@title='Accept']"));
          public IWebElement Frame => Driver.FindElement(By.XPath("//iframe[@title='SP Consent Message']"));
     }
}
