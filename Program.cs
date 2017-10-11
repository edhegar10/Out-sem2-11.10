using System;
using System.IO;

namespace a_Quarta
{
    class Program
    {
        static void Main(string[] args)
        {
           /*  INICIO ----- ARRAY IDADE ----- 
           int[] idades = new int[5];

           idades[0] = 1;
           idades[1] = 22; 
           idades[2] = 23;

           for(int i = 0; i< idades.Length; i++)
           {
               Console.WriteLine(idades[i]);
           }
                FIM ----- ARRAY IDADE -----
           */



           /* INICIO ----- ARRAY PERGUNTAS ARQUIVOS ----- 
           string[] perguntas = File.ReadAllLines(@"C:\Users\FIC\Desktop\CursoBackend\Outubro\sem2\11.10_Quarta\Out-sem2-11.10\perguntas.txt");
           string[] respostas = new string[perguntas.Length];

           for(int i = 0; i < perguntas.Length; i++)
           {
               Console.WriteLine("Qual " + perguntas[i] + ":");
               respostas[i] = Console.ReadLine();
           }
               FIM ----- ARRAY PERGUNTAS ARQUIVOS -----
           */

           string[] perguntas = File.ReadAllLines(@"C:\Users\FIC\Desktop\CursoBackend\Outubro\sem2\11.10_Quarta\Out-sem2-11.10\perguntas_des.txt");
           string[] respostas = new string[perguntas.Length];

           StreamWriter res = new StreamWriter("Resposta.csv", true);

           for(int i = 0; i < perguntas.Length; i++)
           {
               Console.WriteLine("Qual " + perguntas[i] + ":");
               respostas[i] = Console.ReadLine();

               
               res.Write(respostas[i] + ";");
               
           }
           res.WriteLine();
           res.Close();

        }
    }
}
