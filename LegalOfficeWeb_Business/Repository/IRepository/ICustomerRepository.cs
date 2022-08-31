using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CustomerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface ICustomerRepository
    {
        public Task<CustomerResponseDTO> SearchCustomer(SearchCustomerDTO objDTO);
        public Task<IEnumerable<NameHistoryDTO>> CustomerName(CustomerNameDTO objDTO);
    }
}
