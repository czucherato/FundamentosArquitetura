using System;
using System.Data;
using System.Net.Mail;
using System.Data.SqlClient;

namespace SOLID.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (Cpf.Length != 11)
                return "Cliente com CPF inválido";

            using (var con = new SqlConnection())
            {
                var cmd = new SqlCommand();

                con.ConnectionString = "MinhaConnectionString";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Cliente(Nome, Email, Cpf, DataCadastro)VALUES(@Nome, @Email, @Cpf, @DataCadastro)";

                cmd.Parameters.AddWithValue("Nome", Nome);
                cmd.Parameters.AddWithValue("Email", Email);
                cmd.Parameters.AddWithValue("Cpf", Cpf);
                cmd.Parameters.AddWithValue("DataCadastro", DataCadastro);

                con.Open();
                cmd.ExecuteNonQuery();

                var mail = new MailMessage("empresa@empresa.com.br", Email);
                var client = new SmtpClient
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.google.com"
                };

                mail.Subject = "Bem vindo!";
                mail.Body = "Parabéns! Você está cadastrado.";
                client.Send(mail);

                return "Cliente cadastrado com sucesso";
            }
        }
    }
}
