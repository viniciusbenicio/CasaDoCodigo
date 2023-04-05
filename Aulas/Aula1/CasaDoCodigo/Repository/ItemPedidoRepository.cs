﻿using CasaDoCodigo.Models;
using System.Linq;

namespace CasaDoCodigo.Repository
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {

        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            return dbSet.Where(i => i.Id == itemPedidoId)
                                    .SingleOrDefault();
        }
    }
}
