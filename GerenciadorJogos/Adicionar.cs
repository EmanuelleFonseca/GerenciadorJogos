using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GerenciadorJogos.Entidades;

namespace GerenciadorJogos
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {
    
    
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo() ; 

            jogo.setNome(txtNome.Text);
            jogo.setTipo(txtTipo.Text);


            DAOJogo produto = new DAOJogo();
            produto.adicionaProduto(jogo);

        }

       


    }
}
