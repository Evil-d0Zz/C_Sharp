using System;

namespace perm_festa
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
			Console.Write("Digite sua idade: ");
			idade = Convert.ToInt32(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine($"Voce tem: {idade} anos! Permissão Concedida!"); 

            } else {
                Console.WriteLine($"Você têm {idade} anos! Permissão Negada!");
            }
			    
        } 
    }
}
