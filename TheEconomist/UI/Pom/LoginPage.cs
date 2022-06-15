using OpenQA.Selenium; 
using TheEconomist.UI.Pom.Base;

namespace TheEconomist.UI.Pom
{
     internal class LoginPage : BasePages
     {
          public LoginPage(IWebDriver driver) : base(driver)
          {
          }
          public IWebElement RegisterNow => Driver.FindElement(By.XPath("//a[text()='Register now']"));
     }
}
