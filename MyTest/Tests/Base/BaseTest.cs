using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
namespace MyTest.Tests.Base
{
     [TestClass]
     public abstract class BaseTest
     {
          protected IWebDriver Driver; 
          [TestInitialize]
          public void TestInit()
          {
               new DriverManager().SetUpDriver(new ChromeConfig(), "MatchingBrowser");
               Driver = new ChromeDriver();
               Driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
               Driver.Manage().Window.Maximize();
               Initialize();
          }

          [TestCleanup]
          public void Cleanup()
          {
               Driver.Quit();
          }

          protected abstract void Initialize();
     }
}
