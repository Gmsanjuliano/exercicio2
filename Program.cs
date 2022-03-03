using System;

namespace C_
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Indorme o valor em USD$: ");
      string valorDigitado = Console.ReadLine();
      decimal valorConvertido = 0.0m, valorCambio = 5.22m;

      decimal.TryParse(valorDigitado, out valorConvertido);

      decimal valorCambioConvertido = valorConvertido * valorCambio;

      Console.WriteLine($"valor em $: {valorCambioConvertido}");
      Console.ReadLine();
    }
  }
}