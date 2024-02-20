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
    public partial class Tabla1_10 : Form
    {
        private Random random = new Random();
        private const int MaxMultiplier = 10;
        public Tabla1_10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int multiplicando = random.Next(1, MaxMultiplier + 1);
            int multiplicador = random.Next(1, MaxMultiplier + 1);
            int resultado = multiplicando * multiplicador;
            MessageBox.Show($"{multiplicando} x {multiplicador} = {resultado}");
        }
    }
}
