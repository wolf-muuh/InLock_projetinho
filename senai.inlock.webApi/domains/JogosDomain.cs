namespace senai.inlock.webApi.domains
{
    public class JogosDomain
    {
        public int IdJogo { get; set; }

        public int IdEstudio { get; set; }

        public EstudioDomain? Estudio { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataLancamento { get; set; }

        public Double Valor { get; set; }

    }
}
