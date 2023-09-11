using senai.inlock.webApi.domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.repositories
{
    public class JogosRepository : IJogosRepository
    {
        private string StringConexao = "Data Source = NOTE17-S15; Initial Catalog = inlock_games; User Id = sa; Pwd = Senai@134";
        public void AtualizarIdCorpo(JogosDomain Jogos)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, JogosDomain Estudio)
        {
            throw new NotImplementedException();
        }

        public JogosDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(JogosDomain novoJogos)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryInsert = "INSERT INTO Jogo VALUES(@IdEstudio, @Nome, @Descricao, @DataLancamento, @Valor)";

                SqlDataReader rdr;

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@IdEstudio", novoJogos.IdEstudio);
                    cmd.Parameters.AddWithValue("@Nome", novoJogos.Nome);
                    cmd.Parameters.AddWithValue("@Descricao", novoJogos.Descricao);
                    cmd.Parameters.AddWithValue("@DataLancamento", novoJogos.DataLancamento);
                    cmd.Parameters.AddWithValue("@Valor", novoJogos.Valor);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<JogosDomain> ListarTodos()
        {
            List<JogosDomain> jogos = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryJogos = "SELECT Jogo.IdJogo, Jogo.IdEstudio, Jogo.Nome, Estudio.Nome AS EstudioNome, Estudio.IdEstudio AS EstudioId, Jogo.Descricao, Jogo.DataLancamento, Jogo.Valor FROM Jogo INNER JOIN Estudio ON Estudio.IdEstudio = Jogo.IdEstudio";

                SqlDataReader rdr;

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryJogos, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        JogosDomain jogo = new JogosDomain()
                        {
                            IdJogo = Convert.ToInt32(rdr["IdJogo"]),
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                            Nome = rdr["Nome"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            DataLancamento = Convert.ToDateTime(rdr["DataLancamento"]),
                            Valor = Convert.ToDouble(rdr["Valor"])
                        };
                        EstudioDomain estudio = new EstudioDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr["EstudioId"]),
                            Nome = rdr["EstudioNome"].ToString()
                        };
                        jogo.Estudio = estudio;
                        jogos.Add(jogo);
                    }
                }
            }
            return jogos;
        }
    }

}
