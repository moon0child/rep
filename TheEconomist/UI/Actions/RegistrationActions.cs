 
using TheEconomist.UI.Pom;
using OpenQA.Selenium;
namespace TheEconomist.UI.Actions
{
     public class RegistrationActions
     {
          private readonly HomePage HomePage;
          private readonly LoginPage LoginPage;
          private readonly RegistrationPage RegistrationPage;

          public RegistrationActions(IWebDriver driver)
          {
               HomePage = new HomePage(driver); ;
               LoginPage = new LoginPage(driver);
               RegistrationPage = new RegistrationPage(driver); 
          }

          public void InitRegistration()
          {
               HomePage.LoginButton.Click();
               LoginPage.RegisterNow.Click();
          }

          public void Register(string FirstName, string LastName,string Email, string Password)
          {
               //  registrationPage.Email.SendKeys(email);//FIX

               RegistrationPage.FirstName.SendKeys(FirstName);
               RegistrationPage.LastName.SendKeys(LastName);
               RegistrationPage.Email.SendKeys(Email);
               RegistrationPage.Password.SendKeys(Password);
               RegistrationPage.Check.Click();
               RegistrationPage.SubmitButton.Click();

          }
     }
}
