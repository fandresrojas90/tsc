using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tcsBack.DTO
{
    public class Response
    {
        public string message { get; set; }
        public int std { get; set; }
        public int status { get; set; }
        public Object content { get; set; }
    }
}
