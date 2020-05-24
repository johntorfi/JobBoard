using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Controlers;
namespace UnitTestProject2
{
    [TestClass]
    public class CandidatesControllerTest
    {
        [TestMethod]
        public void TestDetaiksView()
        {
            var controller = new CandidatesControllerTest();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);

        }
    }
}
