using Dapper;
using PokemonWebAPI.Entities;
using System.Data.SqlClient;

namespace PokemonWebAPI.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        public async Task<List<Pokemon>> GetPokemonsAsync()
        {
            string connectionString = "Server=localhost,1433;Database=Pokemon;User Id=sa;Password=YourStrong!Passw0rd;";

            var result = new List<Pokemon>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("成功連接到數據庫！");

                    // 呼叫儲存過程
                    result = (await connection.QueryAsync<Pokemon>("GetPokemons")).ToList();


                }
                catch (Exception ex)
                {
                    Console.WriteLine("連接失敗: " + ex.Message);
                }
                return result;
            }
        }
    }
}
