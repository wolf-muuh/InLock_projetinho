using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        public int IdTiposDeUsuario { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório !!!")]
        public string? Email { get; set; }

 
        [Required(ErrorMessage = "A Senha é obrigatória !!!")]
        public string? Senha { get; set; }

        public TiposDeUsuarioDomain TiposDeUsuario { get; set; }
    }
}
