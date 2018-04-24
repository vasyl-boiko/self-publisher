using Publisher.DB.Interfaces;
using Publisher.Models;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Publisher.DB.Repositories
{
    public class AutorRepository: BaseRepository, IAutorRepository
    {
        public AutorRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public async Task<Page<User>> GetAutors(int index, int pageSize)
        {
            var result = new Page<User>() { CurrentPage = index, PageSize = pageSize };

            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var query = context.Users.AsQueryable();

                result.TotalPages = await query.CountAsync();
                result.Records = await query.OrderByDescending(p => p.LastName).Skip(index * pageSize).Take(pageSize).ToListAsync();
            }

            return result;
        }

        public async Task<User> GetAutor(int userId)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Users.FirstOrDefaultAsync(p => p.Id == userId);
            }
        }

        public async Task AddBook(Book book)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }
    }
}
