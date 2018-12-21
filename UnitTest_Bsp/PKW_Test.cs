using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace UnitTest_Bsp
{
    //UNIT-TESTS sind kleinteilige Software-Tests, welche jeweils zum Testen einer einzige Funktion gedacht sind. Ausgeführt werden sie
    ///über den Test-Explorer
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_Test_SchnellerAlsMaxG()
        {
            PKW pkw = new PKW("BMW", 230, 25000.0, 3);
            pkw.StarteMotor();
            pkw.Beschleunige(300);

            //Dies ASSERT-Klasse enthält diverse Vergleichsmethoden, welche in Unit-Tests verwendet werden können. Pro Test-Methode
            ///muss es mindesten einen Assert-Aufruf geben
            Assert.AreEqual(230, pkw.AktGeschwindigkeit);
        }
    }
}
