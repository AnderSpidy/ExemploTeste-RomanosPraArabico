using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TesteDosRomanosPraArabico.Test
{
    [TestClass]
    public class UnitTest1
    {
        private ConversorTeste conversor;

        public UnitTest1()
        {
            this.conversor = new ConversorTeste();
        }
        
        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("li", 51)]
        [DataRow("CLIX", 159)]
        [DataRow("MMMCMXCIX", 3999)]
       

        public void TesteConversor(string numero, int resultadoEsperado)
        {
            //cenário - arrange
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterRomano(numeroRomano);

            //verificação - assert
           Assert.AreEqual(resultadoEsperado, resultado);

        }
    }

    [TestClass]
    public class UnitTest2
    {
        private ConversorTeste conversor;

        public UnitTest2()
        {
            this.conversor = new ConversorTeste();
        }

        [TestMethod]
        [DataRow(10,"X")]
        [DataRow(15, "XV")]
        [DataRow(1500,"MD")]
        [DataRow(1560,"MDLX")]
        [DataRow(3,"III")]
        [DataRow(4,"IV")]
        [DataRow(1569,"MDLXIX")]
        [DataRow(1999,"MCMXCIX")]
        [DataRow(3999,"MMMCMXCIX")]
      



        public void TesteArabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);

        }
    }
}

            