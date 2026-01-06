using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void ReturnsCharacterCount_WordWith6Characters_ReturnsSix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var text = "afonso";

        // Act
        var actual = _validacoes.RetornarQuantidadeCaracteres(text);

        // Assert
        Assert.Equal(6, actual);
    }

    [Fact]
    public void ContainsCharacter_ContainAny_ReturnsTrue()
    {
        // Arrange
        var text = "Esse é um texto qualquer";
        var searchedText = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         var actual = _validacoes.ContemCaractere(text, searchedText);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(actual);
    }

    [Fact]
    public void ContainsCharacter_NotContainTestWord_ReturnsFalse()
    {
        // Arrange
        var text = "Esse é um texto qualquer";
        var searchedText = "teste";

        // Act
        var actual = _validacoes.ContemCaractere(text, searchedText);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(actual);
    }

    //TODO: Corrigir a anotação [Fact]
    public void TextEndsWith_TextEndsWithSearchedWord_RetornsTrue()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var text = "Começo, meio e fim do texto procurado";
        var searchedText = "procurado";

        // Act
        var actual = _validacoes.TextoTerminaCom(text, searchedText);

        // Assert
        Assert.True(actual);
    }
}
