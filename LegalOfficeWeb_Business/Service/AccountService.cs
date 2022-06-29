using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class AccountService : IAccountService
    {
        private IAccountRepository accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public User GetByID(int id)
        {
            return accountRepository.GetByID(id);
        }
    }
}
