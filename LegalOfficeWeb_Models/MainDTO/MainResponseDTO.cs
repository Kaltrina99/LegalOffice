using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.MainDTO
{
    public class MainResponseDTO
    {
        public int APManinId { get; set; }
        public int CaseId { get; set; }
        public double CompensationAmount { get; set; }
        public double EvaluationAmound { get; set; }
        public double OfferedAmound { get; set; }
        public double PaidAmound { get; set; }
        public string CreatedComment { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
    }
}
