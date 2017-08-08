using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BasicAuthentication.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
