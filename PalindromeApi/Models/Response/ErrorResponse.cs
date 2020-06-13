using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeApi.Models.Response
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string ErrorMsg { get; set; }
    }
}
