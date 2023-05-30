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
    public partial class FrmMarcasSalvar : Form
    {
        public FrmMarcasSalvar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.Marca = txtMarca.Text;
            MessageBox.Show(Marcas.salvar(marcas));
            limpar();
        }

        private void limpar()
        {
            txtMarca.Clear();
            txtMarca.Focus();
        }
    }
}
