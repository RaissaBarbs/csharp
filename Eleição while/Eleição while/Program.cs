using System;

namespace Eleição_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições 2022");
            int cand26 = 0;
            int cand44 = 0;
            int cand56 = 0;
            int qntnulo = 0;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Qual o seu nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Vote em um dos cndidatos a seguir:");
                Console.WriteLine("-26- Guilherme");
                Console.WriteLine("-44- Natan");
                Console.WriteLine("-56- Leandra");
                Console.WriteLine("-0- Nulo");
                Console.WriteLine("Só digite o número:");
                int meuVoto = Convert.ToInt32(Console.ReadLine());

                if (meuVoto == 26) { cand26 = cand26 + 1; }
                else if (meuVoto == 44) { cand44 = cand44 + 1; }
                else if (meuVoto == 56) cand56 = cand56 + 1; }
                else qntnulo = qntnulo + 1;

                Console.WriteLine("Deseja continuar?[sim/não]" );
                string resposta = Console.ReadLine();
            //if {resposta=="sim"} else {continuar= false;};
            if (resposta == "sim" ? continuar = true : continuar = false;

            //proxima linha

              


            }
          
        }
    }
}
