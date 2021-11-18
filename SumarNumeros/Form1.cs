using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumarNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            try
            {
                    int n1 = Int32.Parse(txtN1.Text);
                    int n2 = Int32.Parse(txtN2.Text);
                    int resultado = n1 + n2;

                    labelTot.Text = Convert.ToString(resultado);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al intentar calcular, asegurate de introducir un numero");
            }
        }

    }
}
