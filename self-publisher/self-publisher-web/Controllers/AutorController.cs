using Microsoft.AspNetCore.Mvc;
using Publisher.DB.Interfaces;
using Publisher.Models;
using System.Threading.Tasks;

namespace SelfPublisher.Web.Controllers
{
    [Route("api/[controller]")]
    public class AutorController
    {
        IAutorRepository _autorRepository;

        public AutorController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        [Route("page")]
        [HttpGet]
        public async Task<Page<User>> GetAutors(int pageIndex)
        {
            return await _autorRepository.GetAutors(pageIndex, 10);
        }
    }
}
