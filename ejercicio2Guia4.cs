using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2Guia4
{
    /// <summary>
    /// Autor: NixieNixi
    /// Fecha: 19/10/2024
    /// Version: 1.0.0
    /// Demostracion: Sentencias Iterativas
    /// Problema: Desarrolle un programa que cuente la cantidad de múltiplos
    /// de 7 que hay entre 100 y 700.
    /// </summary>
    public partial class ejercicio2Guia4 : Form
    {
        public ejercicio2Guia4()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int num = 0, i = 0;

            //Ejecutar el while entre 100 a 700

            // inicializamos num
            for (num = 100; num <= 700; num++)
            {
                if (num % 7 == 0)
                {
                    i = i + 1;
                }


            }
            MessageBox.Show(String.Format("El total de múltiplos de 7 es: {0}", i));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Pone fin a la ejecucion del Programa
            Application.Exit();
        }
    }
}
