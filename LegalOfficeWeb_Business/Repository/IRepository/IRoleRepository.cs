using LegalOfficeWeb_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IRoleRepository
    {
        public List<Role> GetAll();
    }
}
