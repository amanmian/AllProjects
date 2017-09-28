using System;
namespace App.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        ApplicationDBContext Get();
    }
}
