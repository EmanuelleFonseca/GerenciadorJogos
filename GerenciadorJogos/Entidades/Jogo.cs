using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorJogos.Entidades
{
    class Jogo
    {
       
        String nome;
        String tipo;
        String preco;

   
        public String getNome() 
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getTipo()
        {
            return tipo;
        }
        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }
        public String getPreco()
        {
            return preco;
        }
        public void setPreco(String preco)
        {
            this.preco = preco;
        }
    }
}
