using System;

namespace Exercício1
{
    class Program
    {
        static void Main()
        {
            int menu;

            do
            {
                Console.WriteLine("Digite uma das opções abaixo:\n");
                Console.WriteLine("1) Fatorial");
                Console.WriteLine("2) Exponenciação");
                Console.WriteLine("3) Porcentagem");
                Console.WriteLine("4) Área do triângulo");
                Console.WriteLine("5) Sair.");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Calculos c1 = new ();
                        Console.Write("Entre o número que você deseja calcular o fatorial: ");
                        c1.Numero = int.Parse(Console.ReadLine());
                        Console.Write("O resultado do fatorial recebido é: " + c1.Fatorial() + "\n\n");
                        break;
                    case 2:
                        Console.Clear();
                        Calculos c2 = new ();
                        Console.Write("Entre o número que você deseja calcular a exponenciação: ");
                        c2.NumeroRecebido = float.Parse(Console.ReadLine());
                        Console.Write("Entre o expoente do número: ");
                        c2.ExpoenteRecebido = int.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado da exponenciação é: " + c2.Exponenciacao() + "\n");
                        break;
                    case 3:
                        Console.Clear();
                        Calculos c3 = new ();
                        float numero;
                        float porcentagem;
                        Console.Write("Entre o número que você deseja calcular a porcentagem: ");
                        c3.NumeroRecebido2 = float.Parse(Console.ReadLine());
                        Console.Write("Entre a porcentagem: ");
                        c3.PorcentagemInt = float.Parse(Console.ReadLine());
                        numero = c3.NumeroRecebido2;
                        porcentagem = c3.PorcentagemInt;
                        Console.WriteLine("O número " + c3.Porcentagem() + " é " + porcentagem + "% de " + numero + ".\n");
                        break;
                    case 4:
                        Console.Clear();
                        Calculos c4 = new();
                        Console.Write("Entre a base do triângulo: ");
                        c4.Nase = float.Parse(Console.ReadLine());
                        Console.Write("Entre a altura do triângulo: ");
                        c4.Altura = float.Parse(Console.ReadLine());
                        Console.WriteLine("A área do triângulo é: " + c4.Area() + "\n");
                        break;
                    case 5:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Entre uma Opção Válida.\n");
                        break;
                }
            }
            while (menu != 5);
        }
    }
}
