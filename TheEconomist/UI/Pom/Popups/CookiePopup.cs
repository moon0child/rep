using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEconomist.UI.Pom.Base;
using OpenQA.Selenium;

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
