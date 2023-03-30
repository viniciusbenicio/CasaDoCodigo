using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Http;

namespace CasaDoCodigo.Repository
{
    public interface IPedidoRepository
    {

    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;

        public PedidoRepository(ApplicationContext contexto, IHttpContextAccessor contextAccessor) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
        }

        private int? GetPedidoId()
        {
            return contextAccessor.HttpContext.Session.GetInt32("PedidoId");
            
        }

        private void SetPedidoId(int pedidoId)
        {
            return contextAccessor.HttpContext.Session.SetInt32("PedidoId", pedidoId);

        }
    }
}
