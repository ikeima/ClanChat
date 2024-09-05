using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClanChat.Domain.Interfaces
{
    interface IRepository<T> : IDisposable 
        where T : class
    {

    }
}
