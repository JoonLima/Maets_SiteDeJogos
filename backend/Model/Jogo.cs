using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Jogo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("preco")]
        public decimal Preco { get; set; }

        [Required]
        [Column("categoria")]
        public string Categoria { get; set; }

        [Required]
        [Column("classificacao")]
        public int Classificacao { get; set; }

        [Column("observacao")]
        public string Observacao { get; set; }

        [Column("desenvolvedor")]
        public Usuario Desenvolvedor { get; set; }
    }
}