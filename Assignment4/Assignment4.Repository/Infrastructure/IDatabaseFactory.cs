using System;

namespace Assignment4.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Employeecontext Get();
    }
}