using System;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10; // Variavel do tipo inteiro
            int num2 = 20;
            Console.WriteLine("Quanto é: " +num+ " + " +num2+ "?" ); // Input; pergunta quanto que é o numero 1 mais o numero 2
            
            int output = Convert.ToInt32(Console.ReadLine()); // converte uma variavel inteira para sting 

            if (output == 30) {
                Console.WriteLine("Parabens! Você acertou."); // Ultilizando Estrutura Condicional
            } else
            {
                Console.WriteLine("Você errou! Tente Novamente...");
            }
            
        }
    }
}
