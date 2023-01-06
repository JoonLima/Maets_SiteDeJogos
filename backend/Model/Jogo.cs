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

        [MaxLength(120)]
        [Column("nome")]
        public string Nome { get; set; }

        [Column("preco")]
        public decimal Preco { get; set; }

        [Column("categoria")]
        public string Categoria { get; set; }

        [Column("classificacao")]
        public int Classificacao { get; set; }

        [Column("observacao")]
        public string Observacao { get; set; }

        [Column("usuarioId")]
        public Usuario UsuarioId { get; set; }
    }
}