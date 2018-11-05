using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class City
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("StateProvince")]
        public int StateProvinceId { get; set; }
        public StateProvince StateProvince { get; set; }

        [Required(ErrorMessage = "El campo CveEnt es obligatorio")]
        public string CveEnt { get; set; }

        [Required(ErrorMessage = "El campo CveCity es obligatorio")]
        public string CveCity { get; set; }

        [Required(ErrorMessage = "El campo Description es obligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo CveCab es obligatorio")]
        public string CveCab { get; set; }

        public string NameCab { get; set; }

        [Required(ErrorMessage = "El campo PTOT es obligatorio")]
        public string PTOT { get; set; }

        [Required(ErrorMessage = "El campo PMAS es obligatorio")]
        public string PMAS { get; set; }

        [Required(ErrorMessage = "El campo PFEM es obligatorio")]
        public string PFEM { get; set; }

        [Required(ErrorMessage = "El campo VTOT es obligatorio")]
        public string VTOT { get; set; }

    }
}