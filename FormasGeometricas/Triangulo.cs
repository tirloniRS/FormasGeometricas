using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Triangulo : Forma
    {
        public override string Nome { get; set; }
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        
        public override double Area()
        {
            double p = ((LadoA + LadoB + LadoC) / 2);//semiperímetro
            double d = p * (p - LadoA) * (p - LadoB) * (p - LadoC);
            return Math.Sqrt(d);
        }
    }
}
