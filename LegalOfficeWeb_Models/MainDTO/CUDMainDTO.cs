﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.MainDTO
{
    public class CUDMainDTO
    {
        public int UserId { get; set; }
        public int APManinId { get; set; }
        public int CaseId { get; set; }
        public double CompensationAmount { get; set; }
        public double EvaluationAmount { get; set; }
        public double OfferedAmount { get; set; }
        public double PaidAmount { get; set; }
        public string CreatedComment { get; set; }
        public int ProcessType { get; set; }
    }
}
