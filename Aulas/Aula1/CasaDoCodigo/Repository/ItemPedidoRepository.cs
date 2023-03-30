using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repository
{
    public interface IItemPedidoRepository
    {

    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {

        }
    }
}
