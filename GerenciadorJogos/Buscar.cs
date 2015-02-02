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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }





        private void Buscar_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {


            DAOJogo busca = new DAOJogo();
            busca.buscaProduto(cblProdutos); // daoProdutos



        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DAOJogo busca = new DAOJogo();

            Jogo jogo = new Jogo();

            jogo.setPreco(txtValor.Text);

            busca.vendaJogo(cblProdutos, jogo);
        }








    }
}

