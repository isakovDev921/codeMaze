using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(Guid companyId, bool trackChanges);
        void CreateCompany(Company company);
        IEnumerable<Company> GetById(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteCompany(Company company);
    }
}
