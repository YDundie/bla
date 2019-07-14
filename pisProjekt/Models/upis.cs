using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pisProjekt.Models
{
    public class upis
    {
        public int id { get; set; }
        [StringLength(255)]

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [Display(Name = "Ime")]
        public String ime { get; set; }
        [StringLength(255)]

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [Display(Name = "Prezime")]
        public String prezime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [Display(Name = "Broj telefona")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} mora biti numericki podatak")]
        public int brojTelefona { get; set; }

        [StringLength(255)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [Display(Name = "Adresa")]
        public String adresa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [Display(Name = "Broj Adrese")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} mora biti numericki podatak")]
        public int brojAdrese { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [Display(Name = "Država")]
        public String zemlja { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [Display(Name = "Grad")]
        public String grad { get; set; }
    }
}
