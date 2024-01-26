namespace Contracts;

public interface IRepositoryManager
{
    ICompanyRepository Company { get; set; }
    IEmployeeRepository Employee { get; set; }
    void Save();
}