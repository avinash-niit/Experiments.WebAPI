using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Experiments.WebAPI.Controllers
{
    [RoutePrefix("api/Strings")]
    public class StringsController : ApiController
    {
        public IEnumerable<string> GetStrings()
        {
            return new List<string> { "Alpha", "Beta" };
        }

        [ResponseType(typeof(string))]
        [Route("Reverse/{text}")]
        public string GetReversedString(string text) {
            char[] textInCharacters = text.ToCharArray();
            Array.Reverse(textInCharacters);
            return new string(textInCharacters);
        }
    }
}
