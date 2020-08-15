
using System;
using Perspective.Domain;
using Perspective.Storing;
using Xunit;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Perspective.Testing
{
    public class RepositoryTests
    {
        private static readonly SqliteConnection _connection = new SqliteConnection("Data Source=:memory:");
        private static readonly DbContextOptions<PerspectiveDBContext> _options = new DbContextOptionsBuilder<PerspectiveDBContext>().UseSqlite(_connection).Options;
        PerspectiveDBContext dbo = new PerspectiveDBContext(_options);
        [Fact]
        public async void TestPizzaRepositoryAdd()
        {   
            await _connection.OpenAsync();
            await dbo.Database.EnsureCreatedAsync();
            //UserModel tempUser = new UserModel(){Name = "Bob",Password = "Test"};
            /*
            PizzaRepository PR = new PizzaRepository(dbo);
            PR.Add(tempPizza);
            Assert.NotNull(dbo.Pizzas.FirstOrDefaultAsync(pizza => pizza.Name == tempPizza.Name));
            */
        }
        
        
        /*
        T Get(int id);
        T Get(string name);
        List<T> GetAll();
        T Find(string name);
        T Find(int id);
        void Add(T t);
        void Add(int id, string name);
        */
    }
}
