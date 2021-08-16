using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoDeEmail.Models
{
    public class TestModels
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Nome { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Sobrenome { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        
        [Column(TypeName = "DateTime2")]
        public DateTime DataNascimento { get; set; }
        
        [Column(TypeName = "nvarchar(20)")]
        public string Escolaridade { get; set; }
    }
}
