using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using api_Operacion;
using api_Operacion.Controllers;

namespace api_Operacion.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
