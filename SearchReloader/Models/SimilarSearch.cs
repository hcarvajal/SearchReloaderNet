using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchReloader.Models
{
    public class SimilarSearch
    {
       public int SimilarSearchId { get; set; }
       public string sameSearchTitle { get; set; }
       public string sameSearchBody { get; set; }
       public string sameSearchPicture { get; set; }
       public string sameResultDate { get; set; }

    }
}