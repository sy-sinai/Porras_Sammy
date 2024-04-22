using System.ComponentModel.DataAnnotations;

namespace Porras_Sammy.Models
{
    public class Carrera
    {
        [Key]
        public string? Nnombre_carrera { get; set; }
        public string? Campus { get; set; }
        public string? numero_semestres { get; set; }
        
    }
}
