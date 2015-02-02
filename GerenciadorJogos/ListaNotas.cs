using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorJogos
{
    public partial class ListaNotas : Form
    {
        public ListaNotas()
        {
            InitializeComponent();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            DAOVenda notas = new DAOVenda();
            notas.buscaVendas(dgvNotas); // daoNotas

        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }



        private void ListaNotas_Load(object sender, EventArgs e)
        {
       

        }
    }
}
