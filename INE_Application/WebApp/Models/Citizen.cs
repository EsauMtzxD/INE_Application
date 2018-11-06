using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Citizen
    {
        /// <summary>
        /// Llave primaria de mi tabla Citizen.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Campo para guardar el nombre o nombres del ciudadano.
        /// </summary>
        [Required(ErrorMessage = "El campo NameCitizen es obligatorio")]
        [StringLength(30)]
        public string NameCitizen { get; set; }

        /// <summary>
        /// Campo para guardar el apellido paterno del ciudadano.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "El campo LastName es obligatorio")]
        public string LastName { get; set; }

        /// <summary>
        /// Campo para guardar el apellido materno del ciudadano.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "El campo MotherLastName es obligatorio")]
        public string MotherLastName { get; set; }

        /// <summary>
        /// Campo para guardar la fecha de nacimiento del ciudadano.
        /// </summary>
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo Birthdate es obligatorio")]
        public string Birthdate { get; set; }

        /// <summary>
        /// Llave foranea de mi tabla Address
        /// </summary>
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        /// <summary>
        /// Campo para guardar la clave de elector del ciudadano.
        /// </summary>
        [StringLength(40)]
        [Required(ErrorMessage = "El campo KeyElector es obligatorio")]
        public string KeyElector { get; set; }

        /// <summary>
        /// Campo para guardar el CURP del ciudadano.
        /// </summary>
        [StringLength(40)]
        [Required(ErrorMessage = "El campo CURP es obligatorio")]
        public string CURP { get; set; }

        /// <summary>
        /// Campo para guardar la seccion del ciudadano.
        /// </summary>
        [StringLength(5)]
        [Required(ErrorMessage = "El campo Section es obligatorio")]
        public string Section { get; set; }

        /// <summary>
        /// Campo para guardar la fecha de vigencia de la credencial del ciudadano.
        /// </summary>
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo Validity es obligatorio")]
        public DateTime Validity { get; set; }

        /// <summary>
        /// Campo para guardar el genero del ciudadano.
        /// </summary>
        [Required(ErrorMessage = "El campo Sex es obligatorio")]
        public string Sex { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El campo CIC es obligatorio")]
        public string CIC { get; set; }

        /// <summary>
        /// Campo para guardar la emision de la credencial del ciudadano.
        /// </summary>
        [Required(ErrorMessage = "El campo Issue es obligatorio")]
        public string Issue { get; set; }
        
        /// <summary>
        /// Campo para guardar el año de registro del ciudadano.
        /// </summary>
        [Required(ErrorMessage = "El campo RegistrationYear es obligatorio")]
        public string RegistrationYear { get; set; }

        /// <summary>
        /// Campo para guardar la fecha en que se creo el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo CreateDate es obligatorio")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Campo para guardar el usuario que creo el registro.
        /// </summary>
        [Required(ErrorMessage = "El campo CreateBy es obligatorio")]
        public string CreateBy { get; set; }

        /// <summary>
        /// Campo para guardar la ultima fecha en que se modifico el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo ModifiedDate es obligatorio")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Campo para guardar el ultimo usuario que modifico el registro.
        /// </summary>
        [Required(ErrorMessage = "El campo ModifyBy es obligatorio")]
        public string ModifyBy { get; set; }
    }
}