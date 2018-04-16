using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchReloader.Models
{

    // class returns the searches that are available
    public class SearchResult
    {
        public int SearchId { get; set; }
        public string SearchResultContent { get; set; }
        public string SearchKeyWord { get; set; }
        public DateTime SearchedDate { get; set; }




    }
}