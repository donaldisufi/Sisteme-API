using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Models
{
    public class DataError
    {
        public DataError(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
        public static string Error { get; set; }
    }
}
