using System;

namespace Atividade4
{
    internal class Program
    {
        static void Main()
        {
            while (true) // Loop para manter o menu ativo até o usuário escolher sair
            {
                // Exibe o menu de opções
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Exibir 'Olá, Mundo!'");
                Console.WriteLine("2 - Exibir 'Bem-vindo ao C#'");
                Console.WriteLine("3 - Sair do programa");

                // Lê a escolha do usuário
                Console.Write("Digite sua opção: ");
                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número entre 1 e 3.");
                    continue;
                }

                // Executa a ação correspondente à opção escolhida
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Olá, Mundo!");
                        break;
                    case 2:
                        Console.WriteLine("Bem-vindo ao C#!");
                        break;
                    case 3:
                        Console.WriteLine("Saindo do programa...");
                        return; // Encerra o programa
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha entre 1 e 3.");
                        break;
                }
            }
        }
    }
}
