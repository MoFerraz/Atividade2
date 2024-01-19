using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sortear um número aleatório dentro da range definida 

            int numeroSorteado;

            Random rdm = new Random();
            numeroSorteado = rdm.Next(3);
          
            // Solicitar ao usuário a primeira tentativa de acerto do número sorteado

            int primeiraTentativa;

            Console.WriteLine("Vamos para a primeira tentativa!");
            Console.WriteLine("Digite o número que você aredita que foi o sorteado: ");

            primeiraTentativa = int.Parse(Console.ReadLine());

            // Criar as condições If/else


            if (primeiraTentativa == numeroSorteado)
            {
                Console.WriteLine("Parabéns!!Você acertou de primeira!! ");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (primeiraTentativa < numeroSorteado)
                Console.WriteLine(" O número sorteado é maior que o número digitado ");
            else
            { 
                Console.WriteLine("O número sorteado é menor que o número digitado ");
                Console.WriteLine("Vamos para a segunda tentaiva ");
            }

            // Solicitar ao usuário a segunda tentativa de acerto do número sorteado

            int segundaTentativa;

            Console.WriteLine("Digite o número que você aredita que foi o sorteado: ");

            segundaTentativa = int.Parse(Console.ReadLine());

            // Criar as condições If/else

            if (segundaTentativa == numeroSorteado)
            {
                Console.WriteLine("Parabéns!!Você acertou de segunda!! ");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else if (segundaTentativa < numeroSorteado)
                Console.WriteLine(" O número sorteado é maior que o número digitado ");
            else
            {
                Console.WriteLine("O número sorteado é menor que o número digitado ");
                Console.WriteLine("Vamos para a terceira tentaiva ");
            } 

            // Solicitar ao usuário a terceira tentativa de acerto do número sorteado

            int terceiraTentativa;

            Console.WriteLine("Digite o número que você aredita que foi o sorteado: ");

            terceiraTentativa = int.Parse(Console.ReadLine());

            // Criar as condições If/else

            if (terceiraTentativa == numeroSorteado)
            {
                Console.WriteLine("Parabéns!!Você acertou na última tentativa!! ");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
                Console.WriteLine("Que pena...não foi dessa vez! Tente novamente! ");

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
