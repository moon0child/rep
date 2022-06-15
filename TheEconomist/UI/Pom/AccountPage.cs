using OpenQA.Selenium;
 

namespace TheEconomist.UI.Pom
{
     public class AccountPage : HomePage
     {
          public AccountPage(IWebDriver driver) : base(driver)
          {
          } 
          public IWebElement FirstName => Driver.FindElement(By.XPath("//input[contains(@type,'firstname')]"));
          public IWebElement LastName => Driver.FindElement(By.XPath("//input[contains(@type,'lastname')]"));
          public IWebElement Email => Driver.FindElement(By.XPath("//input[contains(@name,'Email')]")); 

         
          public IWebElement GetField(string FieldName)
          {

               return Driver.FindElement(By.XPath($"//input[@autocomplete='{FieldName}']"));
          }

         

     }
}
