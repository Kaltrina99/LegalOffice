using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesGetAllAgreementsDTO
    {
        public int UserId { get; set; }
        public string? District { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
