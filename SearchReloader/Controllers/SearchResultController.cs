using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SearchReloader.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SearchReloader.Controllers
{
    public class SearchResultController : ApiController
    {

        SearchResult[] sresult = new SearchResult[]
      {
          new SearchResult {SearchId = 1, SearchResultContent="Uber has electronic cars", SearchKeyWord="Car" },
          new SearchResult {SearchId = 2, SearchResultContent="Adidas vs Nike Sports Shoes", SearchKeyWord="Shoes" },
          new SearchResult {SearchId = 3, SearchResultContent="Dresses", SearchKeyWord="Clothing" }

      };




        public IEnumerable<SearchResult> GetAllResults()
        {
            return sresult;
        }

        [HttpGet]
        public IHttpActionResult GetSearch(string category)
        {
            var searchResult = sresult.FirstOrDefault((p) => p.SearchKeyWord == category);

            return Ok(searchResult);
        }












    }
}
