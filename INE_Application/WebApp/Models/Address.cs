using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Address
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("CountryRegion")]
        public int CountryRegionId { get; set; }
        public CountryRegion CountryRegion { get; set; }

        [ForeignKey("StateProvince")]
        public int StateProvinceId { get; set; }
        public StateProvince StateProvince { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }

        [Required(ErrorMessage = "El campo Street es obligatorio")]
        public string Street { get; set; }

        [Required(ErrorMessage = "El campo NumberHouse es obligatorio")]
        public string  NumberHouse { get; set; }

        [Required(ErrorMessage = "El campo Colony es obligatorio")]
        public string Colony { get; set; }

        [Required(ErrorMessage = "El campo CodePostale es obligatorio")]
        public string CodePostale { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }

    }
}