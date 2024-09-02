using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas.Models
{
    internal class Cuadrado:Rectangulo, IComparable
    {
        public Cuadrado(double lado):base (lado, lado) 
        {
            base.lado1 = lado;
            base.lado2 = lado;
        }
        public override string ToString()
        {
            return $"Cuadrado : Area= {calcularArea()}";
        }
    }
}
