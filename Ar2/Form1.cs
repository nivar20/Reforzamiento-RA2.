using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class btnLimpiar : Form
    {
        public btnLimpiar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Hijos = 0;
            decimal IncentivoHijos = 0;
            decimal SFS;
            decimal AFP;
            decimal Descuentos;
            decimal SueldoBruto;
            decimal SueldoNeto;


            SueldoBruto = Convert.ToDecimal(txtSueldoBruto.Text);
            Hijos = Convert.ToInt32(txtHijos.Text);

            if (Hijos > 0)
            {
                IncentivoHijos = Hijos * 500;
            }
            else
            {
                MessageBox.Show("No aplica para incentivo de hijos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            SFS = (SueldoBruto * 3.04m) / 100;
            AFP = (SueldoBruto * 2.87m) / 100;
            Descuentos = SFS + AFP;


            SueldoNeto = (SueldoBruto + IncentivoHijos) - Descuentos;

            txtIncentivoHijos.Text = IncentivoHijos.ToString();
            txtSFS.Text = SFS.ToString();
            txtAFP.Text = AFP.ToString();
            txtDescuentos.Text = Descuentos.ToString();
            txtSueldoNeto.Text = SueldoNeto.ToString();
        }

      

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtSueldoBruto.Clear();
            txtHijos.Clear();
            txtIncentivoHijos.Clear();
            txtSFS.Clear();
            txtAFP.Clear();
            txtDescuentos.Clear();
            txtSueldoNeto.Clear();

        }
    }
}
