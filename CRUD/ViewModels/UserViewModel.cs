using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Data de Aniversário")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Range(typeof(int), "00000000", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DisplayName("Telefone")]
        public decimal Telephone { get; set; }

        [DisplayName("Ativo")]
        public bool Activo { get; set; }
    }
}