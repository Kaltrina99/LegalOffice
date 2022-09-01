using LegalOfficeWeb_Models.AgreementExtrasDTO;
using LegalOfficeWeb_Models.CaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IAgreementExtrasRepository
    {
        public Task<IEnumerable<AgreementNotificationResponseDTO>> AgreementNotification(AgreementFilterDataDTO objDTO);
        public Task<IEnumerable<AgreementInvoiceResponseDTO>> AgreementInvoices(AgreementFilterDataDTO objDTO);
        public Task<IEnumerable<AgreemeentInvoicePaymentsResponseDTO>> AgreemeentInvoicePayments(AgreementFilterDataDTO objDTO);
        public Task<IEnumerable<AgreementInstallmentResponseDTO>> AgreementInstallmentResponseDTOs(AgreementFilterDataDTO objDTO);
    }
}
