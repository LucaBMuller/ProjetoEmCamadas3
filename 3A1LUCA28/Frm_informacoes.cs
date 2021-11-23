using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1LUCA28
{
    public partial class Frm_informacoes : Form
    {
        public Frm_informacoes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Informacoes obj = new Informacoes();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.visualizacoes = (int)Convert.ToInt64(txtVisualizacoes.Text);
            obj.curtidas = (int)Convert.ToInt64(txtCurtidas.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastrado!");
            txtId.Clear();
            txtCurtidas.Clear();
            txtVisualizacoes.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Informacoes obj = new Informacoes();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.visualizacoes = (int)Convert.ToInt64(txtVisualizacoes.Text);
            obj.curtidas = (int)Convert.ToInt64(txtCurtidas.Text);
            obj.Alterar();
            MessageBox.Show("Alterado!");
            txtId.Clear();
            txtCurtidas.Clear();
            txtVisualizacoes.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Informacoes obj = new Informacoes();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído!");
            txtId.Clear();
            txtCurtidas.Clear();
            txtVisualizacoes.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Informacoes obj = new Informacoes();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_publicacao Frm_publicacao = new Frm_publicacao();
            Frm_publicacao.ShowDialog();
        }
    }
}
