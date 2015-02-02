using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GerenciadorJogos;

namespace GerenciadorJogos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {


        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }

            //abro o formulário principal
            ListaNotas add = new ListaNotas();
            add.MdiParent = this;
            add.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }

            //abro o formulário principal
            Buscar add = new Buscar();
            add.MdiParent = this;
            add.Show();

        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }

            //abro o formulário principal
            Adicionar add = new Adicionar();
            add.MdiParent = this;
            add.Show();


        }



    }
}
