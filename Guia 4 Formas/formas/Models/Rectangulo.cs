using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas.Models
{
    internal class Rectangulo:iFigura, IComparable
    {
        public double lado1 {  get; protected set; }
        public double lado2 { get; protected set; }

        public Rectangulo (double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public  double calcularArea()
        {
            double area = lado1 * lado2;
            return area;
        }
        public double calcularPerimetro()
        {
            double perimetro = lado1 * 2 + lado2 * 2;
            return perimetro;
        }
        public override string ToString()
        {
            return $"Rectangulo : Area= {calcularArea()}";
        }

        public int CompareTo(object obj)
        {
            Rectangulo rect = obj as Rectangulo;
            if (rect == null) { return 1; }
            return rect.calcularArea().CompareTo(rect.calcularArea());
        }
    }
}
