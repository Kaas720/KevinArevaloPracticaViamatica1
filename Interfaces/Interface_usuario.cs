using KevinArevaloPracticaViamatica1.Models;
using Microsoft.AspNetCore.Mvc;

namespace KevinArevaloPracticaViamatica1.Interfaces
{
    public interface Interface_usuario
    {
        public Task<IEnumerable<Usuarios>> Get();
        public Task<IEnumerable<Usuarios>> GetNombre(string nombre);
        public Task<Usuarios> GetId(int id);
        public Task Nuevo_usuario(Usuarios user);
        public Task Editar_usuario(Usuarios user);
        public Task Eliminar_usuario(int id_user);
    }
}
