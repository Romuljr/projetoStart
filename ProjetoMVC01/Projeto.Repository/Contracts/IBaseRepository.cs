using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Contracts
{
    public interface IBaseRepository<TEntity>
    {
        void Inserir(TEntity entity);
        void Alterar(TEntity entity);
        void Excluir(TEntity entity);
        void Consultar(TEntity entity);
               
    }
}
