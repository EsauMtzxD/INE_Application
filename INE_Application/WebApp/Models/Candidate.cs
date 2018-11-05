using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Candidate
    {

        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El Campo NameCandidate es Obligatorio")]
        public string NameCandidate { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("PositionCandidate")]
        public int PositionId { get; set; }
        public PositionCandidate PositionCandidate { get; set; }

        [ForeignKey("PoliticalParty")]
        public int PoliticalPartyId { get; set; }
        public PoliticalParty PoliticalParty { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo LastName es Obligatorio")]
        public string LastName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "el campo MotherLastName es Obligatorio")]
        public string MotherLastName { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "El Campo Nationality es Obligatorio")]
        public string Nationality { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo Birthdate es Obligatorio")]
        public DateTime Birthdate { get; set; }
    
        [StringLength(20)]
        [Required(ErrorMessage = "El Campo Scholarship es Obligatorio")]
        public string Scholarship { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "El Campo JobTitle es Obligatorio")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "El Campo Sex es Obligatorio")]
        public string Sex { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo CreateDate Es Obligatorio")]
        public DateTime CreateDate { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El Campo CreateBy Es Obligatorio")]
        public string CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo es Obligatorio")]
        public DateTime ModifiedDate { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El Campo ModifyBy Es Obligatorio")]
        public string ModifyBy { get; set; }

    }
}