﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalOfficeWeb_DataAccess.Data;
using LegalOfficeWeb_Models;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IAdministrativeProcessRepository
    {
        public Task<AdministrativeProcessDTO> Create(AdministrativeProcessDTO objDTO);
        public Task<AdministrativeProcessDTO> Update(AdministrativeProcessDTO objDTO);
        public Task<int> Delete(int id);
        public Task<AdministrativeProcessDTO> Get(int id);
        public Task<IEnumerable<AdministrativeProcessDTO>> GetAll();
        public Task<ApStatus> GetApStatus(int id);
        public Task<IEnumerable<ApStatus>> GetAllStatuses();
    }
}
