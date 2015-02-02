﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GerenciadorJogos
{
    class DAOVenda
    {


        public void adicionaVenda( String valor, String descricao)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=mydb;");

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "insert into venda ( valorTotal,descricao) values ( @val, @desc)";
            cmd.Parameters.AddWithValue("@val", valor);
            cmd.Parameters.AddWithValue("@desc", descricao);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Venda cadastrada com sucesso. Os produtos foram: \n" + descricao);


        }

        public void buscaVendas(DataGridView dgv)
        {
            MySqlConnection con;

            con = new MySqlConnection("server=localhost;userid=root;password=;database=mydb;");

            con.Open();


            if (con.State == ConnectionState.Open)
            {
                MySqlDataAdapter Adapter;
                DataSet DSet;

                DSet = new DataSet();



                Adapter = new MySqlDataAdapter("Select * from venda", con);

                Adapter.Fill(DSet, "venda");
                dgv.DataSource = DSet;

                dgv.DataMember = "venda";



            }

        }

        public void deleta(String nome)
        {
            MySqlConnection con;

            con = new MySqlConnection("server=localhost;userid=root;password=;database=mydb;");

            con.Open();


            if (con.State == ConnectionState.Open)
            {

                MySqlCommand acao = new MySqlCommand("delete * from jogo where nome = @nome;", con);
                acao.Parameters.AddWithValue("@nome",nome);

                con.Close();

   
            }
        }

        

    }
}
