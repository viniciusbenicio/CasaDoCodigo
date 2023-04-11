﻿using CasaDoCodigo.Models;
using System;
using System.Linq;

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
           var cadastroDB = dbSet.Where(c => c.Id == cadastroId)
                                 .SingleOrDefault();

            if (cadastroDB == null)
                throw new ArgumentNullException("Cadastro");

            cadastroDB.Update(novoCadastro);
            contexto.SaveChanges();

            return cadastroDB;
        }
    }
}
