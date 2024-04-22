using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Porras_Sammy.Models
{
    public class SPorras
    {
        [Key]
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public Boolean EstudianteActivo { get; set; }// El estad del estudiante
        public required int IDBanner { get; set; } //numero identificador de banner
        [AllowNull]
        public float ValorSemestral { get; set; }// valor del semestre 
        public string? Nombre { get; set; } //Nombre completo del estudiante
        public DateTime? FechaIngreso { get; set; } // fecha de ingreso a la universidad
        public Carrera carrera { get; set; }
       
        
    }
}
