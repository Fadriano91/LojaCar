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
    public partial class FrmMarcasConsulta : Form
    {
        public FrmMarcasConsulta()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            marca.Id = Int32.Parse(txtId.Text);

            if(Marcas.pesquisar(marca))
            {
                txtMarca.Text = marca.Marca;
                txtMarca.BackColor = Color.Lime;
                txtMarca.ForeColor = Color.Black;
                txtMarca.ReadOnly = false;

                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
            }
            else
            {
                txtMarca.Text = "Marca não encontrada!";
                txtMarca.BackColor = Color.Salmon;
                txtMarca.ForeColor = Color.Black;
                
                btnExcluir .Enabled = false;
                btnEditar .Enabled = false;
            }
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir a Marca '" + txtMarca.Text + "' ?";
            string caption = "Exclusão de Marca";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                Marcas marca = new Marcas();
                MessageBox.Show(marca.excluir(txtId.Text));
                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
            limpar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente editar a Marca '" + txtMarca.Text + "' ?";
            string caption = "Edição de Marca";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                Marcas marca = new Marcas();
                marca.Id = Int32.Parse(txtId.Text);
                marca.Marca = txtMarca.Text;
                MessageBox.Show(Marcas.editar(marca));
                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
            limpar();
        }

        private void limpar()
        {
            txtId.Clear();
            txtMarca.Clear();
            txtMarca.BackColor= Color.White;
            txtMarca.ReadOnly = true;
            txtId.Focus();
            btnExcluir.Enabled = false;
            btnEditar .Enabled = false;
        }
    }
}
