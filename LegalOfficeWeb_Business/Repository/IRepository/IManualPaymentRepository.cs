using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models.ManualPaymentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IManualPaymentRepository
    {
        public Task CUDManualPayment(CUDManualPaymentDTO objDTO);
    }
}
