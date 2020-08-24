using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si es tu Nombre?",
                "Mensaje de Bienvenida",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            MessageBox.Show("Hola!" + txtnombre.Text,
                "Saludo a Usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
