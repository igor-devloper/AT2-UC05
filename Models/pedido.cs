using System;
using System.Collections.Generic;

namespace AT2_UC05.Models
{
  public class Pedido
  {
    public List<ItemPedido> listaDePedido = new List<ItemPedido>();
    public void AddPedido(string descricao, float valor_unitario, int quantidade)
    {
        listaDePedido.Add(new ItemPedido(descricao, valor_unitario,quantidade));
    }

    public List<ItemPedido> InfosDoPedido()
    {
      return listaDePedido;
    }
    
  }

}