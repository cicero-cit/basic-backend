using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using basicBackend.Application.Interfaces;

namespace basicBackend.Infrastructure.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IConfiguration _configuration;

        public ContactRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Add(Core.Entities.Contact entity)
        {
            var sql = "INSERT INTO Contacts (Name, Nickname, Emoji) Values (@Name, @Nickname, @Emoji);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Contacts WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Core.Entities.Contact> Get(int id)
        {
            var sql = "SELECT * FROM Contacts WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Core.Entities.Contact>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Core.Entities.Contact>> GetAll()
        {
            var sql = "SELECT * FROM Contacts;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Core.Entities.Contact>(sql);
                return result;
            }
        }

        public async Task<int> Update(Core.Entities.Contact entity)
        {
            var sql = "UPDATE Contacts SET Name = @Name, Nickname = @Nickname, Emoji = @Emoji WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}