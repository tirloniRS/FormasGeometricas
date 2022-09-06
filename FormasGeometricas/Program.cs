using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            List<Forma> listaForma = new List<Forma>();

            //instancia a primeira forma
            Quadrado q1 = new Quadrado();
            q1.Nome = "Quadrado A - ";
            q1.Lado = 3;

            //adiciona o objeto Forma na lista
            listaForma.Add(q1);

            //instancia a segunda forma
            Quadrado q2 = new Quadrado();
            q2.Nome = "Quadrado B - ";
            q2.Lado = 5;

            //adiciona o objeto Forma na lista
            listaForma.Add(q2);

            Circulo c1 = new Circulo();
            c1.Nome = "Círculo 1 - ";
            c1.Raio = 3;

            //adiciona o objeto Forma na lista
            listaForma.Add(c1);

            Triangulo t1 = new Triangulo();
            t1.Nome = "Triângulo 1 - ";
            t1.LadoA = 14;
            t1.LadoB = 9;
            t1.LadoC = 7;

            //adiciona o objeto Forma na lista
            listaForma.Add(t1);


            //para cada item da minha lista
            //para cada forma da minha lista de formas
            foreach (Forma forma in listaForma)
            {
                Console.WriteLine("{0} Área: {1:F2}", forma.Nome, forma.Area());
                //Console.WriteLine("{0}", forma.Nome);
            }
            
        }
        
    }
}
