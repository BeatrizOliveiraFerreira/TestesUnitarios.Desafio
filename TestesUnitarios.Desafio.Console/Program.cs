using Xunit;
using TrilhaTarefas;

namespace TrilhaTarefasTests
{
    public class ValidacoesListaTests
    {
        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            var lista = new int[] { -1, 2, -3, 4, -5 };

            // Act
            var resultado = ValidacoesLista.RemoverNumerosNegativos(lista);

            // Assert
            Assert.All(resultado, num => Assert.True(num > 0));
        }

        // Implemente os demais métodos de teste da classe ValidacoesListaTests
    }

    public class ValidacoesStringTests
    {
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            var texto = "Matrix";

            // Act
            var resultado = ValidacoesString.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(6, resultado);
        }

        // Implemente os demais métodos de teste da classe ValidacoesStringTests
    }
}

