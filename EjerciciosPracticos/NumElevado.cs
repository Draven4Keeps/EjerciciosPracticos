using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPracticos
{
    public partial class NumElevado : Form
    {
        public NumElevado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(NumBase.Text, out double numeroBase) &&
                int.TryParse(Potencia.Text, out int potencia))
            {
                double result = Math.Pow(numeroBase, potencia);
                Resultado.Text = result.ToString() ;
            }
            else
            {
                Resultado.Text = "invalido";
            }
        }
    }
}
