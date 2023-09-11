using senai.inlock.webApi.domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IEstudioRepository
    {
        void Cadastrar(EstudioDomain novoEstudio);

        List<EstudioDomain> ListarTodos();

        EstudioDomain BuscarPorId(int id);

        void AtualizarIdCorpo(EstudioDomain Estudio);

        void AtualizarIdUrl(int id, EstudioDomain Estudio);   

        void Deletar(int id);
    }
}
