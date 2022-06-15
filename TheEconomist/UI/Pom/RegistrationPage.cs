using OpenQA.Selenium; 

namespace TheEconomist.UI.Pom
{
     internal class RegistrationPage : HomePage
     {
          public RegistrationPage(IWebDriver driver) : base(driver)
          {
          }

          //FIX HERE
          public IWebElement RegisterNow => Driver.FindElement(By.XPath("//a[text()='Register now']"));
          public IWebElement Check => Driver.FindElement(By.XPath("//span[contains(@class,'checkbox')]"));
          public IWebElement SubmitButton => Driver.FindElement(By.XPath("//button[contains(@type,'submit')]"));
          public IWebElement FirstName => Driver.FindElement(By.XPath("//input[contains(@name,'firstname')]"));
          public IWebElement LastName => Driver.FindElement(By.XPath("//input[contains(@name,'lastname')]"));
          public IWebElement Email => Driver.FindElement(By.XPath("//input[contains(@name,'email')]"));
          public IWebElement Password => Driver.FindElement(By.XPath("//input[contains(@name,'password')]"));
           
     }
}
