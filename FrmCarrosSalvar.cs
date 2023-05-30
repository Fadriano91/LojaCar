using LojaCar.Class;
using MySql.Data.MySqlClient;
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
    public partial class FrmCarrosSalvar : Form
    {
        public FrmCarrosSalvar()
        {
            InitializeComponent();
            //carregar comboBox com dados de carregar() da class Marcas
            MySqlDataReader res = Marcas.carregar();

            if(res.HasRows)
            {
                while(res.Read())
                {
                    cmbMarca.Items.Add(
                        res["id"].ToString() + " - " +
                        res["marca"].ToString()
                        );
                }
            }
         }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int ano = int.Parse(txtAno.Text);
            //string[] marcaCarregar = cmbMarca.SelectedItem.ToString().Split();
            string[] marcaCarregar = cmbMarca.SelectedItem.ToString().Split();
            Carros car = new Carros();
            car.Modelo = txtModelo.Text;
            car.Ano = ano;
            car.Cor = txtCor.Text;
            car.Id_marca = Int32.Parse(marcaCarregar[0].Trim());
            MessageBox.Show(Carros.salvar(car));
            limpar();
        }

        private void limpar()
        {
            txtModelo.Clear();
            txtAno.Clear();
            txtCor.Clear();
            cmbMarca.SelectedIndex = -1;
            txtModelo.Focus();
        }
    }
}
