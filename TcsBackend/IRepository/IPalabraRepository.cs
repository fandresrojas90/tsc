using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tcsBack.DTO;

namespace tcsBack.IRepository
{
    public interface IPalabraRepository
    {
        public Response PostPalabras(PalabrasDto pdto);

        public string metodoRaro();
    }
}
