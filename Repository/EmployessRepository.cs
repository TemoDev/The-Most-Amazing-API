using Contracts;
using Entities.Models;

namespace Repository;

public class EmployessRepository: RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployessRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
    
}