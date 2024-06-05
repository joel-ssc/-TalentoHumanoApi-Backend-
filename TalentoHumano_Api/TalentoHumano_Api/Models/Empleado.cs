using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalentoHumano_Api.Models
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nombre {  get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public DateTime Fecha { get; set; }
    }
}