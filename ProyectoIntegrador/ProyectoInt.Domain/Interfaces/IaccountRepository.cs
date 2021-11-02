using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoInt.Domain.Interfaces
{
    public interface IaccountRepository
    {
        Task<IEnumerable<account>> GetAll();
    }
}