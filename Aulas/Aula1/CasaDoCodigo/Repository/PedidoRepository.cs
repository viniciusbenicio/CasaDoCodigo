using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repository
{
    public interface IPedidoRepository
    {

    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {

        }
    }
}
