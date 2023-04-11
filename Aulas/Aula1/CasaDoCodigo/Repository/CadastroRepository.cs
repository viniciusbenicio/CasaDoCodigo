using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repository
{
    public interface ICadastroRepository
    {
        Cadastro Update(int cadastroId, Cadastro novoCadastro);
    }

    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {

        }

        public Cadastro Update(int cadastroId, Cadastro novoCadastro)
        {
            throw new System.NotImplementedException();
        }
    }
}
