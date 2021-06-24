using System;

namespace PropostaExercicio_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------Exercicio 1 --------------
            /*
             int temp;

             Console.WriteLine("Digite a senha");
             temp = int.Parse(Console.ReadLine());

             while(temp != 2002)
             {
                 Console.WriteLine("Senha invalida");
                 Console.WriteLine("Digite a senha");
                 temp = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("Acesso Permitido");
            */

            //-----------------Exercicio 2 --------------
            /*
            int x, y;

            Console.WriteLine("coordenada X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Coordenada Y: ");
            y = int.Parse(Console.ReadLine());

            while(x != 0 && y !=0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }else if(x<0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }else if(x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                Console.WriteLine("coordenada X: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Coordenada Y: ");
                y = int.Parse(Console.ReadLine());
            }
            */

            //-----------------Exercicio 3 --------------
            int x, alcool=0, gasolina=0, diesel=0;
            Console.WriteLine("Codigo: ");
            x = int.Parse(Console.ReadLine());

            while(x != 4)
            {
                if(x == 1)
                {
                    alcool++;
                }else if(x == 2)
                {
                    gasolina++;
                }else if(x == 3)
                {
                    diesel++;
                }
                Console.WriteLine("Codigo: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " +diesel);
        }

    }
}
