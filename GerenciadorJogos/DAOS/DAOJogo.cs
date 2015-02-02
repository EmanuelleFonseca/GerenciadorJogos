﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using GerenciadorJogos.Entidades;


namespace GerenciadorJogos
{
    class DAOJogo
    {


        public void adicionaProduto(Jogo jogo )
        {
            String nome = jogo.getNome();
            String tipo = jogo.getTipo();

            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=mydb;");

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "insert into jogo (nome, tipo) values (@nom, @tip)";
            cmd.Parameters.AddWithValue("@nom", nome);
            cmd.Parameters.AddWithValue("@tip", tipo);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Jogo cadastrado com sucesso");


        }

        public void buscaProduto(CheckedListBox cbl)
        {
            MySqlConnection con;

            con = new MySqlConnection("server=localhost;userid=root;password=;database=mydb;");

            con.Open();


            if (con.State == ConnectionState.Open)
            {
                MySqlDataAdapter Adapter;

                DataSet DSet;
                DSet = new DataSet();
                DataRow row = null;
                int i = 0;

               
                Adapter = new MySqlDataAdapter("SELECT nome FROM jogo ", con);
                Adapter.Fill(DSet, "jogo");
                cbl.Items.Clear();

                foreach (DataRow col in DSet.Tables["jogo"].Rows)
                {
                    row = col;
                    cbl.Items.Add(DSet.Tables["jogo"].Rows[i][0]);
                    i++;




                }


            }
        }

        public void vendaJogo(CheckedListBox cbl, Jogo jogo)
        {

            DAOVenda venda = new DAOVenda();
            String nome, descricao = null;
            String val = jogo.getPreco();
            

            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=mydb;");

            conexao.Open();


            if (cbl.Items.Count > 0)
            {
                for (int i = 0; i <= cbl.CheckedItems.Count - 1; i++)
                {
                    nome = cbl.CheckedItems[i].ToString();
                    descricao += cbl.CheckedItems[i].ToString() + "\n";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexao;
                    venda.deleta(nome);





                }
            }

            venda.adicionaVenda(val, descricao);

        }

        




    }
}
