using LegalOfficeWeb_Common.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Common.Wrappers
{
    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string FirstPage { get; set; }
        public string LastPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public string NextPage { get; set; }
        public string PreviousPage { get; set; }
        public PagedResponse(T data, int pageNumber, int pageSize,int total,string route)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Data = data;
            this.TotalRecords = total;
            decimal val =(decimal) total / pageSize;
            decimal pageDecimal = Math.Ceiling(val);
            int page=(int)pageDecimal;
            route = "text";   
            this.NextPage = pageNumber >= 1 && pageNumber < page
               ?route+ $"PageIndex={pageNumber + 1}&PageSize={pageSize}"
               : null;
            this.PreviousPage =
                pageNumber - 1 >= 1 && pageNumber <= page
                ? route + $"PageIndex={pageNumber - 1}&PageSize={pageSize}"
                : null;
            this.FirstPage = route.ToString() +$"PageIndex={ 1}&PageSize={pageSize}";
            this.LastPage = route.ToString() + $"PageIndex={page}&PageSize={pageSize}";

            this.TotalPages = page;
            this.Message = null;
            this.Succeeded = true;
            this.Errors = null;
        }
    }
}
