using System.Collections.Generic;

namespace CasaDoCodigo.Repository
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}