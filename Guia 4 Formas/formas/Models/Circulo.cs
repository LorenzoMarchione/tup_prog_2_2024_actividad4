using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas.Models
{
    internal class Circulo:iFigura, IComparable
    {
        public double radio {  get; private set; }

        public Circulo(double radio) 
        {
            this.radio = radio; 
        }
        public double calcularArea()
        {
            double area = Math.Pow(radio, 2) * Math.PI;
            return area;
        }
        public double calcularPerimetro()
        {
            double perimetro = (radio*2) * Math.PI;
            return perimetro;
        }
        public override string ToString()
        {
            return $"Circulo : Area= {calcularArea()}";
        }

        public int CompareTo(object obj)
        {
            Circulo circ = obj as Circulo;
            if (circ == null)
            { return 1; }
            return circ.calcularArea().CompareTo(calcularArea());
        }
    }
}
