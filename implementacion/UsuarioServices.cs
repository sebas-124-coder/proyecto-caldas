using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_caldas.Data;
using proyecto_caldas.Models;
using proyecto_caldas.services;

namespace proyecto_caldas.implementacion
{
    public class UsuarioServices : IUsuario
    {
        private readonly DBContext DbContext;
        public UsuarioServices(DBContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public async void CrearUsuario(usuariomodel arnol)
        {
            if (arnol != null)
            {
                DbContext.Add(arnol);
                await DbContext.SaveChangesAsync();
            }



        }
    }
}