using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarIgualdad_CuandoSonIguales_DeberiaRetornarTrue()
        {
            Cliente cliente1 = new Cliente(41065660, "federico", "gomez", "mail@mail.com", Cliente.TipoFactura.A);
            Cliente cliente = new Cliente(41065660, "federico", "gomez", "mail@mail.com", Cliente.TipoFactura.A);
            bool expected = true;

            bool actual = cliente1 == cliente;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarIgualdad_CuandoSonDistintos_DeberiaRetornarTrueFalse()
        {
            Cliente cliente1 = new Cliente(41065660, "federico", "gomez", "mail@mail.com", Cliente.TipoFactura.A);
            Cliente cliente = new Cliente(41065660, "federico", "gomez", "mail@mail.com", Cliente.TipoFactura.A);
            bool expected = false;

            bool actual = cliente1 != cliente;

            Assert.AreEqual(expected, actual);
        }
    }
}
