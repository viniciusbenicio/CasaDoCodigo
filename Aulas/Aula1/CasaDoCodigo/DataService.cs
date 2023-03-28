using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext conexto;

        public DataService(ApplicationContext conexto)
        {
            this.conexto = conexto;
        }

        public void InicializaDB()
        {
            conexto.Database.Migrate();
        }
    }
}
