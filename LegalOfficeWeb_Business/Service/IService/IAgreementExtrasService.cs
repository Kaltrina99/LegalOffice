using LegalOfficeWeb_Models.AgreementExtrasDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface IAgreementExtrasService
    {
        public Task<IEnumerable<AgreementNotificationResponseDTO>> AgreementNotification(AgreementFilterDataDTO objDTO);
        public Task<IEnumerable<AgreementInvoiceResponseDTO>> AgreementInvoices(AgreementFilterDataDTO objDTO);
        public Task<IEnumerable<AgreemeentInvoicePaymentsResponseDTO>> AgreemeentInvoicePayments(AgreementFilterDataDTO objDTO);
        public Task<IEnumerable<AgreementInstallmentResponseDTO>> AgreementInstallmentResponseDTOs(AgreementFilterDataDTO objDTO);
    }
}
