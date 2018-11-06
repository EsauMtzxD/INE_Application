using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Vote
    {
        /// <summary>
        /// Llave primaria de la tabla Vote.
        /// </summary>
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// Campo para guardar la fecha en que se realizo el voto.
        /// </summary>
        [Required(ErrorMessage = "El campo VoteDate es Obligatorio")]
        public DateTime VoteDate { get; set; }

        /// <summary>
        /// Llave foranea de la tabla TypeVote.
        /// </summary>
        [ForeignKey("TypeVote")]
        public int IdTypeVote { get; set; }
        public TypeVote TypeVote { get; set; }

        /// <summary>
        /// Llave foranea de la tabla Candidate.
        /// </summary>
        [ForeignKey("Candidate")]
        public int IdCandidate { get; set; }
        public Candidate Candidate { get; set; }

        /// <summary>
        /// Campo para guardar la fecha en que se creo el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo CreateDate Es Obligatorio")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Campo para guardar el usuario que creo el registro.
        /// </summary>
        [Required(ErrorMessage = "El campo CreateBy es Obligatorio")]
        public string CreateBy { get; set; }

        /// <summary>
        /// Campo para guardar la ultima fecha en que se modifico el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo ModifiedDate Es Obligatorio")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Campo para guardar el ultimo usuario que modifico el registro.
        /// </summary>
        [StringLength(30)]
        [Required(ErrorMessage = "El campo ModifyBy es Obligatorio")]
        public string ModifyBy { get; set; }

    }
}