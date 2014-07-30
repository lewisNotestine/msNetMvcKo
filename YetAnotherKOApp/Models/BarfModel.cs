using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;

namespace YetAnotherKOApp.Models
{
    public class BarfModel
    {
        /// <summary>
        /// Gets a list of random english words.
        /// </summary>
        public List<string> Barf()
        {
            var loremRequest = WebRequest.Create("http://loripsum.net/api");
            var response = loremRequest.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());

            var output = reader.ReadToEnd();
            return output.Split(new char[] { ' ' }).ToList();
        }
    }
}