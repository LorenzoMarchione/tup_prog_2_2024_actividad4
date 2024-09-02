using formas.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ArrayList figuras = new ArrayList();
            figuras.Add (new Rectangulo(3, 4));
            figuras.Add (new Cuadrado(3.5));
            figuras.Add (new Circulo(2));
            figuras.Add (new Cuadrado(1.5));
            figuras.Add (new Circulo(9.1));
            figuras.Sort();
            foreach (iFigura f in figuras) 
            {
                lbRegistro.Items.Add(f.ToString());
            }
        }
    }
}
