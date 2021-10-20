using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDEmpresas.Models
{
    public class Empresas
    {
        [Key]
        public int CompaniesID { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage ="Este campo é de preenchimento obrigatório")]
        [DisplayName("Nome da Empresa")]
        public string CompaniesName  { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("CNPJ")]
        public string CompaniesCNPJ { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Endereço")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
    }
}
