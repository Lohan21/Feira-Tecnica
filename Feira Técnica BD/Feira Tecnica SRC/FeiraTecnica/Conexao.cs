using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeiraTecnica
{
    class Conexao
    {
        private static string servername = "(localdb)\\MSSQLLocalDB";
        private static string database = "Database";

        public static SqlConnection conexao = new SqlConnection(
            string.Format(
                "Data Source={0};Initial Catalog={1};Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
                servername,
                database
            )
        );

        public static string PegarDateTime()
        {
            return DateTime.Now.ToString("");
        }

        public static void AbrirConexao()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public static bool AdicionarRegistro(string tabela, Dictionary<string, string> informacoes)
        {
            bool erro = false;

            try
            {
                List<string> colunas = informacoes.Keys.ToList();
                string colunasSql = String.Join(", ", colunas);

                List<string> valores = new List<string>();

                foreach (KeyValuePair<string, string> informacao in informacoes)
                {
                    string coluna = informacao.Key;
                    string valor = informacao.Value;

                    string valorComAspasSimples = string.Format(
                        "'{0}'",
                        valor
                    );

                    valores.Add(valorComAspasSimples);
                }

                string valoresSql = String.Join(", ", valores);

                string sql = string.Format(
                    "INSERT INTO {0} ({1}) VALUES ({2});",
                    tabela,
                    colunasSql,
                    valoresSql
                );

                SqlCommand comando = new SqlCommand(sql, conexao);
                AbrirConexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao adicionar registro: " + e);

                erro = true;
            }
            finally
            {
                FecharConexao();
            }

            return erro;
        }

        public static bool EditarRegistro(string tabela, int id, Dictionary<string, string> informacoes)
        {
            bool erro = false;

            try
            {
                informacoes.Add("modificado", PegarDateTime());

                List<string> valores = new List<string>();

                foreach (KeyValuePair<string, string> informacao in informacoes)
                {
                    string coluna = informacao.Key;
                    string valor = informacao.Value;

                    string valorComAspasSimples = string.Format(
                        "{0} = '{1}'",
                        coluna,
                        valor
                    );

                    valores.Add(valorComAspasSimples);
                }

                string valoresSql = String.Join(", ", valores);

                string sql = string.Format(
                    "UPDATE {0} SET {1} WHERE id = '{2}';",
                    tabela,
                    valoresSql,
                    id
                );

                SqlCommand comando = new SqlCommand(sql, conexao);
                AbrirConexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao editar registro: " + e);

                erro = true;
            }
            finally
            {
                FecharConexao();
            }

            return erro;
        }

        public static bool RemoverRegistro(string tabela, int id)
        {
            bool erro = false;

            try
            {
                string sql = string.Format(
                    "UPDATE {0} SET ativo = '0' WHERE id = '{1}';",
                    tabela,
                    id
                );
                SqlCommand comando = new SqlCommand(sql, conexao);
                AbrirConexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao remover o registro: " + e);

                erro = true;
            }
            finally
            {
                FecharConexao();
            }

            return erro;
        }

        public static void BuscarRegistrosAtivos(string tabela, DataGridView dataGridView)
        {
            try
            {
                string sql = string.Format(
                    "SELECT * FROM {0} WHERE ativo = '1';",
                    tabela
                );
                SqlCommand comando = new SqlCommand(sql, conexao);
                AbrirConexao();
                DataTable dataTable = new DataTable();
                dataTable.Load(comando.ExecuteReader());
                dataGridView.DataSource = dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar registros: " + e);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
