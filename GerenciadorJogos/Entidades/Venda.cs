using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorJogos.Entidades
{
    class Venda
    {
      
        double valorTotal;
        String descricao;

        public double getValorTotal()
        {
            return valorTotal;
        }
        public void setValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }

        public String getDescricao()
        {
            return descricao;
        }
        public void setValorTotal(String desc)
        {
            this.descricao = desc;
        }
       
    }
}
