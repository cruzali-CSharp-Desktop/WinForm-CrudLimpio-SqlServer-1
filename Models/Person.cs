using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDFormSqlServer.Models
{
    public class Person
    {
        
        public int id { get; set; }
        
        [Required, RegularExpression(@"^.*[a-zA-z]")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ingrese un nombre válido de entre 3 y 50 caracteres.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ingrese un LastName de entre 3 y 50 caracteres.")]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string EmailAddress { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

    }
}
