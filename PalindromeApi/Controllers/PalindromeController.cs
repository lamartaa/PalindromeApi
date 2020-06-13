using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Palindrome.Shared.Helpers;
using PalindromeApi.Models.Response;

namespace PalindromeApi.Controllers
{
    public class PalindromeController : Controller
    {
        [Route("api/[controller]/palindromeAnalysis")]
        [HttpGet]
        public IActionResult PalindromeAnalysis(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                HttpContext.Response.StatusCode = 500;
                string error = "No input provided. Please provide inputed text.";
                return new JsonResult(new ErrorResponse() { StatusCode = 500, ErrorMsg = error });
            }

            if(Regex.IsMatch(input, @"^[a-zA-Z]+$") == false)
            {
                HttpContext.Response.StatusCode = 500;
                string error = "Input provided includes non-alphabetical characters. Please include alphabetical characters only.";
                return new JsonResult(new ErrorResponse() { StatusCode = 500, ErrorMsg = error });
            }

            var result = PalindromeHelper.AnalyzeText(input);

            var response = new PalindromeAnalysisResponse();

            response.Output = new PalindromeAnalysis()
            {
                IsPalindrome = result.IsPalindrome,
                SortedCharacterCount = result.SortedCharacterCount,
                TimeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            return new JsonResult(response);
        }
    }
}
