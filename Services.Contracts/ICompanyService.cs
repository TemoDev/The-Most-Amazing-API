using Entities.Models;
using Shared.DataTransferObjects;

namespace Services.Contracts;

public interface ICompanyService
{
    IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
    CompanyDto GetCompany(Guid id, bool trackChanges);
    CompanyDto CreateCompany(CompanyForCreationDto company);
    
}