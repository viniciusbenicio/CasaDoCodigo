using CasaDoCodigo.Models;
using System.Linq;

namespace CasaDoCodigo.Repository
{
    public interface IItemPedidoRepository
    {
        void UpdateQuantidade(ItemPedido itemPedido);

    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {

        }

        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = dbSet.Where(i => i.Id == itemPedido.Id)
                                    .SingleOrDefault();

            if(itemPedidoDB != null)
            {
                itemPedidoDB.AtualizaQuantidade(itemPedido.Quantidade);
            }

            contexto.SaveChanges();
        }
    }
}
