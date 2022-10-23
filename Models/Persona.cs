using System.ComponentModel.DataAnnotations;

namespace KevinArevaloPracticaViamatica1.Models
{
    public class Persona
    {

        [Key]
        public int idPersona { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? estado { get; set; }

    }
}
