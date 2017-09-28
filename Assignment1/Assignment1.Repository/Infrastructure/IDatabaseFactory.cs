using System;

namespace Assignment1.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Employeecontext Get();
    }
}