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
        /// <summary>
        /// Llave primaria de mi tabla Address
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Llave foranea de la tabla CountryRegion.
        /// </summary>
        [ForeignKey("CountryRegion")]
        public int CountryRegionId { get; set; }
        public CountryRegion CountryRegion { get; set; }

        /// <summary>
        /// Llave foranea de la tabla StateProvince.
        /// </summary>
        [ForeignKey("StateProvince")]
        public int StateProvinceId { get; set; }
        public StateProvince StateProvince { get; set; }

        /// <summary>
        /// Llave foranea de la tabla City.
        /// </summary>
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }

        /// <summary>
        /// Campo para guardar el nombre de la calle.
        /// </summary>
        [Required(ErrorMessage = "El campo Street es obligatorio")]
        public string Street { get; set; }

        /// <summary>
        /// Campo para guardar el numero del domicilio
        /// </summary>
        [Required(ErrorMessage = "El campo NumberHouse es obligatorio")]
        public string  NumberHouse { get; set; }

        /// <summary>
        /// Campo para guardar el nombre de la colonia.
        /// </summary>
        [Required(ErrorMessage = "El campo Colony es obligatorio")]
        public string Colony { get; set; }

        /// <summary>
        /// Campo para guardar el codigo postal.
        /// </summary>
        [Required(ErrorMessage = "El campo CodePostale es obligatorio")]
        public string CodePostale { get; set; }

        /// <summary>
        /// Relacion entre las tablas Address - Candidates.
        /// </summary>
        public virtual ICollection<Candidate> Candidates { get; set; }

        /// <summary>
        /// Relacion entre las tablas Address - Citizens.
        /// </summary>
        public virtual ICollection<Citizen> Citizens { get; set; }

    }
}