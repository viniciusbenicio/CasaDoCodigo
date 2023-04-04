using CasaDoCodigo.Models;

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
            throw new System.NotImplementedException();
        }
    }
}
