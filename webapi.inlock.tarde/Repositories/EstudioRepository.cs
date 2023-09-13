using Microsoft.EntityFrameworkCore;
using webapi.inlock.tarde.Contexts;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interfaces;

namespace webapi.inlock.tarde.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        //Instância do objeto Context para receber dados do Banco De Dados
        InLockContext c = new InLockContext();

        /// <summary>
        /// Método que atualiza um Estúdio
        /// </summary>
        /// <param name="ID">Parâmetro</param>
        /// <param name="estudioAtualizado">Objeto atualizado</param>
        public void Atualizar(Guid ID, Estudio estudioAtualizado)
        {
            Estudio estudioBuscado = c.Estudios.Find(ID);
            if (estudioBuscado != null)
            {
                estudioBuscado.Nome = estudioAtualizado.Nome;
                c.Estudios.Update(estudioBuscado);
                c.SaveChanges();
            }
        }

        /// <summary>
        /// Método que busca um Estúdio por ID
        /// </summary>
        /// <param name="ID">Parâmetro</param>
        /// <returns>O ID buscado</returns>
        public Estudio BuscarPorId(Guid ID)
        {
            return c.Estudios.FirstOrDefault(e => e.IdEstudio == ID);
        }

        /// <summary>
        /// Método que cadastra um Estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto cadastrado</param>
        public void Cadastrar(Estudio novoEstudio)
        {
           c.Estudios.Add(novoEstudio);
            c.SaveChanges();
        }

        /// <summary>
        /// Método que deleta um Estúdio
        /// </summary>
        public void Deletar(Guid ID)
        {
          Estudio estudioBuscado =  c.Estudios.Find(ID)!;
            if (estudioBuscado != null)
            {
                c.Estudios.Remove(estudioBuscado);
            }
            c.SaveChanges();
        }

        /// <summary>
        /// Método que retorna uma lista de Estúdios
        /// </summary>
        /// <returns>Lista com todos os estúdios</returns>
        public List<Estudio> Listar()
        {
            return c.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos()
        {
            return c.Estudios.Include(e => e.Jogos).ToList();
        }
    }
}


