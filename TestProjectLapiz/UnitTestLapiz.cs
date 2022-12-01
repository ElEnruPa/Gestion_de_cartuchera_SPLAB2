using Clases;

namespace TestProjectLapiz
{
    [TestClass]
    public class UnitTestLapiz
    {
        [TestMethod]
        public void LeerArchivoXml()
        {
            // Arrange
            Lapiz lapiz = new Lapiz("Marca", 100, "Color", "Trazo");
            Lapiz lapizEsperado;

            //Act
            lapizEsperado = lapiz.DeserializaXML();

            //Assert
            Assert.IsNotNull(lapizEsperado);
        }

        [TestMethod]
        public void ExtensionString()
        {
            // Arrange
            string prueba = String.Empty;

            //Act
            prueba = prueba.EscuchandoEvento();

            //Assert
            Assert.AreEqual("Se escucho el evento.", prueba);
        }
    }
}