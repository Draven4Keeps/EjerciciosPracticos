using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EjerciciosPracticos
{
    public partial class EdadPromedio : Form
    {
        public EdadPromedio()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int mayor = int.MinValue;
            int menor = int.MaxValue;

            int edad = int.Parse(edad1.Text);
            int edad0 = int.Parse(edad2.Text);
            int edad00 = int.Parse(edad3.Text);
            suma += edad;
            if (edad > mayor)
                mayor = edad;
            if (edad < menor)
                menor = edad;
            if (edad0 > mayor)
                mayor = edad0;
            if (edad0 < menor)
                menor = edad0;
            if (edad00 > mayor)
                mayor = edad00;
            if (edad00 < menor)
                menor = edad00;
            MessageBox.Show($"La edad Menor es {menor}, la edad mayor es { mayor}");
        }
    }
}
