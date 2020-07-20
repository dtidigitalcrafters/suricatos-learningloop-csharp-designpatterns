using System;

public class Program
{
    public static void Main(string[] args)
    {
        var x = new Anulavel<bool>();
        Console.WriteLine(x.PossuiValor());
        Console.WriteLine(x);

        var y = new Anulavel<int>(5);
        Console.WriteLine(y.PossuiValor());
        Console.WriteLine(y);
    }
}

public class Anulavel<T>
{

    private object _valor = null;

    public Anulavel() { }

    public Anulavel(T valor)
    {
        _valor = valor;
    }

    public T Valor() => (T)_valor;

    public bool PossuiValor() => _valor != null;

    public override string ToString() =>
        _valor?.ToString();

}