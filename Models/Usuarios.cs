
using System.ComponentModel.DataAnnotations;

namespace KevinArevaloPracticaViamatica1.Models
{
    public class Usuarios
    {
        [Key]
        public int idUsuaio { get; set; }
        public string? Usuario { get; set; }
        public string? Clave { get; set; }
        public string? Estado { get; set; }
        public Persona? idPerson { get; set; }
    }
}
