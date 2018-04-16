using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SearchReloader.Models;
using System.Threading.Tasks;

namespace SearchReloader.Controllers
{
    public class SimilarSearchController : ApiController
    {
        SimilarSearch[] siSearch = new SimilarSearch[]
        {
            new SimilarSearch {SimilarSearchId = 1, sameSearchBody = "Get 50% off Adidas", sameSearchTitle="Shoes" },
            new SimilarSearch {SimilarSearchId = 2, sameSearchBody = "AutoNation $2000 rebate", sameSearchTitle="Car" },
            new SimilarSearch {SimilarSearchId = 3, sameSearchBody = "BOGO at Gymboree", sameSearchTitle="Clothing" },
        };

        public IEnumerable<SimilarSearch> GetALL()
        {
            return siSearch;
        }

        // await to show after....
        [HttpGet]
        public async Task<IHttpActionResult> GetCoupon(string category)
        {
            var Coupons = siSearch.FirstOrDefault((p) => p.sameSearchTitle == category);
            await Task.Delay(5000);

            return await Task.FromResult(Ok(Coupons));
        }


   


        


    }
}
