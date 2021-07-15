using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcsBackend.Utiles;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void parrafoVacio()
        {
            string parrafo = "";
            var result = Utiles.words(parrafo);
            Assert.AreEqual("El parrafo es obligatorio", result);
        }
    }
}
