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
        /// <summary>
        /// Llave primaria de mi tabla Candidate.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Campo para guardar el nombre del candidato.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "El Campo NameCandidate es Obligatorio")]
        public string NameCandidate { get; set; }

        /// <summary>
        /// Llave foranea de la tabla Address.
        /// </summary>
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        /// <summary>
        /// Llave foranea de la tabla PositionCandidate.
        /// </summary>
        [ForeignKey("PositionCandidate")]
        public int PositionId { get; set; }
        public PositionCandidate PositionCandidate { get; set; }

        /// <summary>
        /// Llave foranea de la tabla PoliticalParty.
        /// </summary>
        [ForeignKey("PoliticalParty")]
        public int PoliticalPartyId { get; set; }
        public PoliticalParty PoliticalParty { get; set; }

        /// <summary>
        /// Campo para guardar el apellido del candidato.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "El campo LastName es Obligatorio")]
        public string LastName { get; set; }

        /// <summary>
        /// Campo para guardar el apellido materno.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "el campo MotherLastName es Obligatorio")]
        public string MotherLastName { get; set; }

        /// <summary>
        /// Campo para guardar la nacionalidad del candidato.
        /// </summary>
        [StringLength(20)]
        [Required(ErrorMessage = "El Campo Nationality es Obligatorio")]
        public string Nationality { get; set; }

        /// <summary>
        /// Campo para guardar la fecha de nacimiento.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo Birthdate es Obligatorio")]
        public DateTime Birthdate { get; set; }
        
        /// <summary>
        /// Campo para guardar los estudios cursados del candidato.
        /// </summary>
        [StringLength(20)]
        [Required(ErrorMessage = "El Campo Scholarship es Obligatorio")]
        public string Scholarship { get; set; }

        /// <summary>
        /// Campo para guardar el titulo academico del candidato.
        /// </summary>
        [StringLength(20)]
        [Required(ErrorMessage = "El Campo JobTitle es Obligatorio")]
        public string JobTitle { get; set; }

        /// <summary>
        /// Campo para guardar el genero del candidato.
        /// </summary>
        [Required(ErrorMessage = "El Campo Sex es Obligatorio")]
        public string Sex { get; set; }

        /// <summary>
        /// Campo para guardar la fecha en que se creo el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo CreateDate Es Obligatorio")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Campo para guardar el usuario que creo el registro.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "El Campo CreateBy Es Obligatorio")]
        public string CreateBy { get; set; }

        /// <summary>
        /// Campo para guardar la ultima fecha en que se modifico el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo es Obligatorio")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Campo para guardar el ultimo usuario que modifico el registro.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "El Campo ModifyBy Es Obligatorio")]
        public string ModifyBy { get; set; }

    }
}