using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class StateProvince
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("CountryRegion")]
        public int CountryRegionId { get; set; }
        public CountryRegion CountryRegion { get; set; }

        [Required(ErrorMessage = "El campo CveEnt Es Obligatorio")]
        public string CveEnt { get; set; }

        [Required(ErrorMessage = "El campo Description es Obligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo Abrev es obligatorio")]
        public string Abrev { get; set; }

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

        public virtual ICollection<City> Cities { get; set; }

    }
}