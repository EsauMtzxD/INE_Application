using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class CountryRegion
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Description es Obligatorio")]
        [StringLength(100, ErrorMessage = "La maxima longitud del campo es de 100 caracteres")]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    
        [Required(ErrorMessage = "El campo FIPS104 es obligatorio")]
        public string FIPS104 { get; set; }

        [Required(ErrorMessage = "El campo ISO2 es obligatorio")]
        public string ISO2 { get; set; }

        [Required(ErrorMessage = "El campo ISO3 es obligatorio")]
        public string ISO3 { get; set; }

        [Required(ErrorMessage = "El campo ISON es obligatorio")]
        public string ISON { get; set; }

        [Required(ErrorMessage = "El campo Internet es obligatorio")]
        public string Internet { get; set; }

        [Required(ErrorMessage = "El campo Capital es obligatorio")]
        public string Capital { get; set; }

        [Required(ErrorMessage = "El campo MapReference es obligatorio")]
        public string MapReference { get; set; }

        [Required(ErrorMessage = "El campo NationalityPlural es obligatorio")]
        public string NationalityPlural { get; set; }

        [Required(ErrorMessage = "El campo Currency es obligatorio")]
        public string Currency { get; set; }

        [Required(ErrorMessage = "El campo CurrencyCode es obligatorio")]
        public string CurrencyCode { get; set; }

        [Required(ErrorMessage = "El campo Population es obligatorio")]
        public int Population { get; set; }

        [Required(ErrorMessage = "El campo Title es obligatorio")]
        public string Title { get; set; }

        public string Comment { get; set; }

        public virtual ICollection<StateProvince> StateProvinces { get; set; }

    }
}