using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Quadrado : Forma
    {
        //sobrescrevendo o método ou propriedade
        public override string Nome { get; set; }
        public double Lado { get; set; }

        public override double Area()
        {
            return Lado * Lado;
        }

    }
}
