using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TheEconomist.UI.Actions;

namespace MyTest.Tests.Base
{
     
     public class EconomistBase : BaseTest
     {
          protected HomeActions HomeActions;
          protected RegistrationActions RegistrationActions;
          protected AccountActions AccountActions;

          protected override void Initialize()
          {
               HomeActions=new HomeActions(Driver);
               RegistrationActions=new RegistrationActions(Driver);
               AccountActions = new AccountActions(Driver);
          }
     }
}
