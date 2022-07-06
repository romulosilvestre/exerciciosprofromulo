using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolhinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declaração de variáveis
            string nomeDoAluno,resultado;
            double nota1, nota2, nota3;
            double media;

            //Entrada de Dados
            Console.WriteLine("Abençoado qual o seu nome:");
            nomeDoAluno = Console.ReadLine();
            Console.WriteLine("Digite três notas");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;
            /*if (media >= 7)
            {
                resultado = "aprovado";
            }
            else
            {
                resultado = "reprovado";
            }*/
            resultado = media >= 7 ? "aprovado" : "reprovado";

            Console.WriteLine($"O aluno {nomeDoAluno} obteve a média {media} e foi {resultado}");

            /*
            string[] alunos = { "João", "Maria", "José","Rômulo","Ramon","Bruno","William","Yedo","Jeferson" };
            //Console.WriteLine(alunos[1]);
            int cont=0;
            foreach (var item in alunos)
            {
                int r = item.StartsWith("R") ? cont++ : 0;

            }
            Console.WriteLine($"Foram {cont} alunos que tem o nome iniciando com a letra R ");

            foreach (var item in alunos)
            {
                if (item.StartsWith("R"))
                {
                    Console.WriteLine(item);
                }
                
            }*/
            Console.ReadKey();

            
        }
      
    }
}
