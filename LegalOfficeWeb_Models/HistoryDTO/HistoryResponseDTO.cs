using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.HistoryDTO
{
    public class HistoryResponseDTO
    {
        public int APHistoryId { get; set; }
        public int APManinId { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusNameAL { get; set; }
        public DateTime StatusDate { get; set; }
        public string StatusComment { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
    }
}
