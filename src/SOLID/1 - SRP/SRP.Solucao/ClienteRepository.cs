using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRP.Solucao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var con = new SqlConnection())
            {
                var cmd = new SqlCommand();

                con.ConnectionString = "MinhaConnectionString";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Cliente(Nome, Email, Cpf, DataCadastro)VALUES(@Nome, @Email, @Cpf, @DataCadastro)";

                cmd.Parameters.AddWithValue("Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("Email", cliente.Email.Endereco);
                cmd.Parameters.AddWithValue("Cpf", cliente.Cpf.Numero);
                cmd.Parameters.AddWithValue("DataCadatro", cliente.DataCadastro);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
