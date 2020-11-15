using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Models
{
    public class HttpResponseToken
    {
        public HttpResponseToken(string token)
        {
            Token = token;
        }

        public HttpResponseToken(string token, string role)
        {
            Token = token;
            Role = role;
        }

        public string Token { get; set; }
        public string Role { get; set; }
    }
}
