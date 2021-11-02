using System.Collections;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoInt.Domain.Interfaces
{
    public interface IaccountServices
    {
         Task<IEnumerable<account>> GetAllAccount();
         Task<account> GetFirstAccount();
    }
}