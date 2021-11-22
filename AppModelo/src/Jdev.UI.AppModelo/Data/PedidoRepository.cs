using Jdev.UI.AppModelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdev.UI.AppModelo.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }
    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
