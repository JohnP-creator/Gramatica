using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace Gramatica
{
    public partial class dtgvErrores : Form
    {
        public bool Lexico = false;
        ManejadorGramatica mg;
        ManejadoSintactico ms;
        public dtgvErrores()
        {
            InitializeComponent();
            mg = new ManejadorGramatica();
            ms = new ManejadoSintactico();
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            if (txtPalabras.Text == "" || txtPalabras.Text == " ")
            {
                txtPalabras.Text = "";
            }
            else
            {
                Lexico = true;
                mg.LlenarTabla(txtPalabras);
                mg.Mostrar(dtgTokens);
            }
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Lexico == false)
            {
                MessageBox.Show("Tienes que realizar el lexico primero");
            }
            else
            {
                ms.VerificarErrores(dtgTokens);
            }
            Lexico = false;
        } 
    }
}
