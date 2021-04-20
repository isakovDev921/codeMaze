﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICompanyRepository
    {
        void CreateCompany(Company company);
        void DeleteCompany(Company company);

        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);
        Task<Company> GetCompanyAsync(Guid companyId, bool trackChanges);
        Task<IEnumerable<Company>> GetByIdAsync(IEnumerable<Guid> ids, bool trackChanges);
       
    }
}
