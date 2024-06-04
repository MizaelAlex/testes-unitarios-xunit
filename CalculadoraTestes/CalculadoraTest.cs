using System.ComponentModel;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    public void Somar2Numeros(int num1, int num2, int resultado)
    {
        CalculadoraImp _calc = new CalculadoraImp();

        int resultadoCalculadora = _calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData(1, 2, -1)]
    public void Subtrair2Numeros(int num1, int num2, int resultado)
    {
        CalculadoraImp _calc = new CalculadoraImp();

        int resultadoCalculadora = _calc.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData(1, 2, 2)]
    public void Multiplicar2Numeros(int num1, int num2, int resultado)
    {
        CalculadoraImp _calc = new CalculadoraImp();

        int resultadoCalculadora = _calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData(4, 2, 2)]
    public void Dividir2Numeros(int num1, int num2, int resultado)
    {
        CalculadoraImp _calc = new CalculadoraImp();

        int resultadoCalculadora = _calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPor0()
    {
        CalculadoraImp _calc = new CalculadoraImp();

        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(2,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraImp _calc = new CalculadoraImp();

        _calc.Somar(1, 2);
        _calc.Somar(3, 4);
        _calc.Somar(5, 6);
        _calc.Somar(7, 8);
        _calc.Somar(9, 10);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}