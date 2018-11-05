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

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo NameCitizen es obligatorio")]
        [StringLength(30)]
        public string NameCitizen { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo LastName es obligatorio")]
        public string LastName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo MotherLastName es obligatorio")]
        public string MotherLastName { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo Birthdate es obligatorio")]
        public string Birthdate { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "El campo KeyElector es obligatorio")]
        public string KeyElector { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "El campo CURP es obligatorio")]
        public string CURP { get; set; }

        [StringLength(5)]
        [Required(ErrorMessage = "El campo Section es obligatorio")]
        public string Section { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo Validity es obligatorio")]
        public DateTime Validity { get; set; }

        [Required(ErrorMessage = "El campo Sex es obligatorio")]
        public string Sex { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El campo CIC es obligatorio")]
        public string CIC { get; set; }

        [Required(ErrorMessage = "El campo Issue es obligatorio")]
        public string Issue { get; set; }


        [Required(ErrorMessage = "El campo RegistrationYear es obligatorio")]
        public string RegistrationYear { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo CreateDate es obligatorio")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "El campo CreateBy es obligatorio")]
        public string CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo ModifiedDate es obligatorio")]
        public DateTime ModifiedDate { get; set; }

        [Required(ErrorMessage = "El campo ModifyBy es obligatorio")]
        public string ModifyBy { get; set; }

    }
}