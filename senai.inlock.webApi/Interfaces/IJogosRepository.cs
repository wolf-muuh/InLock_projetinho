using senai.inlock.webApi.domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IJogosRepository
    {
        void Cadastrar(JogosDomain novoJogos);

        List<JogosDomain> ListarTodos();

        JogosDomain BuscarPorId(int id);

        void AtualizarIdCorpo(JogosDomain Jogos);

        void AtualizarIdUrl(int id, JogosDomain Estudio);

        void Deletar(int id);
    }
}
