using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using tcsBack.DTO;
using tcsBack.IRepository;

namespace tcsBack.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("allorigin")]
    public class PalabrasController : ControllerBase
    {
        private readonly IPalabraRepository _Irepository;

        public PalabrasController(IPalabraRepository Irepository)
        {
            this._Irepository = Irepository;
        }
        [HttpPost]
        public Response PostPalabras(PalabrasDto pdto)
        {
            return _Irepository.PostPalabras(pdto);
        }
        [HttpGet]
        public string GetMetodoRaro()
        {
            return _Irepository.metodoRaro();
        }
    }
}
