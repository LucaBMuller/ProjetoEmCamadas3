using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1LUCA28
{
    public partial class Frm_publicacao : Form
    {
        public Frm_publicacao()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Publicacao obj = new Publicacao();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.descricao = txtDescricao.Text;
            obj.data = dtmDia.Value.ToString("yyyy-MM-dd");
            obj.Cadastrar();
            MessageBox.Show("Cadastrado!");
            txtId.Clear();
            txtDescricao.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Publicacao obj = new Publicacao();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.descricao = txtDescricao.Text;
            obj.data = dtmDia.Value.ToString("yyyy-MM-dd");
            obj.Alterar();
            MessageBox.Show("Alterado!");
            txtId.Clear();
            txtDescricao.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Publicacao obj = new Publicacao();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Publicacao obj = new Publicacao();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído!");
            txtId.Clear();
            txtDescricao.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_informacoes Frm_tipoProduto = new Frm_informacoes();
            Frm_tipoProduto.ShowDialog();
        }

    }
}
