using LojaCar.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaCar
{
    public partial class FrmPrincipal : System.Windows.Forms.Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        //menuMarca
        private void itemMarcaCadastrar_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmMarcasSalvar>().Count() > 0) 
            {
                Application.OpenForms.OfType<FrmMarcasSalvar>().First().Focus();
            }
            else
            {
                FrmMarcasSalvar frm = new FrmMarcasSalvar();
                frm.Show();
            }
        }

        private void itemMarcaListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Marcas.listar());
        }

        private void itemMarcaConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmMarcasConsulta>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmMarcasConsulta>().First().Focus();
            }
            else
            {
                FrmMarcasConsulta frm = new FrmMarcasConsulta();
                frm.Show();
            }
        }
    }
}
