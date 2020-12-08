using System;
using ThreeTierArchitecture.DAL.Entities;

namespace ThreeTierArchitecture.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Phone> Phones { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
