using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpectrumDemoRadcliffe.Models
{
    public class User : Person
    {
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not valid")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not valid")]
        public string Password { get; set; }

        public virtual Person Person { get; set; }
    }
}
