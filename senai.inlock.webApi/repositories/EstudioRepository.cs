using senai.inlock.webApi.domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.repositories
{
    public class EstudioRepository : IEstudioRepository
    {

        private string StringConexao = "Data Source = NOTE17-S15; Initial Catalog = inlock_games; User Id = sa; Pwd = Senai@134";
        public void AtualizarIdCorpo(EstudioDomain Estudio)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, EstudioDomain Estudio)
        {
            throw new NotImplementedException();
        }

        public EstudioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(EstudioDomain novoEstudio)
        {
<<<<<<< HEAD
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = "INSERT INTO Estudio VALUES(@Nome)";

                SqlDataReader rdr;

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", novoEstudio.Nome);

                    cmd.ExecuteNonQuery();
                }

            }
=======
           
>>>>>>> c4c1c008ddbce2e4c940a5b723e572183a68b90c
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<EstudioDomain> ListarTodos()
        {
            EstudioDomain estudio = new EstudioDomain();

            JogosDomain jogo = new JogosDomain();

            List<EstudioDomain> ListarTodosEstudio = new List<EstudioDomain>();

            List<JogosDomain> ListarTodosJogos = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = "SELECT Estudio.IdEstudio, Estudio.Nome, Jogo.Nome AS jogo FROM Estudio INNER JOIN Jogo ON Jogo.IdEstudio = Estudio.IdEstudio";

                SqlDataReader rdr;

                con.Open();
                        

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        estudio = new EstudioDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                            Nome = rdr["Nome"].ToString()
                        };

                        jogo = new JogosDomain()
                        {
                            Nome = rdr["Jogo"].ToString(),
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"])
                        };


                        ListarTodosEstudio.Add(estudio);

                    }
                }
            }
            return ListarTodosEstudio;
        }

        public List<EstudioDomain> ListarTodos(int id)
        {
            List<EstudioDomain> ListaEstudio = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT Estudio.IdEstudio,"

            }
        }
    }
}
