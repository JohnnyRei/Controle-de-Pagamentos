using System;

class Program
{
    static void Main()
    {
  
        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine();

        Console.Write("Valor total da compra R$: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor pago R$: ");
        double valorPago = Convert.ToDouble(Console.ReadLine());

        if (valorPago < valorCompra)
        {
            Console.WriteLine("Valor insuficiente para realizar a compra!");
        }
        else
        {

            double troco = valorPago - valorCompra;
            Console.WriteLine($"Troco: {troco:C}");

            int[] notas = { 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] quantidadeNotas = new int[notas.Length];

            for (int i = 0; i < notas.Length; i++)
            {
                quantidadeNotas[i] = (int)(troco / notas[i]);
                troco %= notas[i];
            }

            Console.WriteLine($"Nome: {nome}");

            Console.WriteLine($"Valor total da compra R$: {valorCompra:F}");

            Console.WriteLine($"Valor Pago R$: {valorPago:F}");

            for (int i = 0; i < notas.Length; i++)
            {
                if (quantidadeNotas[i] > 0)
                {
                    Console.WriteLine($"Notas de {notas[i]}: {quantidadeNotas[i]}");
                }
            }
        }
    }
}
