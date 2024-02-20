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
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private string primos;
        private const int MaxMultiplier = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int multiplicando = random.Next(1, MaxMultiplier + 1);
            int multiplicador = random.Next(1, MaxMultiplier + 1);
            int resultado = multiplicando * multiplicador;
            MessageBox.Show($"{multiplicando} x {multiplicador} = {resultado}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumElevado frm = new NumElevado();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 2; i<=1000; i++)
            {
                int divisor = 2;
                while (i %divisor !=0 &&
                    divisor < i)
                {
                    divisor++;
                }
                if (divisor == i)
                {
                    primos += i + " ";
                }
            }
            MessageBox.Show(primos + " ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EdadPromedio frm = new EdadPromedio();
            frm.Show();
        }
    }
}
