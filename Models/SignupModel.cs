using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject1.Models
{
    public class SignupModel
    {
        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string userName { get; set; }

        [Required, MaxLength(20)]
        public string userPassword { get; set; }
    }
}
