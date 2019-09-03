using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCsharp
{
    [Table("Compromissos")]
    public class Compromisso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        [MinLength(5)]
        public String Titulo { get; set; }
        [MaxLength(500)]
        public String Local { get; set; }
        [Required]
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

        public IList<Contato> Contatos { get; set; }

    }
}
