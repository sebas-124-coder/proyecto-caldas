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

        public IPasswordservice IPasswordservice { get; }

        private readonly IPasswordservice passwordservice;
        public UsuarioServices(DBContext DbContext,IPasswordservice passwordservice)
        {
            this.DbContext = DbContext;
            this.IPasswordservice = passwordservice;
        }
        public async Task CrearUsuario(usuariomodel arnol)
        {
            if (arnol != null)
            {
                arnol.Usuario_Contrasena = passwordservice.Hashpassword(arnol.Usuario_Contrasena);
                DbContext.Add(arnol);
                await DbContext.SaveChangesAsync();
            }



        }
    }
}