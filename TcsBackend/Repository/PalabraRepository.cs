using BackTcs.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using tcsBack.DTO;
using tcsBack.IRepository;
using TcsBackend.Utiles;

namespace tcsBack.Repository
{
    public class PalabraRepository : IPalabraRepository
    {
        public string metodoRaro()
        {
            var result = Utiles.metodoRaro();
            return result;
        }

        public Response PostPalabras(PalabrasDto pdto)
        {
            Response response = new Response();
            string parrafo = pdto.palabras.Replace(",", " ").Replace(".", " ").Replace("-", " ");
            var result = Utiles.words(parrafo);
            response.content = result;
            response.std = 1;
            response.status = 200;
            return response;
        }

    }
}
