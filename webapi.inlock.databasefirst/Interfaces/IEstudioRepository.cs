using webapi.inlock.tarde.Domains;

namespace webapi.inlock.tarde.Interfaces
{
    public interface IEstudioRepository
    {
        List<Estudio> Listar();
        Estudio BuscarPorId(Guid ID);
        void Cadastrar(Estudio novoEstudio);
        void Atualizar(Guid ID, Estudio estudioAtualizado);
        void Deletar(Guid ID);
        List<Estudio> ListarComJogos();
    }
}
