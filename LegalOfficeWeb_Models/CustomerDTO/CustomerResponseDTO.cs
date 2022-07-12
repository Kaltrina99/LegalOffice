using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class CustomerResponseDTO
    {
        public int AgencyId { get; set; }
        public int EldebitorId { get; set; }
        public string CustomerName { get; set; }
        public string MeterAddress { get; set; }
        public string TariffGroupId { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalNo { get; set; }
        public string SubDistrict { get; set; }
        public int AMeterId { get; set; }
    }
}
