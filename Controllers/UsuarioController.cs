using Microsoft.AspNetCore.Mvc;
using KevinArevaloPracticaViamatica1.Interfaces;
using KevinArevaloPracticaViamatica1.Models;

namespace KevinArevaloPracticaViamatica1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        readonly private Interface_usuario pruebaInterface;

        public UsuarioController(Interface_usuario _pruebaInterface)
        {
            this.pruebaInterface = _pruebaInterface;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try {

                dynamic res = pruebaInterface.Get();
                res = await res;
                return Ok(res);
            }
            catch (Exception e)
            {
                return Content("Erorr la razon es: "+e.Message);
            }
        }
        [HttpGet("busquedaporNombre/{nombre}")]
        public async Task<ActionResult> Get_user_por_nombre(string nombre)
        {
            try
            {

                dynamic res = pruebaInterface.GetNombre(nombre);
                res = await res;
                return Ok(res);
            }
            catch (Exception e)
            {
                return Content("Erorr la razon es: "+e.Message);
            }
        }
        [HttpGet("busquedaporId/{id}")]
        public async Task<ActionResult> Get_user_por_id(int id)
        {
            try
            {

                dynamic res = pruebaInterface.GetId(id);
                res = await res;
                if (res != null)
                {
                    return Ok(res);
                }
                else
                {
                    return NotFound("No se encontro el usuario");
                }
            }
            catch (Exception e)
            {
                return Content("Erorr la razon es: "+e.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult> Nuevo_ususario(Usuarios user)
        {
            try
            {
                await pruebaInterface.Nuevo_usuario(user);
                return CreatedAtAction("Get_user_por_id", new { id = user.idUsuaio }, user);
            }
            catch (Exception e)
            {
                return Content("Erorr la razon es: "+e.Message);
            }   
        }


        [HttpPut]
        public async Task<ActionResult> Editar_ususario(Usuarios user)
        {
            try
            {
                await pruebaInterface.Editar_usuario(user);
                return Ok("Usuario editado con exito");
            }
            catch (Exception e)
            {
                return Content("Erorr la razon es: " + e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_usuario(int id)
        {
             try
            {
                await pruebaInterface.Eliminar_usuario(id);
                return Ok("Usuario eliminado con exito");
            }
            catch (Exception e)
            {
                return Content("Erorr la razon es: " + e.Message);
            }
        }

    }
}
