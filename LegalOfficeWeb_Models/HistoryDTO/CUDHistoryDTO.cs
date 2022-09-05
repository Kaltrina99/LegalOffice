using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.HistoryDTO
{
    public class CUDHistoryDTO
    {
        public int UserId { get; set; }
        public int APManinId { get; set; }
        public int APHistoryId { get; set; }
        public int StatusId { get; set; }
        public DateTime StatusDate { get; set; }
        public string CreatedComment { get; set; }
        public int ProcessType { get; set; }
    }
}
