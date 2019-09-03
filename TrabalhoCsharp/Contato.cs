using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCsharp
{
    [Table("Contatos")]
    public class Contato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        [MaxLength(20)]
        public String Telefone { get; set; }

        public IList<Compromisso> Compromissos { get; set; }

    }
}
