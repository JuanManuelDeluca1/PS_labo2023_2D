using Entidades;
using System;
namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DescontarKilos_QueDevuelvaBienElResultado()
        {
            Carne carne = new Carne("Asado", 500, 4);
            CarniceriaE carniceria = new CarniceriaE("Pep");
            double kilosEsperados = 2;

            carniceria.DesconcarKilos(carne, 2);

            //Assert.IsTrue(kilosEsperados > carne.StockKilo);
            Assert.AreEqual(kilosEsperados, carne.StockKilo);
        }
        [TestMethod]
        public void ModificarCarne_QueModifiqueBien()
        {
            Carne carne = new Carne("Milanesa", 1000, 7);
            CarniceriaE carniceria = new CarniceriaE("Pep");
            Carne carne2 = new Carne("Milanesa", 900, 3); ;

            carniceria.ModificarCarne(carne, 3, 900);

            Assert.IsTrue(carne.StockKilo == carne2.StockKilo && carne.PrecioKilo == carne2.PrecioKilo);
        }
        [TestMethod]

        public void Montototal_SiEsCreditoQueHagaLaRecarga()
        {
            Cliente cliente = new Cliente("toni23@gmail.com", "qqwer", "Credito", 1000);
            double monto = 950;

            Assert.AreEqual(cliente.MontoPago, monto);
        }

    }
}