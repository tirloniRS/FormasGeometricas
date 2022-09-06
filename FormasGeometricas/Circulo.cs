using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Circulo : Forma
    {
        public override string Nome { get; set; }
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}
