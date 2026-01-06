using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void RemoveNegativeNumbers_FromList_ReturnsListWithoutNegativeNumbers()
    {
        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };
        var expected = new List<int> { 5, 9 };

        // Act
        var actual = _validacoes.RemoverNumerosNegativos(list);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ListContainsSpecificNumber_ContainNumberNine_ReturnsTrue()
    {
        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };
        var numberForSearch = 9;

        // Act
        var actual = _validacoes.ListaContemDeterminadoNumero(list, numberForSearch);

        // Assert
        Assert.True(actual);
    }

    [Fact]
    public void ListContainsSpecificNumber_NotContainNumberTen_ReturnsFalse()
    {
        //TODO: Implementar método de teste

        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };
        var numberForSearch = 10;

        // Act
        var actual = _validacoes.ListaContemDeterminadoNumero(list, numberForSearch);

        // Assert
        Assert.False(actual);
    }

    //TODO: Corrigir a anotação [Fact]
    public void MultiplyNumbersInList_MultiplyElementsBy2_ReturnsMultipliedList()
    {
        //TODO: Implementar método de teste

        // Arrange
        var list = new List<int> { 5, 7, 8, 9 };
        var expected = new List<int> { 10, 14, 16, 18 };
        var mutiplier = 2;

        // Act
        var actual = _validacoes.MultiplicarNumerosLista(list, mutiplier);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReturnsMaxNumberInList_NumberNine_ReturnsNine()
    {
        //TODO: Implementar método de teste

        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };

        // Act
        var actual = _validacoes.RetornarMaiorNumeroLista(list);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, actual);
    }

    [Fact]
    public void ReturnsMinNumberInList_NumberNegativeEight_ReturnsNegativeEight()
    {
        //TODO: Implementar método de teste

        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };

        // Act
        var actual = _validacoes.RetornarMenorNumeroLista(list);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, actual);
    }
}
