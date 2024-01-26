using Contracts;

namespace Repository;

public class RepositoryManager: IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }
    
    public ICompanyRepository Company { get; set; }
    public IEmployeeRepository Employee { get; set; }
    public void Save()
    {
        throw new NotImplementedException();
    }
}