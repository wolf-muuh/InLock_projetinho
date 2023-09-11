using senai.inlock.webApi.domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IUsuarioRepository
    {
    
        UsuarioDomain Login(string email, string senha);

    }
}
