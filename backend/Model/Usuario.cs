using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using backend.Enum;

namespace backend.Model
{
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        [Column("nome")]
        public string Nome { get; set; }

        [Column("nivel_conta")]
        public string NivelConta { get; set; }

        [Column("tipo_perfil")]
        
        public PerfilEnum Perfil { get; set; }
        [Column("senha")]
        public string Senha{ get; set; }
    }
}