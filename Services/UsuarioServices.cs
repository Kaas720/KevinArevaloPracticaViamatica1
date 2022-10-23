using KevinArevaloPracticaViamatica1.Data;
using KevinArevaloPracticaViamatica1.Interfaces;
using KevinArevaloPracticaViamatica1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace KevinArevaloPracticaViamatica1.Services
{
    public class UsuarioServices : Interface_usuario
	{
		private readonly DataContextKevinArevalo _context;
		public UsuarioServices(DataContextKevinArevalo _context)
		{
			this._context = _context;
			this._context.persona.ToList();
		}
		public async Task<IEnumerable<Usuarios>> Get()
        {
			try
			{
				var _usuario = await _context.usuario.ToListAsync();

				return _usuario;

            }
			catch (Exception)
			{

				throw;
			}
        }
		public async Task<IEnumerable<Usuarios>> GetNombre(string nombre)
        {
			try
			{
				IQueryable<Usuarios> users = _context.usuario;
				users = users.Where(e => e.idPerson.Nombres.StartsWith(nombre));
				return users;

			}
			catch (Exception)
			{

				throw;
			}
		}
		public async Task<Usuarios> GetId(int id)
		{
			try
			{
				var users = await _context.usuario.FindAsync(id);
				return users;

			}
			catch (Exception)
			{

				throw;
			}
		}
		public async Task Nuevo_usuario(Usuarios user)
        {
            try
            {
				_context.usuario.Add(user);
				await _context.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}
		public async Task Editar_usuario(Usuarios user)
        {
			try
			{
				_context.Entry(user).State = EntityState.Modified;
				try
				{
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{				
						throw;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
		public async Task Eliminar_usuario(int id_user)
        {
			try
			{
				var users = await _context.usuario.FindAsync(id_user);
				_context.usuario.Remove(users);
				try
				{
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateException)
				{
					throw;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
