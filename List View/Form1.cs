using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtID.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //vamos checar se não haverá peenchimento vazio

            if (txtID.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio, por favor preencha o ID");
                txtID.Focus();
                return;
            }

            if (txtProduto.Text == "")
            {
                MessageBox.Show("PRODUTO não pode ser vazio, por favor preencha o PRODUTO");
                txtProduto.Focus();
                return;
            }

            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("QUANTIDADE não pode ser vazio, por favor preencha o PRODUTO");
                txtQuantidade.Focus();
                return;
            }

            if (txtPreco.Text == "")
            {
                MessageBox.Show("PREÇO não pode ser vazio, por favor preeencha o PREÇO");
                txtPreco.Focus();
                return;
            }
        }
    }
}
