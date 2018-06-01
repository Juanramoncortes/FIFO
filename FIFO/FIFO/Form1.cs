using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        Estructura estructura = new Estructura();
        private void btnStart_Click(object sender, EventArgs e)
        {
            estructura.Agregar();

            txtDatos.Text = "Total de procesos: " + Convert.ToString(estructura.contador) + Environment.NewLine + "Procesos Realizados: " + (estructura.terminado) + Environment.NewLine + "\n Esperando procesos: " + estructura.pausa + Environment.NewLine + " Procesos prendientes:  " + (estructura.contador - estructura.terminado) + Environment.NewLine + " Suman sus ciclos pendientes: " + estructura.procesosP;
            

        }
    }
}
