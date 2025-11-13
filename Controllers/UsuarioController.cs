using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto_caldas.implementacion;
using proyecto_caldas.Models;
using proyecto_caldas.services;

namespace proyecto_caldas.Controllers
{
    [Route("user")]
    public class UsuarioController : Controller
    {
        private readonly IUsuario usuarioservice;

        public UsuarioController(IUsuario usuarioService)
        {
            this.usuarioservice = usuarioService;
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(usuariomodel usuario)
        {
            if (ModelState.IsValid)
            {
                await usuarioservice.CrearUsuario(usuario);
                return RedirectToAction("Index", "Home");
            }
            return View(usuario);
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
    }

}
