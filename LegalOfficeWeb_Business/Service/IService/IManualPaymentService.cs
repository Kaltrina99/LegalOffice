using LegalOfficeWeb_Models.ManualPaymentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface IManualPaymentService
    {
        public Task CUDManualPayment(CUDManualPaymentDTO objDTO);
    }
}
