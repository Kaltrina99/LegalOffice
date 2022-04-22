using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Role> GetAll()
        {
            var role = _context.Roles.AsEnumerable();
            return role.ToList();
        }
    }
}
