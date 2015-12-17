using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using OdeToFood.Controllers;

namespace OdeToFood.Tests
{

    public class HomeControllerTest
    {
        [Test]
        public void About()
        {
            HomeController  controller = new HomeController();

            ViewResult result = controller.About() as ViewResult;

            Assert.IsNotNull(result.Model);
        }
    }
}
