using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEdwinPractica.Models;

namespace WebEdwinPractica.Controllers
{
    public class CuentasController : Controller
    {

        //Variable para crear el password
        private readonly UserManager<IdentityUser> _userManager;

        //Variable para autenticarse
        private readonly SignInManager<IdentityUser> _signInManager;

        //Creamos el construcyor de esta clase con ctor

        public CuentasController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //Guarda el registro en la base de datos

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registro(RegistroUsuarios ru)
        {
            //Verifico si el modelo es válido
            if (ModelState.IsValid)
            {
                //Creo una variable
                var usuario = new AppUsuario
                {
                    UserName = ru.Email,
                    Email = ru.Email,
                    Documento = ru.Documento,
                    Nombre = ru.Nombre
                };

                //Recibe dos parámetros, la variable, el usuario y el password
                var resultado = await _userManager.CreateAsync(usuario, ru.Password);
                // Verifica que todo salió bien
                if (resultado.Succeeded)
                {
                    // Autenticarse
                    await _signInManager.SignInAsync(usuario, isPersistent: false);
                    //Vuelva a la pagina de inicio
                    return RedirectToAction("Index", "Home");
                }
                ValidarErrores(resultado);
            }
            // Si el modelo no es válido retorna a la vista donde estaba
            return View(ru);
        }
        // Manejador de errores

        private void ValidarErrores(IdentityResult resultado)
        {
            foreach (var error in resultado.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        
        // Metodo crear formulario
        [HttpGet]
        public IActionResult Acceso()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Acceso(LoginUsuarios lu)
        {
            if (ModelState.IsValid)
            {
                //Recibe dos parametros, la variable el usuario y el password
                var resultado = await _signInManager.PasswordSignInAsync(lu.Email, lu.Password, lu.Rememberme, lockoutOnFailure: false);
                //Verifica que todo salió bien
                if (resultado.Succeeded)
                {
                    //Vuelva a la pagina de inicio
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Ingreso inválido");
                }

            }
            return View(lu);
        }

        //Cerrar cesión
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SalirAplicacion()
        {
            //Cierra la sesión (logout)
            await _signInManager.SignOutAsync();
            //Vuelve a la pagina de inicio
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> Registro()
        {
            RegistroUsuarios RuVista = new RegistroUsuarios();
            return View( RuVista);
        }

    }
}
