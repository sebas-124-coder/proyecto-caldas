using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_caldas.services
{
    public interface IPasswordservice
    {
        string Hashpassword(string password);
    }
}