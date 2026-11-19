
using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
            numero = int.Parse(Console.ReadLine());

        } while (numero < 0 || numero > 9);

        if (numero == 0)
        {
            Console.WriteLine("\nOperação cancelada.");
        }
        else
        {
            Console.WriteLine("\nNúmero selecionado = " + numero);
        }

        Console.WriteLine("\nVolte sempre!");
    }
}

