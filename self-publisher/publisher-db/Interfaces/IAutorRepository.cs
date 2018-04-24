using Publisher.Models;
using System.Threading.Tasks;

namespace Publisher.DB.Interfaces
{
    public interface IAutorRepository
    {
        Task<Page<User>> GetAutors(int index, int pageSize);
        Task<User> GetAutor(int userId);
        Task AddBook(Book book);
    }
}
