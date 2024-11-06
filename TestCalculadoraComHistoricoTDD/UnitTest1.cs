using CalculadoraComHistoricoTDD;

namespace TestCalculadoraComHistoricoTDD
{
    public class UnitTest1
    {

        public Calculadora ConstruirClasse()
        {
            string data = "02/02/2024";
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }

        [Theory]
        [InlineData(5,7,12)]
        [InlineData(5, 4, 9)]
        public void TesteSomar(int num1, int num2,int resultado)
        {

            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoEsperado = calc.Somar(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(9, 4, 5)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {

            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoEsperado = calc.Subtrair(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(3, 4, 12)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {

            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoEsperado = calc.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 3)]
        public void TesteDividir(int num1, int num2, int resultado)
        {

            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoEsperado = calc.Dividir(num1, num2);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calculadora = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calculadora.Dividir(3, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 5);
            calc.Somar(2, 8);
            calc.Somar(3, 5);
            calc.Somar(4, 3);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }


    }
}