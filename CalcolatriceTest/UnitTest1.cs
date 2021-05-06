using System;
using Xunit;
using AS2021_4H_TPSIT_BartoliniLiam_Calcolatrice;

namespace CalcolatriceTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Verifica l'operazione di somma
        /// </summary>
        [Fact]
        public void TestSomma()
        {
            Calcolatrice c = new();
            double risultato = c.Operazione(2, "+", 3);
            double risultatoAtteso = 5;
            Assert.Equal(risultatoAtteso, risultato);
        }

        /// <summary>
        /// Verifica l'operazione di prodotto
        /// </summary>
        [Fact]
        public void TestProdotto()
        {
            Calcolatrice c = new();
            double risultato = c.Operazione(2, "*", 4);
            double risultatoAtteso = 8;
            Assert.Equal(risultatoAtteso, risultato);
        }

        /// <summary>
        /// Verifica l'operazione di prodotto
        /// </summary>
        [Fact]
        public void TestDifferenza()
        {
            Calcolatrice c = new();
            double risultato = c.Operazione(2, "-", 4);
            double risultatoAtteso = 8;
            Assert.Equal(risultatoAtteso, risultato);
        }
    }
}