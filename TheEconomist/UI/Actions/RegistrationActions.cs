using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEconomist.UI.Pom;
using OpenQA.Selenium;
namespace TheEconomist.UI.Actions
{
     public class RegistrationActions
     {
          private readonly HomePage homePage;
          private readonly LoginPage loginPage;
          private readonly RegistrationPage registrationPage;

          public RegistrationActions(IWebDriver driver)
          {
               homePage = new HomePage(driver); ;
               loginPage = new LoginPage(driver);
               registrationPage = new RegistrationPage(driver);//FIX HERE
          }

          public void InitRegistration()
          {
               homePage.loginButton.Click();
               loginPage.RegisterNow.Click();
          }

          public void Register(string firstname, string lastname,string email, string password)
          {
               //  registrationPage.Email.SendKeys(email);//FIX

               registrationPage.FirstName.SendKeys(firstname);
               registrationPage.LastName.SendKeys(lastname);
               registrationPage.Email.SendKeys(email);
               registrationPage.Password.SendKeys(password);
               registrationPage.Check.Click();
               registrationPage.SubmitButton.Click();

          }
     }
}
