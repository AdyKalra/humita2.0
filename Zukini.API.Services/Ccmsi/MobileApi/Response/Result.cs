using System.Collections.Generic;

namespace Zukini.API.Examples.Features.Ccmsi.MobileApi.Response
{
    public class Result
    {
        public List<EntityItemList> entityItemList { get; set; }
        public int totalPages { get; set; }
        public int totalRows { get; set; }
        public int currentPage { get; set; }
        public int nextPage { get; set; }
        public object previousPage { get; set; }
    }
}