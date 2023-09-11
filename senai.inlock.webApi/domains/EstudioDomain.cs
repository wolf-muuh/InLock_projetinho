using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.domains
{
    public class EstudioDomain
    {
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O nome do Estúdio é obrigatório")]
        public string Nome { get; set; }
    }
}
