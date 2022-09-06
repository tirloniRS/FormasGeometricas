using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    //classe abstrata, nao pode ser instanciada
    public abstract class Forma
    {
        public abstract string Nome { get; set; }

        public abstract double Area();
    }
}
