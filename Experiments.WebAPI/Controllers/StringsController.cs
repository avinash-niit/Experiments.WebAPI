using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

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
        public IHttpActionResult GetReversedString(string text) {
            IHttpActionResult result = null;
            if (text.Length < 100)
            {
                char[] textInCharacters = text.ToCharArray();
                Array.Reverse(textInCharacters);
                result = Ok(new string(textInCharacters));
            }
            else
            {
                result = InternalServerError(new ArgumentException("String Length should be less than 100"));
            }
            return result;
        }
    }
}
