using GalloFlix.Interfaces;
using GalloFlix.Models;
using MySql.Data.MySqlClient;

namespace GalloFlix.Repositories;
public class GenreRepository : IGenreRepository
{
    string connectionString = "server=localhost;port=3306;database=galloflixdb;uid=root;pwd=''";

    public void Create(Genre model)
    {
        using (MySqlConnection connection = new(connectionString))
        {
            string sql = "insert into genre(name) values(@name)";
            MySqlCommand command = new(sql, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@name", model.Name);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void Delete(int? id)
    {
        using (MySqlConnection connection = new(connectionString))
        {
            var sql = "delete from genre where id = @id";
            MySqlCommand command = new(sql, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public List<Genre> ReadAll()
    {
        List<Genre> genres = new();
        using (MySqlConnection connection = new(connectionString))
        {
            var sql = "select * from genre";
            MySqlCommand command = new(sql, connection);
            command.CommandType = System.Data.CommandType.Text;
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                genres.Add(
                    new Genre()
                    {
                        Id = Convert.ToByte(reader["id"]),
                        Name = reader["name"].ToString()
                    }
                );
            }
            connection.Close();
        }
        return genres;
    }
}

